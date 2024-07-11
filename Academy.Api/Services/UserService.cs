using Academy.Api.Data;
using Academy.Api.Models;
using Academy.Api.TelegramBot;
using Microsoft.EntityFrameworkCore;

namespace Academy.Api.Services;
public class UserService : IUserService
{
    private readonly DataContext _context;
    private readonly IConfiguration _configuration;

    public UserService(DataContext context)
    {
        _context = context;
    }

    public async Task<User> InsertAsync(User model)
    {
       var user = await _context.Users.FirstOrDefaultAsync(u => u.Phone.Equals(model.Phone));

        if(user is  null)
        {
            var result = await _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();
            
        TelegramBotSend telegram = new TelegramBotSend(_configuration);
        await telegram.SendMessageToTelegramBot(user);
            return result.Entity;
        }
                
        return user;
    }

}

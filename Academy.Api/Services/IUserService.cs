using Academy.Api.Models;

namespace Academy.Api.Services;
public interface IUserService
{
    Task<User> InsertAsync(User model);
}

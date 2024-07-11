
using Academy.Api.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace AcademyTelegramBot.TelegramCommands
{
    public class TelegramBotSend
    {
        private readonly ITelegramBotClient _botClient;

        public TelegramBotSend(IConfiguration config)
        {
            _botClient = new TelegramBotClient(config["TelegramBotAPIKey"]);
        }

        public async ValueTask SendMessageToTelegramBot(User user)
        {
            var text = $"ID: {user.Id}\nFirstName: {user.FirstName}\nPhone Number: {user.Phone}";

            await _botClient.SendTextMessageAsync(
                chatId: 677944112,
                text: text);
        }
    }
}

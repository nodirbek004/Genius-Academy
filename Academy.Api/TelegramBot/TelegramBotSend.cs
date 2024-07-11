using Academy.Api.Models;
using Telegram.Bot;

namespace Academy.Api.TelegramBot
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

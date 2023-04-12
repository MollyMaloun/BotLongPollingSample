using Telegram.Bot;

namespace BotLongPollingSample.BotLogic
{
    internal class Bot
    {
        private static TelegramBotClient client { get; set; }
        public static TelegramBotClient GetTelegramBot()
        {
            if (client != null)
            {
                return client;
            }
            client = new TelegramBotClient(Your bot token);
            return client;
        }
    }
}

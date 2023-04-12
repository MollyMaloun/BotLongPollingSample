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
            client = new TelegramBotClient("6152206590:AAF-6G8ARkx8QVH5UH9s8EBUwBZY_dNJPic");
            return client;
        }
    }
}

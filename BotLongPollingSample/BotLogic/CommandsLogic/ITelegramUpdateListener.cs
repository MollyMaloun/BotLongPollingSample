using Telegram.Bot.Types;

namespace BotLongPollingSample.BotLogic.CommandsLogic
{
    public interface ITelegramUpdateListener
    {
        public async Task GetUpdate(Update update) { }
    }
}

using Telegram.Bot;
using Telegram.Bot.Types;

namespace BotLongPollingSample.BotLogic.CommandsLogic
{
    internal interface ICommand
    {
        public TelegramBotClient Client { get; }
        public string Name { get; }
        public async Task Execute(Update update) { }
    }
}

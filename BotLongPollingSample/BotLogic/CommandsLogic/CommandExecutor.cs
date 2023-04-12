using BotLongPollingSample.BotLogic.CommandsLogic.Commands;
using Telegram.Bot.Types;

namespace BotLongPollingSample.BotLogic.CommandsLogic
{
    internal class CommandExecutor : ITelegramUpdateListener
    {
        private List<ICommand> commands;
        public CommandExecutor()
        {
            commands = new List<ICommand>();//Команды добавлять сюда
            commands.Add(new StartCommand());
        }
        public async Task GetUpdate(Update update)
        {
            Message mes = update.Message;
            if (mes.Text == null)
            {
                return;
            }

            foreach (var command in commands)
            {
                if (command.Name == mes.Text)
                {
                    await command.Execute(update);
                }
            }
        }
    }
}

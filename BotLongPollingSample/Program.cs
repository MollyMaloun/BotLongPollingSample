using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
//using AngleSharp.Html.Parser;
//using AngleSharp.Dom;
using System.Net.Http.Json;
using System.Net;
using BotLongPollingSample.BotLogic;
using BotLongPollingSample.BotLogic.CommandsLogic;


namespace BotLongPollingSample
{
    internal class Program
    {
        static ITelegramBotClient bot = Bot.GetTelegramBot();



        public static async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
        {
            UpdateDistributor<CommandExecutor> executor = new UpdateDistributor<CommandExecutor>();
            executor.GetUpdate(update);
            await Console.Out.WriteLineAsync(Newtonsoft.Json.JsonConvert.SerializeObject(update));
        }
        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}
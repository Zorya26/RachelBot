using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using MihaZupan;

namespace RachelBot
{
    class Program
    {
        private static ITelegramBotClient botClient;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("1373867194:AAHbsrXtDzusn-8AWywzAELTr_2hLMNtGms") {Timeout = TimeSpan.FromSeconds(10)};
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine($"Bot Id: {me.Id}, Bot name: {me.FirstName}");
        }
    }
}
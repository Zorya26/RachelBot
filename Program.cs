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

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var text = e?.Message?.Text;
            if (text == null) return;
            Console.WriteLine($"Message: {text} in chat: {e.Message.Chat.Id}");

            await botClient.SendTextMessageAsync(
                chatId: e.Message.Chat,
                text: $"you say {text}?"
                ).ConfigureAwait(false);
        }
    }
}
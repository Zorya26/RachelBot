using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using MihaZupan;

namespa
            Console.ReadLine();
            botClient.StopReceiving();

            Console.ReadKey();
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

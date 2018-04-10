using Telegram.Bot;
using Telegram.Bot.Types;

namespace HAL_9000.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override void Execute(Message message, TelegramBotClient client)
        {
            client.SendTextMessageAsync(message.Chat.Id, $"Hello {message.From.FirstName} {message.From.LastName}!", replyToMessageId: message.MessageId);
        }
    }
}
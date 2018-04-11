using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HAL_9000.Models.Commands
{
    public class RollCommand : Command
    {
        public override string Name => "roll";

        public override void Execute(Message message, TelegramBotClient client)
        {
            client.SendTextMessageAsync(message.Chat.Id, $"{AppSettings.GetRandom.Next(0, 101).ToString()}", replyToMessageId: message.MessageId);
        }
    }
}
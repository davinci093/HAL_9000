using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HAL_9000.Models.Commands
{
    public class RSPCommand : Command
    {
        public override string Name => "rsp";

        public override void Execute(Message message, TelegramBotClient client)
        {
            client.SendTextMessageAsync(message.Chat.Id, "RSP game startedaaaa");
        }
    }
}
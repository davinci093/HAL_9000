using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HAL_9000.Models.Commands
{
    public class ProposeChangeCommand : Command
    {
        public override string Name => "proposition";

        //XmlSerializer xml = new XmlSerializer(typeof(Proposition));

        public override void Execute(Message message, TelegramBotClient client)
        {
            //TODO
            //string propText = message.Text.Substring(Name.Length);
            //if (message.Text.Length > Name.Length + 1)
            //{
            //    Proposition proposition = new Proposition(message.From.Id, message.From.FirstName, propText);
            //    using (FileStream fs = new FileStream("d:/proposes.xml", FileMode.Append))
            //    {
            //        xml.Serialize(fs, proposition);
            //    }

            //    client.SendTextMessageAsync(message.Chat.Id, "Предложение внесено", replyToMessageId: message.MessageId);
            //}

            //else
            //    client.SendTextMessageAsync(message.Chat.Id, "Отсутствует текст предложения", replyToMessageId: message.MessageId);

            throw new NotImplementedException();
        }
    }

    public class PropositionsCommand : Command
    {
        public override string Name => "propositions";

        public override void Execute(Message message, TelegramBotClient client)
        {
            //TODO



            //throw new NotImplementedException();
        }
    }

    [Serializable]
    public class Proposition
    {
        public int FromId { get; set; }
        public string FromName { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public Proposition(int fromId, string fromName, string text)
        {
            FromId = fromId;
            FromName = fromName;
            Text = text;
            Time = DateTime.Now;
        }
    }
}
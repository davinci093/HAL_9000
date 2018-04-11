using Telegram.Bot;
using Telegram.Bot.Types;

namespace HAL_9000.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            //return command == $"/{Name}";
            //return Name[0] == '/' && Name.Contains($"/{Name}");
            return Name.Contains(Name);
        }
    }
}
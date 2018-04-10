using HAL_9000.Models.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;

namespace HAL_9000.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
                return client;
            else
            {
                GetCommands();
                client = new TelegramBotClient(Settings.Token);
                string hook = string.Format(Settings.Url, Settings.Path);
                await client.SetWebhookAsync(hook);
                return client;
            }
        }

        private static void GetCommands()
        {
            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand());
        }


    }
}
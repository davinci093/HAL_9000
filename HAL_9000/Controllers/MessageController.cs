﻿using HAL_9000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HAL_9000.Controllers
{
    public class MessageController : ApiController
    {
        [Route(AppSettings.Path)]
        public async Task<OkResult> Update([FromBody]Update update)
        {

            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (message.Text != null && command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    return Ok();
                }
            }

            return Ok();
        }
    }
}

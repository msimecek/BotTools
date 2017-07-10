using Microsoft.Bot.Builder.ConnectorEx;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BotTools.Helpers
{
    public static class BotMessages
    {
        public static async Task PostTyping(this IDialogContext context)
        {
            var typingMessage = context.MakeMessage();
            typingMessage.Type = ActivityTypes.Typing;
            typingMessage.Text = null;
            await context.PostAsync(typingMessage);
        }

        public static async Task PostWithQuickRepliesAsync(this IDialogContext context, string text, params FacebookQuickReply [] replies)
        {
            var message = context.MakeMessage();
            message.Text = text;
            message.ChannelData = new FacebookMessage(text, replies);
            await context.PostAsync(message);
        }
        
        public static async Task PostWithQuickRepliesAsync(this IDialogContext context, string text, (string Description, string Value) replies)
        {
            var message = context.MakeMessage();
            message.AddKeyboardCard(text, new string[] { replies.Value }, new string[] { replies.Description });
            await context.PostAsync(message);
        }
    }
}
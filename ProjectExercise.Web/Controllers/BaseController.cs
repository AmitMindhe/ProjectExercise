using ProjectExercise.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ProjectExercise.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        private HttpSessionStateBase GetSession()
        {
            return Session;
        }

        public void AddNotificationMessage(string title, string message, NotificationMessageTypes notificationMessageType = NotificationMessageTypes.Success, bool show = true)
        {
            var session = GetSession();
            var messages = session["projectExercise.notificationmessages"] as IList<NotificationMessage>;
            if (messages == null)
            {
                messages = new List<NotificationMessage>();
                session.Add("projectExercise.notificationmessages", messages);
            }
            messages.Add(new NotificationMessage() { Title = title, Message = message, Show = show, NotificationMessageType = notificationMessageType });
        }

        public void AddNotificationMessage(NotificationMessage notificationMessage)
        {
            if (notificationMessage != null)
            {
                var session = GetSession();
                var messages = session["projectExercise.notificationmessages"] as IList<NotificationMessage>;
                if (messages == null)
                {
                    messages = new List<NotificationMessage>();
                    session.Add("projectExercise.notificationmessages", messages);
                }
                messages.Add(notificationMessage);
            }
        }

        public IList<NotificationMessage> GetNotificationMessages(bool removeOnRetrival = true)
        {
            var session = GetSession();
            var errors = session["projectExercise.notificationmessages"] as IList<NotificationMessage>;
            if (errors != null && removeOnRetrival)
                session.Remove("projectExercise.notificationmessages");
            return errors;
        }
    }
}
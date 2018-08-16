using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core
{
    public class NotificationMessage
    {

        public NotificationMessage()
        {
            NotificationMessageType = NotificationMessageTypes.Success;
        }

        public string Title { get; set; }

        public string Message { get; set; }

        public bool Show { get; set; }

        /// <summary>
        /// type - success, error , info , warning
        /// </summary>
        public string NotificationType { get; set; }

        public NotificationMessageTypes NotificationMessageType { get; set; }

        public string NotificationMessageTypeText//workaround for enum and string duplication
        {
            get
            {
                if (string.IsNullOrEmpty(NotificationType))
                {
                    return NotificationMessageType.ToString();
                }
                else
                {
                    return NotificationType;
                }
            }
        }

    }

    public enum NotificationMessageTypes
    {
        Success,
        Error,
        Info,
        Warning
    }
}

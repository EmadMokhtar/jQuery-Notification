using System;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JqueryNotification
{
    public static class NotificationExtensions
    {
        public static void ShowNotification(this Control control, NotificationType notificationType, string message, TimeSpan timeBeforeHiding)
        {
            var totalNotificationShowingMilliseconds = timeBeforeHiding.TotalMilliseconds;
            var jNotifyDelay = totalNotificationShowingMilliseconds > 0
                                        ? totalNotificationShowingMilliseconds.ToString(CultureInfo.InvariantCulture)
                                        : "undefined"; // equal to not adding anything

            var notificationScript =
                string.Format(
                    "$( function () {{ if(typeof $.jnotify === 'function') {{ $.jnotify('{0}', '{1}', {2}); }} }} );",
                    HttpUtility.JavaScriptStringEncode(message), notificationType.ScriptKey, jNotifyDelay);

            // Allow adding multiple notifications by making the key unique
            var scriptKey = Guid.NewGuid().ToString();

            // Adding the call to the pre-render event of the page, so that multiple notification calls
            //      are added in the same order they are rendered in the page, not the order the calls are processed in page life cycle
            control.PreRender += new EventHandler
                ((sender, e) =>
                 // Note that we need to use ScriptManager to be UpdatePanel friendly
                 // This will still work even if there is no ScriptManager on the page
                 ScriptManager.RegisterStartupScript(control, control.GetType(), scriptKey,
                                                         notificationScript,
                                                         // saves us from adding <script> in string and making it harder to re
                                                         addScriptTags: true));
        }

        public static void ShowNotification(this Control currentControl, NotificationType notificationType, string message)
        {
            ShowNotification(currentControl, notificationType, message, TimeSpan.FromMilliseconds(0));
        }

        public static void ShowSuccessfulNotification(this Control currentControl, string notificationMessage)
        {
            ShowNotification(currentControl, NotificationType.Success, notificationMessage);
        }

        public static void ShowWarningNotification(this Control currentControl, string notificationMessage)
        {
            ShowNotification(currentControl, NotificationType.Warning, notificationMessage);
        }

        public static void ShowErrorNotification(this Control currentControl, string notificationMessage)
        {
            ShowNotification(currentControl, NotificationType.Error, notificationMessage);
        }

        public static void ShowSuccessfulNotification(this Control currentControl, string notificationMessage, int milliseondsBeforeHiding)
        {
            ShowNotification(currentControl, NotificationType.Success, notificationMessage, TimeSpan.FromMilliseconds(milliseondsBeforeHiding));
        }

        public static void ShowWarningNotification(this Control currentControl, string notificationMessage, int milliseondsBeforeHiding)
        {
            ShowNotification(currentControl, NotificationType.Warning, notificationMessage, TimeSpan.FromMilliseconds(milliseondsBeforeHiding));
        }

        public static void ShowErrorNotification(this Control currentControl, string notificationMessage, int milliseondsBeforeHiding)
        {
            ShowNotification(currentControl, NotificationType.Error, notificationMessage, TimeSpan.FromMilliseconds(milliseondsBeforeHiding));
        }
    }
}
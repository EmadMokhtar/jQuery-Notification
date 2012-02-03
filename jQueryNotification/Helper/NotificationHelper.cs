using System.Web.UI;

namespace jQueryNotification.Helper
{
    public static class NotificationHelper
    {
        /// <summary>
        /// Shows the successful notification.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="message">The message.</param>
        public static void ShowSuccessfulNotification(this Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'>  $(document).ready(function () { $.jnotify('" +
                                                    message + "'); });</script>");
        }


        /// <summary>
        /// Shows the warning notification.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="message">The message.</param>
        public static void ShowWarningNotification(this Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'warning'); });</script>");
        }

        /// <summary>
        /// Shows the error notification.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="message">The message.</param>
        public static void ShowErrorNotification(this Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'error'); });</script>");
        }

        /// <summary>
        /// Shows the successful notification.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="message">The message.</param>
        /// <param name="delayTimeSpan">The delay time span in millisecond.</param>
        public static void ShowSuccessfulNotification(this Page page, string message, int delayTimeSpan)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'>  $(document).ready(function () { $.jnotify('" +
                                                    message + "', " + delayTimeSpan + " ); });</script>");
        }

        /// <summary>
        /// Shows the warning notification.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="message">The message.</param>
        /// <param name="delayTimeSpan">The delay time span in millisecond.</param>
        public static void ShowWarningNotification(this Page page, string message, int delayTimeSpan)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'warning', " + delayTimeSpan + " ); });</script>");
        }

        /// <summary>
        /// Shows the error notification.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="message">The message.</param>
        /// <param name="delayTimeSpan">The delay time span in millisecond.</param>
        public static void ShowErrorNotification(this Page page, string message, int delayTimeSpan)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'error', " + delayTimeSpan + " ); });</script>");
        }
    }
}
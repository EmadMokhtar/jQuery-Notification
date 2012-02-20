namespace JqueryNotification
{
    public sealed class NotificationType
    {
        public string ScriptKey { get; private set; }

        private NotificationType(string scriptKey)
        {
            ScriptKey = scriptKey;
        }

        public static NotificationType Success = new NotificationType("");
        public static NotificationType Error = new NotificationType("error");
        public static NotificationType Warning = new NotificationType("warning");
    }
}
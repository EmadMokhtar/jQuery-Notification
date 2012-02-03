using System;
using jQueryNotification.Helper;

namespace jQueryNotification
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSuccess_Click(object sender, EventArgs e)
        {
            this.ShowSuccessfulNotification("Success Notification");
        }

protected void btnWraning_Click(object sender, EventArgs e)
        {
            this.ShowWarningNotification("Warning Notification");
        }

        protected void btnError_Click(object sender, EventArgs e)
        {
            this.ShowErrorNotification("Error Notification");
        }

        protected void btnDelayedSuccess_Click(object sender, EventArgs e)
        {
            this.ShowSuccessfulNotification("Success Notification",5000);
        }

        protected void btnDelayedWarning_Click(object sender, EventArgs e)
        {
            this.ShowWarningNotification("Warning Notification",5000);
        }

        protected void btnDelayedError_Click(object sender, EventArgs e)
        {
            this.ShowErrorNotification("Error Notification", 5000);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JqueryNotification;

namespace jQueryNotification
{
    public partial class SampleUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowUserControlNotification_Click(object sender, EventArgs e)
        {
            // Note using <br /> in the message to show you can use HTML in there
            // Of course if you are using HTML in real cases, avoid creating it by using strings like this

            // Note using 'this' indicating the call belongs to the user control
            this.ShowSuccessfulNotification("Called first, but shown second<br />As I belong to some control on the page");
            // Note using 'Page' indicating the call belongs to the Page itself
            Page.ShowWarningNotification("Called second, but shown first<br />As I belong to the page itself");
        }
    }
}
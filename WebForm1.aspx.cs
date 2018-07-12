using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void Page_Load(object sender, EventArgs e)
        {
            log.Info("Page load started");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            log4net.Config.DOMConfigurator.Configure();
        }
    }
}
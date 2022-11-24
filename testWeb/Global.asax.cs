using System.Web;
using System.Web.Routing;

namespace testWeb
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapPageRoute("AdminLogin",
                                           "adminlogin",
                                           "~/Admin/AdminLogin.aspx");

            RouteTable.Routes.MapPageRoute("AdminPanel",
                                           "adminpanel",
                                           "~/Admin/AdminPanel.aspx");

            

        }
        
    }
}

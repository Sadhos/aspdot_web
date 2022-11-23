using System;
using System.Web.UI;

namespace testWeb.Admin
{
    public partial class AdminLogin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TxtAdminLogin.Text == "Admin" && TxtPassword.Text == "abcd")
            {
                Response.Redirect("~/Admin/AdminPanel.aspx");
            }
            else
            {
                Response.Redirect("~/Admin/AdminLogin.aspx");
            }
        }
    }
}


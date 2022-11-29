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
                clear();
            }
        }
        void clear()
        {
            TxtAdminLogin.Text = "";
            TxtPassword.Text = "";
        }
        
        protected void TxtAdminLogin_TextChanged(object sender, EventArgs e)
        {
            TxtAdminLogin.Text = Server.HtmlEncode(TxtAdminLogin.Text);
        }
        protected void TxtPassword_OnTextChanged(object sender, EventArgs e)
        {
            TxtPassword.Text = Server.HtmlEncode(TxtPassword.Text);
        }
        
    }
}


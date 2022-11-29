using System;
using System.Web.UI;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace testWeb
{
    public partial class Home : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["webAppConnString"].ToString();

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("BlogViewByCount",
                                                                  con);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    if (dtbl.IsInitialized)
                    {
                        FoodLabel.Text = dtbl.Rows[0][0].ToString();
                        SportLabel.Text = dtbl.Rows[0][1].ToString();
                        MovieLabel.Text = dtbl.Rows[0][2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

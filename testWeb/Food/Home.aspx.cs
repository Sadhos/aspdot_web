using System;
using System.Web.UI;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace testWeb.Food
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["webAppConnString"].ToString();

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string sqlQuery = "select * from Blog where BCategory='Food';";

                    MySqlDataAdapter cmd = new MySqlDataAdapter(sqlQuery,
                                                                con);
                    DataTable dtbl = new DataTable();
                    cmd.Fill(dtbl);

                    if (dtbl.IsInitialized)
                    {
                        RepBlogDetails.DataSource = dtbl;
                        RepBlogDetails.DataBind();
                    }
                    else
                    {
                        throw new Exception("Data not init!");
                    }
                }

                lblSuccessMsg.Text = "SUCCESSFUL QUERY!";
            }
            catch (Exception ex)
            {
                lblSuccessMsg.Text = ex.Message;
            }
        }
    }
}

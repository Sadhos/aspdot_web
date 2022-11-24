using System;
using System.Data;
using System.Web;
using System.Web.UI;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace testWeb
{

    public partial class Default : System.Web.UI.Page
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["webAppConnString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string sqlQuery = "select * from Blog order by BPostdate DESC;";

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

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

           
        }
    }
}

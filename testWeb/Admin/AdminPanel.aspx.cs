using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace testWeb.Admin
{
    public partial class AdminPanel : Page
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["webAppConnString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LabBPostdate.Text = DateTime.Now.ToString();
                DDLBCat.Items.Insert(0,"---Select Category---");
            }

        }
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();

                    MySqlCommand sqlCmd = new MySqlCommand("BlogAddOrEdit",
                                                           sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("_BId",
                                                   Convert.ToInt32(hfBID.Value == "" ? "0" : hfBID.Value));

                    sqlCmd.Parameters.AddWithValue("_BTitle",
                                                   TxtBlogTitle.Text);

                    sqlCmd.Parameters.AddWithValue("_BCategory",
                                                   DDLBCat.SelectedItem.Text.ToString());

                    sqlCmd.Parameters.AddWithValue("_BDesc",
                                                   TxtBDesc.Text);

                    sqlCmd.Parameters.AddWithValue("_BUrl",
                                                   Txturl.Text);

              
                    sqlCmd.Parameters.AddWithValue("_BPostdate",
                                                   LabBPostdate.Text.Trim());
                    
                    sqlCmd.ExecuteNonQuery();

                    //Response.Redirect("~/Admin/AdminPanel.aspx");
                    lblSuccessMessage.Text = "Submitted Successfully";
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;




namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection conn= new SqlConnection(ConfigurationManager.ConnectionStrings["FoodOrderingSystemConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
             string query = "Insert into [dbo].[Customer] (username,phone,password) Values (@name,@add,@hellew)";
 
             SqlCommand insertCommand = new SqlCommand(query, conn);
             insertCommand.Parameters.AddWithValue("@name", TextBox3.Text);
             insertCommand.Parameters.AddWithValue("@add", TextBox5.Text);
             insertCommand.Parameters.AddWithValue("@hellew", TextBox1.Text);
             insertCommand.ExecuteNonQuery();
             conn.Close();
        }
    }
}

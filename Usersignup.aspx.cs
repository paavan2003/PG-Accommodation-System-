using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace PG_Project
{
    public partial class Usersignup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string q = "insert into Usertbl (U_Name, Mbl_no, Email, Pwd, Address) values ('" + txtname.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "','" + txtaddress.Text + "')";

            cmd = new SqlCommand(q, con);
           int i = cmd.ExecuteNonQuery();
                  if ( i > 0 )
            {
                //record inserted 
                Response.Write("<script>alert('record inserted successfully'); window.location='UserLogin.aspx'; </script>");
            }
                  else

            {
                // error 
                Response.Write("</script>alert('error');window.loction('Usersignup.aspx'); </script>");
            }

            }   
                
        }
    }


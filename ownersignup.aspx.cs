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
    public partial class ownersignup : System.Web.UI.Page
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
            string q="insert into ownertbl(O_Name,O_Address,Email,Pwd,Mbl_no,City) values ('"+txtname.Text+"','" +txtaddress.Text+"','" +txtemail.Text+"','" +txtpassword.Text+"','"+txtcontact.Text+"','"+txtcity.Text+ "')";

            cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                //record inserted
                Response.Write("<script> alert('record inserted successfully'); window.location='OwnerLogin.aspx';</script>");
            }
            else
            {
                //error
                Response.Write("<script> alert('error'); window.location('usersignup.aspx';</script> ");
            }
        }


        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtaddress.Text = "";
            txtcity.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtpassword.Text = "";
            txtretypepassword.Text = "";
        }
    }
}
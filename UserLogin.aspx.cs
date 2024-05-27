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
    public partial class UserLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            Txtemail.Text="";
            Txtpassword.Text = "";
        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from Usertbl where Email = '" + Txtemail.Text + "' and Pwd ='" + Txtpassword.Text + "'";
            cmd = new SqlCommand(q, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            cmd.ExecuteNonQuery();
            da.Fill(ds, "Usertbl");
            if
                (ds.Tables["Usertbl"].Rows.Count > 0)
            {
                Session["uid"] = ds.Tables["Usertbl"].Rows[0][0].ToString();
                Session["uname"] = ds.Tables["Usertbl"].Rows[0][1].ToString();
                Response.Redirect("User/Dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login Error!!'); window.location='UserLogin.aspx';</script>");
            }

        }
    }
}
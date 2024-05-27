using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PG_Project
{
    public partial class OwnerLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnreset_Click(object sender, EventArgs e)
        {
                
                
            Txtpassword.Text = "";
            Txtemail.Text = "";

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from Ownertbl where Email = '" + Txtemail.Text + "' and Pwd ='" + Txtpassword.Text + "'";
            cmd = new SqlCommand(q, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            cmd.ExecuteNonQuery();
            da.Fill(ds, "Ownertbl");
            if
                (ds.Tables["Ownertbl"].Rows.Count > 0)
            {
                Session["oid"] = ds.Tables["Ownertbl"].Rows[0][0].ToString();
                Session["oname"] = ds.Tables["Ownertbl"].Rows[0][1].ToString();
                Response.Redirect("Owner/Dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login Error!!'); window.location='OwnerLogin.aspx';</script>");
            }


        }
    }
}
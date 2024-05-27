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
    public partial class AdminLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = "";
            TxtEmail.Text = "";

        }


        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from Admintable where Email = '" +  TxtEmail.Text + "' and Pwd ='" + TxtPassword.Text + "'";
            cmd = new SqlCommand(q, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            cmd.ExecuteNonQuery();
            da.Fill(ds, "Admintable");
            if
                (ds.Tables["Admintable"].Rows.Count > 0)
            {
                Session["aid"] = ds.Tables["Admintable"].Rows[0][0];
                Response.Redirect("admin/Dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login Error!!'); window.location='AdminLogin.aspx';</script>");
            }
        }
    }

}


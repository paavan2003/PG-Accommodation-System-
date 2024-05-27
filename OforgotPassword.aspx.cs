using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace PG_Project
{
    public partial class OforgetPassword : System.Web.UI.Page
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
            Txtemail.Text = "";

        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            {

                if (con.State == ConnectionState.Closed)
                    con.Open();
                {
                    String q = "Select * from Ownertbl where Email='" + Txtemail.Text + "'";
                    cmd = new SqlCommand(q, con);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();

                    cmd.ExecuteNonQuery();
                    da.Fill(ds, "Ownertbl");
                    if (ds.Tables["Ownertbl"].Rows.Count > 0)
                    {

                        /* string myemail = "pgh9855@gmail.com";
                         string mypwd = "Saturday1@gmail.com";

                         MailMessage mail = new MailMessage();
                         SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                         string toemail = ds.Tables["Ownertbl"].Rows[0][3].ToString();
                         string Pwd = ds.Tables["Ownertbl"].Rows[0][4].ToString();
                         mail.From = new MailAddress(myemail);
                         mail.To.Add(toemail);
                         mail.Subject = "Your Password recovery email";
                         mail.Body = "Your Login Password is"+ Pwd;

                         SmtpServer.Port = 587;
                         SmtpServer.Credentials = new System.Net.NetworkCredential(myemail, mypwd);
                         SmtpServer.EnableSsl = true;

                         SmtpServer.Send(mail);
                        */




                    }
                }



            }
        }
    }
}
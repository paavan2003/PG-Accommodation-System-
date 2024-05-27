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
    public partial class AforgotPasssword : System.Web.UI.Page
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
                    String q = "select * from Admintable where Email='"+ Txtemail.Text +"'";
                    cmd = new SqlCommand(q, con);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();


                    cmd.ExecuteNonQuery();
                    da.Fill(ds,"Admintable");
                    if (ds.Tables["Admintable"].Rows.Count > 0)

                    {


        
                        /*String myemail = "pgh9855@gmail.com";
                        String mypwd = "Saturday1@gmail.com";

                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        String toemail = ds.Tables["Admintable"].Rows[0][1].ToString();
                        String pwd = ds.Tables["Admintable"].Rows[0][2].ToString();
                        mail.From = new MailAddress(myemail);
                        mail.To.Add(toemail);
                        mail.Subject = "your password recovery email";
                        mail.Body = "Your Login Passsword is " + pwd;
                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(myemail,mypwd);
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                    */




                    }




                }
            }
        
        }
    }
}
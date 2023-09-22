using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_MBANF
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUser"] != null)
            {
                string user = Session["LoginUser"].ToString();
                lbl_welcome.Text = "Bienvennido " + user;
            }
            else
                Response.Redirect("Login.aspx");

        }

        protected void BtnCloseSession_Click(object sender, EventArgs e)
        {
            Session.Remove("LoginUser");
            Response.Redirect("Login.aspx");
        }
    }
}
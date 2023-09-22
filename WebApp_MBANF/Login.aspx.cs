using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_MBANF
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly string pattern = "freakipe";
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            lbl_error.Visible = false;
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_validateUser", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@User", SqlDbType.VarChar, 50).Value = tx_user.Text;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = tx_password.Text;
            cmd.Parameters.Add("@Pattern", SqlDbType.VarChar, 50).Value = pattern;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //Agregar sesion
                Session["LoginUser"] = tx_user.Text;
                Response.Redirect("Principal.aspx");
            }
            else
            {
                lbl_error.Text = "Error de Credenciales";
                lbl_error.Visible = true;
            }
            cmd.Connection.Close();
        }

        protected void BtnRegister_Click(Object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
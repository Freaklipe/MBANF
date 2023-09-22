using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApp_MBANF
{
    public partial class Registro : System.Web.UI.Page
    {
        private readonly string pattern = "freakipe";
        protected void Page_Load(object sender, EventArgs e)
        {
            ClearError();
            ReadData();
        }

        readonly SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString);

        void ClearInput()
        {
            tx_name.Text = string.Empty;
            tx_lastName.Text = string.Empty;
            tx_birthdate.Text = string.Empty;
            tx_user.Text = string.Empty;
            tx_password.Text = string.Empty;
            tx_confirmPassword.Text = string.Empty;

            ClearError();
        }

        void ClearError()
        {
            lbl_error.Text = string.Empty;
            lbl_error.Visible = false;
            lbl_errorPassword.Text = string.Empty;
            lbl_errorPassword.Visible = false;
        }

        void ReadData()
        {
            SqlCommand readDatos = new SqlCommand("Select * from Users", conn);
            SqlDataAdapter reader = new SqlDataAdapter(readDatos);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            gv_usuers.DataSource = dt;
            gv_usuers.DataBind();
        }

        protected void BtnRegister_Click(Object sender, EventArgs e)
        {
            if (tx_name.Text.Length == 0 || tx_lastName.Text.Length == 0 || tx_birthdate.Text.Length == 0 || tx_user.Text.Length == 0 || tx_password.Text.Length == 0 || tx_confirmPassword.Text.Length == 0)
            {
                lbl_error.Text = "Ningun campo puede quedar vacío!";
                lbl_error.Visible = true;

            }
            else
            {
                if (tx_password.Text != tx_confirmPassword.Text)
                {
                    lbl_errorPassword.Text = "Las contrasenias no coinciden!";
                    lbl_errorPassword.Visible = true;
                }
                else
                {
                    conn.Open();
                    // Revisar esta parte, dudas de logica
                    SqlCommand cmd = new SqlCommand("select count(*) from Users where _user='" + tx_user.Text + "'", conn)
                    {
                        CommandType = System.Data.CommandType.Text
                    };
                    //cmd.Parameters.AddWithValue("_user", tx_user.Text); Esto no tiene logica pq el parametro se pasa directo en la query
                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result < 1)
                    {
                        SqlCommand cmm = new SqlCommand("Insert into Users values('" + tx_name.Text + "','" + tx_lastName.Text + "'," +
                            "'" + tx_birthdate.Text + "','" + tx_user.Text + "',(EncryptByPassPhrase('" + pattern + "','" + tx_password.Text + "')))", conn);
                        cmm.ExecuteNonQuery();
                        conn.Close();
                        ClearInput();
                        ReadData();
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        lbl_error.Text = "El Usuario " + tx_user.Text + " ya existe!";
                        lbl_error.Visible = true;
                        tx_user.Text = string.Empty;
                    }
                }
            }
        }

        protected void BtnBack_Click(Object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

    }
}
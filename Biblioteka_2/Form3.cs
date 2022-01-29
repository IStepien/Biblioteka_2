using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteka
{
    public partial class Form3 : Form
    {

        public Form1 form1 = new Form1();
        SqlCommand cmd;       
        String conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\source\\repos\\Biblioteka\\Biblioteka\\database.mdf;Integrated Security=True; MultipleActiveResultSets=True";

        String conString2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\source\\repos\\Biblioteka\\Biblioteka\\database2.mdf;Integrated Security=True; MultipleActiveResultSets=True";


        public Form3()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {            
            btnLogin.Visible = false;
            btnSaveUser.Visible = true;                    

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string newLogin = txtLogin.Text;
            string newPassword = txtPassword.Text;
            if (newLogin.Length > 0 && newPassword.Length>0) 
            {
                saveUser(newLogin, newPassword);
            }
            else
            {
                MessageBox.Show("Pole nie może być puste", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        
        }
               

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

           if(logIn(login, password))
            {
                MessageBox.Show("Zalogowano poprawnie");
                     
                if (checkIfAdmin(login))
                {
                    form1.passingvalue = true;
                }
                else
                {
                    form1.passingvalue = false;
                }
           

                lblLogin.Visible = false;
                lblPassword.Visible = false;
                txtLogin.Visible = false;
                txtPassword.Visible = false;
                lblUserData.Visible = false;
                btnLogin.Visible = false;
                btnAddUser.Visible = false;

                rBLibrary1.Visible = true;
                rBLibrary2.Visible = true;
                lblChooseLibrary.Visible = true;

            }

         }

        private bool logIn(string login, string password)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();


                string query = "Select Password from [User] where Login = @Login";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@Login", login));


                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {                                              
                   while (dataReader.Read())
                    {
                       if(dataReader[0].ToString()== password)
                        {
                            result = true;
                        }
                    }
                    connection.Close();
                }
            }

            return result;
        }
        private void saveUser(string newLogin, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();

                if (!checkIfUserExists(newLogin))
                {

                    
                    string query = "Insert into [User] " + "(Login, Password, IsAdmin)" + "Values (@Login, @Password, @IsAdmin)";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add(new SqlParameter("@Login", newLogin));
                    cmd.Parameters.Add(new SqlParameter("@Password", newPassword));
                    cmd.Parameters.Add(new SqlParameter("@isAdmin", false));
                    cmd.ExecuteNonQuery();


                   
                    btnLogin.Visible = true;
                    btnSaveUser.Visible = false;
                    MessageBox.Show("Uzytkownik dodany");
                }
                else
                {
                    MessageBox.Show("Login zajęty. Podaj inny login", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogin.Clear();
                    txtPassword.Clear();
                }

                connection.Close();

            }

        }
        private bool checkIfUserExists(string username)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();


                string query = "Select Login from [User] where Login = @Login";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@Login", username));



                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        result = true;
                    }
                }


                connection.Close();

            }

            return result;

        }
        private bool checkIfAdmin(string login)
        {

            bool result = false;

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();


                string query = "Select isAdmin from [User] where Login = @Login";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@Login", login));


                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (dataReader[0].ToString() == "1")
                        {
                            result = true;
                        }
                    }
                    connection.Close();
                }
            }

            return result;

        }

        private void rBLibrary1_CheckedChanged(object sender, EventArgs e)
        {
            form1.connString = conString;
            this.Hide();
            form1.Show();
        }

        private void rBLibrary2_CheckedChanged(object sender, EventArgs e)
        {
            form1.connString = conString2;
            this.Hide();
            form1.Show();
        }
    }
}

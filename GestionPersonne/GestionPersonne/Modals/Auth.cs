using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne.Modals
{
    public partial class Auth : Form
    {

        private Classes.Config config;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;
        private Classes.Cryptage cryptage = new Classes.Cryptage();
        public Auth()
        {
            InitializeComponent();
        }

        public String isEmpty()
        {
            if (userName.Text == "")
            {
                return "Completez le champ Utilisateur";
            }
            if (Password.Text == "")
            {
                return "Completez le champ Password";
            }
            return null;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isEmpty() == null)
            {
                config = new Classes.Config();
                sqlcon = config.getSqlConnection();
                try
                {
                    if (config.ServerType == "Sql Server")
                    {
                        sqlcon.Open();
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            String sql = "select * from users where username=@user";
                            SqlDataReader reader;
                            sqlcmd = new SqlCommand(sql, sqlcon);
                            sqlcmd.Parameters.AddWithValue("@user", userName.Text);

                            reader = sqlcmd.ExecuteReader();
                            if (reader.Read())
                            {
                                if (cryptage.VerifyPassword(Password.Text, reader.GetValue(2).ToString()))
                                {
                                    MessageBox.Show("Bienvenu " + userName.Text + "!!", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    Menu menu = new Menu();
                                    menu.Show();
                                    this.Hide();
                                }
                                else if (Password.Text == reader.GetString(2))
                                {
                                    MessageBox.Show("Bienvenu " + userName.Text + "!!", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    Menu menu = new Menu();
                                    menu.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Mot de passe Incorect", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Utilisateur n'existe pas", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sql Connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void afficher_CheckedChanged(object sender, EventArgs e)
        {
            if (afficher.CheckState == CheckState.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}

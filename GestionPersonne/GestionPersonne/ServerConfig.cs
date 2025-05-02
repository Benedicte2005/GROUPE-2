using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne
{
    public partial class ServerConfig : Form
    {
        private readonly string configFilePath = Application.StartupPath + @"\config.ini";
        private Classes.Config config;
        private Classes.Cryptage cryptage;
        public ServerConfig()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;
        }

        public String isEmpty()
        {
            if(serverType.Text == "")
            {
                return "Completez le champ Type Serveur";
            }
            if (ServerName.Text == "")
            {
                return "Completez le champ Nom du Serveur";
            }
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

        private void SaveConnectionInfo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configFilePath))
                {
                    cryptage = new Classes.Cryptage();

                    writer.WriteLine(serverType.Text);
                    writer.WriteLine(ServerName.Text);
                    writer.WriteLine(userName.Text);
                    writer.WriteLine(cryptage.EncryptData(Password.Text));
                }
                MessageBox.Show("Configuration Enregistrer avec Succee", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la configuration : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(isEmpty() == null)
            {
                SaveConnectionInfo();
                this.config = new Classes.Config();
                if (config.ServerType == "Sql Server")
                {
                    this.Hide();
                    SqlConnection sqlcon = config.getSqlConnection();
                    try
                    {
                        sqlcon.Open();
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Connecter avec succee sur Sql Server", "Sql Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Modals.Auth auth = new Modals.Auth();
                            auth.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Sql server Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            sqlcon.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(isEmpty(), "Champ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

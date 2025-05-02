using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonne.UserControls;

namespace GestionPersonne
{
    public partial class Menu : Form
    {
        private Color activeForeColor = Color.FromArgb(0, 192, 192);
        private Color activeBackColor = Color.FromKnownColor(KnownColor.Control);
        private Color defaultForeColor = Color.White;
        private Color defaultBackColor = Color.FromArgb(0, 192, 192);
        private readonly string configFilePath = Application.StartupPath + @"\config.ini";
        public Menu()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btDecon_Click(object sender, EventArgs e)
        {
            ControlerUser.Controls.Remove(Personnes.interfaces);
            ControlerUser.Controls.Remove(Telephones.interfaces);
            ControlerUser.Controls.Remove(Adresses.interfaces);
            ControlerUser.Controls.Remove(Utilisateurs.interfaces);
            this.Close();
            Modals.Auth auth = new Modals.Auth();
            auth.Visible = true;
        }

        private void btPerson_Click(object sender, EventArgs e)
        {
            btPerson.BackColor = activeBackColor;
            btPerson.ForeColor = activeForeColor;
            btPhone.BackColor = defaultBackColor;
            btPhone.ForeColor = defaultForeColor;
            btAdd.BackColor = defaultBackColor;
            btAdd.ForeColor = defaultForeColor;
            btUsers.BackColor = defaultBackColor;
            btUsers.ForeColor = defaultForeColor;
            if (!ControlerUser.Controls.Contains(Personnes.interfaces))
            {
                ControlerUser.Controls.Add(Personnes.interfaces);
                Personnes.interfaces.Dock = DockStyle.Fill;
                Personnes.interfaces.BringToFront();
            }
            else
            {
                Personnes.interfaces.BringToFront();
            }
        }

        private void btPhone_Click(object sender, EventArgs e)
        {
            btPerson.BackColor = defaultBackColor;
            btPerson.ForeColor = defaultForeColor;
            btPhone.BackColor = activeBackColor;
            btPhone.ForeColor = activeForeColor;
            btAdd.BackColor = defaultBackColor;
            btAdd.ForeColor = defaultForeColor;
            btUsers.BackColor = defaultBackColor;
            btUsers.ForeColor = defaultForeColor;
            if (!ControlerUser.Controls.Contains(Telephones.interfaces))
            {
                ControlerUser.Controls.Add(Telephones.interfaces);
                Telephones.interfaces.Dock = DockStyle.Fill;
                Telephones.interfaces.BringToFront();
            }
            else
            {
                Telephones.interfaces.BringToFront();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            btPerson.BackColor = defaultBackColor;
            btPerson.ForeColor = defaultForeColor;
            btPhone.BackColor = defaultBackColor;
            btPhone.ForeColor = defaultForeColor;
            btAdd.BackColor = activeBackColor;
            btAdd.ForeColor = activeForeColor;
            btUsers.BackColor = defaultBackColor;
            btUsers.ForeColor = defaultForeColor;
            if (!ControlerUser.Controls.Contains(Adresses.interfaces))
            {
                ControlerUser.Controls.Add(Adresses.interfaces);
                Adresses.interfaces.Dock = DockStyle.Fill;
                Adresses.interfaces.BringToFront();
            }
            else
            {
                Adresses.interfaces.BringToFront();
            }
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            btPerson.BackColor = defaultBackColor;
            btPerson.ForeColor = defaultForeColor;
            btPhone.BackColor = defaultBackColor;
            btPhone.ForeColor = defaultForeColor;
            btAdd.BackColor = defaultBackColor;
            btAdd.ForeColor = defaultForeColor;
            btUsers.BackColor = activeBackColor;
            btUsers.ForeColor = activeForeColor;
            if (!ControlerUser.Controls.Contains(Utilisateurs.interfaces))
            {
                ControlerUser.Controls.Add(Utilisateurs.interfaces);
                Utilisateurs.interfaces.Dock = DockStyle.Fill;
                Utilisateurs.interfaces.BringToFront();
            }
            else
            {
                Utilisateurs.interfaces.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-Vous Supprimer Cette Configuration??", "Configuration", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                File.Delete(configFilePath);
                ControlerUser.Controls.Remove(Utilisateurs.interfaces);
                ControlerUser.Controls.Remove(Adresses.interfaces);
                ControlerUser.Controls.Remove(Telephones.interfaces);
                ControlerUser.Controls.Remove(Personnes.interfaces);
                MessageBox.Show("Configuration Supprimer Avec Succee??", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ServerConfig server = new ServerConfig();
                server.Show();
            }
            else
            {

                MessageBox.Show("Suppression Annulee??", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

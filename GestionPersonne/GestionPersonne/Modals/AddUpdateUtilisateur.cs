using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne.Modals
{
    public partial class AddUpdateUtilisateur : Form
    {
        private UserControl user;
        public int idU;
        private Classes.Config config;
        private DialogResult Dr;
        public AddUpdateUtilisateur(UserControl user)
        {
            InitializeComponent();
            this.user = user;

            txtPass.UseSystemPasswordChar = false;
            txtConfPass.UseSystemPasswordChar = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String IsEmpty()
        {
            if (txtutilisateur.Text == "" || txtPass.Text == "" || txtConfPass.Text == "")
            {
                return "Completez Tout le Champ";
            }  
            return null;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            config = new Classes.Config();
            if (IsEmpty() == null)
            {
                if (config.ServerType == "Sql Server")
                {
                    if (txtPass.Text == txtConfPass.Text)
                    {
                        if (titre.Text == "Ajouter Utilisateur")
                        {
                            Classes.CRUDUtilisateurs add = new Classes.CRUDUtilisateurs();
                            if (add.AjouterUtilisateur(txtutilisateur.Text, txtPass.Text) == true)
                            {
                                (user as UserControls.Utilisateurs).AfficherUtilisateur("");
                                MessageBox.Show("Utilisateur Ajouter Avec Succee", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Erreur d'Ajout de l'Utilisateur", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            Classes.CRUDUtilisateurs update = new Classes.CRUDUtilisateurs();
                            Dr = MessageBox.Show("Voulez-Vous Modifier cet Utilisateur??", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Dr == DialogResult.Yes)
                            {
                                if (update.ModifierUtilisateur(idU, txtutilisateur.Text, txtPass.Text) == true)
                                {
                                    (user as UserControls.Utilisateurs).AfficherUtilisateur("");
                                    MessageBox.Show("Utilisateur Modifier avec Succee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Erreur de Modification de l'Utilisateur", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Modification Annulee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe ne correspond pas", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show(IsEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void afficher_CheckedChanged(object sender, EventArgs e)
        {
            if(afficher.CheckState == CheckState.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtConfPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtConfPass.UseSystemPasswordChar = true;
            }
        }

        private void AddUpdateUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}

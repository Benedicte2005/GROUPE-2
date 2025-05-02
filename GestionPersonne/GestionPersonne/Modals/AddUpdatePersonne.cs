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
    public partial class AddUpdatePersonne : Form
    {
        private UserControl person;
        private Classes.Config db;
        private SqlConnection con;
        public int idP;
        DialogResult Dr;
        public AddUpdatePersonne(UserControl user)
        {
            InitializeComponent();
            this.person = user;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public String isEmpty()
        {
            if (txtname.Text == "")
            {
                return "Completez le Nom";
            }
            if (txtpost.Text == "")
            {
                return "Completez le Post-Nom";
            }
            if (txtpre.Text == "")
            {
                return "Completez le Prenom";
            }
            if (txtSex.Text == "")
            {
                return "Completez le Sexe";
            }
            return null;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (isEmpty() == null)
            {
                if(titre.Text == "Ajouter Personne")
                {
                    db = new Classes.Config();
                    con = db.getSqlConnection();
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            Classes.CRUDPersonnes sqladd = new Classes.CRUDPersonnes();
                            if (sqladd.AjouterPersonne(txtname.Text, txtpost.Text, txtpre.Text, Convert.ToChar(txtSex.Text)) == true)
                            {
                                (person as UserControls.Personnes).AfficherPersonnes("");
                                MessageBox.Show("Personne Ajouter Avec Succee", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Erreur d'Ajout de la Personne", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    db = new Classes.Config();
                    con = db.getSqlConnection();
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            Classes.CRUDPersonnes sqlupdate = new Classes.CRUDPersonnes();
                            Dr = MessageBox.Show("Voulez-vous Modifier cette Personne??", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Dr == DialogResult.Yes)
                            {
                                if (sqlupdate.ModifierPersonne(idP, txtname.Text, txtpost.Text, txtpre.Text, Convert.ToChar(txtSex.Text)) == true)
                                {
                                    (person as UserControls.Personnes).AfficherPersonnes("");
                                    MessageBox.Show("Personne Modifier Avec Succee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Erreur de Modification de la Personne", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Modification Annule", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void AddUpdatePersonne_Load(object sender, EventArgs e)
        {

        }
    }
}

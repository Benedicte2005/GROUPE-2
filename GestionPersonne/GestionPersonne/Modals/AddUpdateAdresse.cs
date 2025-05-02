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
    public partial class AddUpdateAdresse : Form
    {
        public int idA;
        public int idP;
        private Classes.Config db;
        private SqlConnection con;
        private SqlCommand cmd;
        private DialogResult Dr;
        private UserControl adress;
        public AddUpdateAdresse(UserControl user)
        {
            InitializeComponent();
            this.adress = user;
            RemplirePersonne();
            PopulateCountryData();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCountryData()
        {
            comboCountry.Items.Add("Algérie");
            comboCountry.Items.Add("Angola");
            comboCountry.Items.Add("Bénin");
            comboCountry.Items.Add("Botswana");
            comboCountry.Items.Add("Burkina Faso");
            comboCountry.Items.Add("Burundi");
            comboCountry.Items.Add("Cabo Verde");
            comboCountry.Items.Add("Cameroun");
            comboCountry.Items.Add("République Centrafricaine");
            comboCountry.Items.Add("Tchad");
            comboCountry.Items.Add("Comores");
            comboCountry.Items.Add("République Démocratique du Congo");
            comboCountry.Items.Add("République du Congo");
            comboCountry.Items.Add("Côte d'Ivoire");
            comboCountry.Items.Add("Djibouti");
            comboCountry.Items.Add("Égypte");
            comboCountry.Items.Add("Guinée Équatoriale");
            comboCountry.Items.Add("Érythrée");
            comboCountry.Items.Add("Eswatini");
            comboCountry.Items.Add("Éthiopie");
            comboCountry.Items.Add("Gabon");
            comboCountry.Items.Add("Gambie");
            comboCountry.Items.Add("Ghana");
            comboCountry.Items.Add("Guinée");
            comboCountry.Items.Add("Guinée-Bissau");
            comboCountry.Items.Add("Kenya");
            comboCountry.Items.Add("Lesotho");
            comboCountry.Items.Add("Libéria");
            comboCountry.Items.Add("Libye");
            comboCountry.Items.Add("Madagascar");
            comboCountry.Items.Add("Malawi");
            comboCountry.Items.Add("Mali");
            comboCountry.Items.Add("Mauritanie");
            comboCountry.Items.Add("Maurice");
            comboCountry.Items.Add("Maroc");
            comboCountry.Items.Add("Mozambique");
            comboCountry.Items.Add("Namibie");
            comboCountry.Items.Add("Niger");
            comboCountry.Items.Add("Nigéria");
            comboCountry.Items.Add("Rwanda");
            comboCountry.Items.Add("Sao Tomé-et-Principe");
            comboCountry.Items.Add("Sénégal");
            comboCountry.Items.Add("Seychelles");
            comboCountry.Items.Add("Sierra Leone");
            comboCountry.Items.Add("Somalie");
            comboCountry.Items.Add("Afrique du Sud");
            comboCountry.Items.Add("Soudan du Sud");
            comboCountry.Items.Add("Soudan");
            comboCountry.Items.Add("Tanzanie");
            comboCountry.Items.Add("Togo");
            comboCountry.Items.Add("Tunisie");
            comboCountry.Items.Add("Ouganda");
            comboCountry.Items.Add("Zambie");
            comboCountry.Items.Add("Zimbabwe");
        }
        public void RemplirePersonne()
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String sql = "select idP as id,CONCAT(nom,' ',postnom,' ',prenom) as fullname from personne";
            try
            {
                if (db.ServerType == "Sql Server")
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        cmd = new SqlCommand(sql, con);
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable tablePerson = new DataTable();
                        data.Fill(tablePerson);
                        ListePersonnes.DataSource = tablePerson;
                        ListePersonnes.DisplayMember = "fullname";
                        ListePersonnes.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public String isEmpty()
        {
            if (ListePersonnes.Text == "")
            {
                return "Choisissez Une Personne";
            }
            if (txtAv.Text == "")
            {
                return "Completez l'Avenue";
            }
            if (txtQ.Text == "")
            {
                return "Completez le Quartier";
            }
            if (txtCom.Text == "")
            {
                return "Completez la Commune";
            }
            if (txtVi.Text == "")
            {
                return "Completez la Ville";
            }
            if (comboCountry.Text == "")
            {
                return "Completez le Pays";
            }
            return null;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (isEmpty() == null)
            {
                if(titre.Text == "Ajouter Adresse")
                {
                    Classes.CRUDAdresses add = new Classes.CRUDAdresses();
                    idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                    if (add.AjouterAdresse(idP, txtAv.Text, txtQ.Text, txtCom.Text, txtVi.Text, comboCountry.Text) == true)
                    {
                        (adress as UserControls.Adresses).AfficherAdresses("");
                        MessageBox.Show("Adresse Ajouter Avec Succee", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'Ajout d'Adresse", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                    Classes.CRUDAdresses update = new Classes.CRUDAdresses();
                    Dr = MessageBox.Show("Voulez-vous Modifier Cette Adresse??", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        if (update.ModifierAdresse(idA, idP, txtAv.Text, txtQ.Text, txtCom.Text, txtVi.Text, comboCountry.Text) == true)
                        {
                            (adress as UserControls.Adresses).AfficherAdresses("");
                            MessageBox.Show("Adresse Modifier Avec Succee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de Modification de l'Adresse", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListePersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddUpdateAdresse_Load(object sender, EventArgs e)
        {

        }
    }
}

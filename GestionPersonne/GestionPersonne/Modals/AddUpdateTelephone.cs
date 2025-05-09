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
    public partial class AddUpdateTelephone : Form
    {
        private UserControl phone; public int idT;
        private Classes.Config db;
        private SqlConnection con;
        private SqlCommand cmd;
        private DialogResult Dr;
        private Dictionary<string, string> africanCountries = new Dictionary<string, string>();
        public AddUpdateTelephone(UserControl user)
        {
            InitializeComponent();
            this.phone = user;
            PopulateCountryData();
            InitializeComboBox();
            RemplirePersonne();
        }


        private void PopulateCountryData()
        {
            africanCountries.Add("Algérie", "+213");
            africanCountries.Add("Angola", "+244");
            africanCountries.Add("Bénin", "+229");
            africanCountries.Add("Botswana", "+267");
            africanCountries.Add("Burkina Faso", "+226");
            africanCountries.Add("Burundi", "+257");
            africanCountries.Add("Cabo Verde", "+238");
            africanCountries.Add("Cameroun", "+237");
            africanCountries.Add("République Centrafricaine", "+236");
            africanCountries.Add("Tchad", "+235");
            africanCountries.Add("Comores", "+269");
            africanCountries.Add("République Démocratique du Congo", "+243");
            africanCountries.Add("République du Congo", "+242");
            africanCountries.Add("Côte d'Ivoire", "+225");
            africanCountries.Add("Djibouti", "+253");
            africanCountries.Add("Égypte", "+20");
            africanCountries.Add("Guinée Équatoriale", "+240");
            africanCountries.Add("Érythrée", "+291");
            africanCountries.Add("Eswatini", "+268");
            africanCountries.Add("Éthiopie", "+251");
            africanCountries.Add("Gabon", "+241");
            africanCountries.Add("Gambie", "+220");
            africanCountries.Add("Ghana", "+233");
            africanCountries.Add("Guinée", "+224");
            africanCountries.Add("Guinée-Bissau", "+245");
            africanCountries.Add("Kenya", "+254");
            africanCountries.Add("Lesotho", "+266");
            africanCountries.Add("Libéria", "+231");
            africanCountries.Add("Libye", "+218");
            africanCountries.Add("Madagascar", "+261");
            africanCountries.Add("Malawi", "+265");
            africanCountries.Add("Mali", "+223");
            africanCountries.Add("Mauritanie", "+222");
            africanCountries.Add("Maurice", "+230");
            africanCountries.Add("Maroc", "+212");
            africanCountries.Add("Mozambique", "+258");
            africanCountries.Add("Namibie", "+264");
            africanCountries.Add("Niger", "+227");
            africanCountries.Add("Nigéria", "+234");
            africanCountries.Add("Rwanda", "+250");
            africanCountries.Add("Sao Tomé-et-Principe", "+239");
            africanCountries.Add("Sénégal", "+221");
            africanCountries.Add("Seychelles", "+248");
            africanCountries.Add("Sierra Leone", "+232");
            africanCountries.Add("Somalie", "+252");
            africanCountries.Add("Afrique du Sud", "+27");
            africanCountries.Add("Soudan du Sud", "+211");
            africanCountries.Add("Soudan", "+249");
            africanCountries.Add("Tanzanie", "+255");
            africanCountries.Add("Togo", "+228");
            africanCountries.Add("Tunisie", "+216");
            africanCountries.Add("Ouganda", "+256");
            africanCountries.Add("Zambie", "+260");
            africanCountries.Add("Zimbabwe", "+263");
        }

        private void InitializeComboBox()
        {
            comboCountry.Items.Clear();

            foreach (string countryName in africanCountries.Keys.OrderBy(name => name))
            {
                comboCountry.Items.Add(countryName);
            }

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
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int idP;
        public String isEmpty()
        {

            if (ListePersonnes.Text == "")
            {
                return "Choisisez une Personne";
            }
            if (txtInitial.Text == "")
            {
                return "Selectioner Un Pays";
            }
            if (txtNum.Text == "")
            {
                return "Completez le Numero";
            }
            return null;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (isEmpty() == null)
            {
                if(titre.Text == "Ajouter Telephone")
                {
                    idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                    Classes.CRUDTelephones add = new Classes.CRUDTelephones();
                    if (add.AjouterTel(idP, txtInitial.Text, txtNum.Text) == true)
                    {
                        (phone as UserControls.Telephones).AfficherTelephone("");
                        MessageBox.Show("Numero de Telephone ajoute Avec Succee", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'Ajout du Telephone", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                    Classes.CRUDTelephones update = new Classes.CRUDTelephones();
                    Dr = MessageBox.Show("Voulez-vous Modifier cet Numero de Telephone??", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        if (update.ModifierTel(idT, idP, txtInitial.Text, txtNum.Text) == true)
                        {
                            (phone as UserControls.Telephones).AfficherTelephone("");
                            MessageBox.Show("Numero de Telephone Modifier Avec Succee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erreur de Modification du Telephone", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboCountry.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCountry))
            {
                if (africanCountries.TryGetValue(selectedCountry, out string comboCountry)
                {
                    txtInitial.Text = selectedCountry;
                }
                else
                {
                    comboCountry.Text = "Selectioner Un Pays";
                }
            }
            else
            {
                comboCountry.Text = "Selectioner Un Pays";
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AddUpdateTelephone_Load(object sender, EventArgs e)
        {

        }
    }
}

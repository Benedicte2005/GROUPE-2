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

namespace GestionPersonne.UserControls
{
    public partial class Telephones : UserControl
    {

        public int idT;
        private Classes.Config db;
        private SqlConnection con;
        private SqlCommand cmd;
        private DialogResult Dr;
        private static Telephones telephone;
        public static Telephones interfaces
        {
            get
            {
                if(telephone == null)
                {
                    telephone = new Telephones();
                }
                return telephone;
            }
        }
        public Telephones()
        {
            InitializeComponent();
        }

        public void AfficherTelephone(String text)
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String proc = "SearchPhone";
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        tablePhone.Rows.Clear();
                        cmd = new SqlCommand(proc, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@initial", SqlDbType.VarChar, 4)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 9)).Value = text;
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePhone.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                                num++;
                            }
                            catch (Exception sqlEx)
                            {
                                MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        dataReader.Close();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void Telephones_Load(object sender, EventArgs e)
        {
            AfficherTelephone("");
        }

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Modals.AddUpdateTelephone add = new Modals.AddUpdateTelephone(this);
            add.ShowDialog();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (tablePhone.Rows.Count > 0)
            {
                Modals.AddUpdateTelephone update = new Modals.AddUpdateTelephone(this);
                update.titre.Text = "Modifier Telephone";
                update.btSave.Text = "Modifier";
                update.idT = Convert.ToInt32(tablePhone.CurrentRow.Cells[1].Value);
                update.ListePersonnes.Text = tablePhone.CurrentRow.Cells[3].Value.ToString();
                update.txtInitial.Text = tablePhone.CurrentRow.Cells[4].Value.ToString();
                update.txtNum.Text = tablePhone.CurrentRow.Cells[5].Value.ToString();
                update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if(tablePhone.Rows.Count > 0)
            {
                Classes.CRUDTelephones delete = new Classes.CRUDTelephones();
                idT = Convert.ToInt32(tablePhone.CurrentRow.Cells[1].Value);
                Dr = MessageBox.Show("Voulez-vous Supprimer cet Numero de Telephone??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    delete.SupprimerTel(idT);
                    AfficherTelephone("");
                    MessageBox.Show("Numero de Telephone Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Suppression Annulee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tablePhone_Click(object sender, EventArgs e)
        {
            

        }

        private void ListePersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfficherTelephone("");
        }
    }
}

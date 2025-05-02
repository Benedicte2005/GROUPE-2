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
    public partial class Personnes : UserControl
    {
        private Classes.Config db;
        private static Personnes personnes;
        private SqlConnection con;
        private SqlCommand cmd;
        private int idP;
        DialogResult Dr;
        public static Personnes interfaces
        {
            get
            {
                if(personnes == null)
                {
                    personnes = new Personnes();
                }
                return personnes;
            }
        }
        public Personnes()
        {
            InitializeComponent();
        }

        private void Personnes_Load(object sender, EventArgs e)
        {
            AfficherPersonnes("");
        }

        public void AfficherPersonnes(String text)
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String proc = "SearchPerson";
            try
            {
                if(db.ServerType == "Sql Server")
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        tablePerson.Rows.Clear();
                        cmd = new SqlCommand(proc, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePerson.Rows.Add(num, dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Modals.AddUpdatePersonne add = new Modals.AddUpdatePersonne(this);
            add.ShowDialog();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                Modals.AddUpdatePersonne update = new Modals.AddUpdatePersonne(this);
                update.idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                update.txtname.Text = tablePerson.CurrentRow.Cells[2].Value.ToString();
                update.txtpost.Text = tablePerson.CurrentRow.Cells[3].Value.ToString();
                update.txtpre.Text = tablePerson.CurrentRow.Cells[4].Value.ToString();
                update.txtSex.Text = tablePerson.CurrentRow.Cells[5].Value.ToString();
                update.titre.Text = "Modifier Personne";
                update.btSave.Text = "Modifier";
                update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                Classes.CRUDPersonnes sqlSupprimer = new Classes.CRUDPersonnes();
                int numtel = sqlSupprimer.selectPhoneByIdsql(idP);
                int numaddres = sqlSupprimer.selectAddressByIdsql(idP);
                if (numtel > 0 && numaddres == 0)
                {
                    Dr = MessageBox.Show("Cette Personne a " + numtel + " Numero de telephone.\nVoulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne et numero Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (numtel == 0 && numaddres > 0)
                {
                    Dr = MessageBox.Show("Cette Personne a " + numaddres + " Adresse.\nVoulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne et Adresse Supprimer avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (numtel > 0 && numaddres > 0)
                {
                    Dr = MessageBox.Show("Cette Personne a " + numaddres + " Adresse(s) et " + numtel + " Numero(s) de telephone(s).\nVoulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne,numero et Adresse Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    Dr = MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tablePerson_Click(object sender, EventArgs e)
        {
            
        }
    }
}

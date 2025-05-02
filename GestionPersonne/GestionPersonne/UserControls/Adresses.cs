using Microsoft.Reporting.WinForms;
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
    public partial class Adresses : UserControl
    {
        public int idA;
        public int idP;
        private Classes.Config db;
        private SqlConnection con;
        private SqlCommand cmd;
        private DialogResult Dr;
        private static Adresses adresse;
        public static Adresses interfaces
        {
            get
            {
                if(adresse == null)
                {
                    adresse = new Adresses();
                }
                return adresse;
            }
        }
        public Adresses()
        {
            InitializeComponent();
        }

        public void AfficherAdresses(String text)
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String proc = "SearchAddress";
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        tableAddress.Rows.Clear();
                        cmd = new SqlCommand(proc, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tableAddress.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(6), dataReader.GetString(5), dataReader.GetString(7));
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


        private void Adresses_Load(object sender, EventArgs e)
        {
            AfficherAdresses("");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Modals.AddUpdateAdresse add = new Modals.AddUpdateAdresse(this);
            add.ShowDialog();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (tableAddress.Rows.Count > 0)
            {
                Modals.AddUpdateAdresse update = new Modals.AddUpdateAdresse(this);
                update.titre.Text = "Modifier Adresse";
                update.btSave.Text = "Modifier";
                update.idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                update.ListePersonnes.Text = tableAddress.CurrentRow.Cells[3].Value.ToString();
                update.txtAv.Text = tableAddress.CurrentRow.Cells[4].Value.ToString();
                update.txtQ.Text = tableAddress.CurrentRow.Cells[5].Value.ToString();
                update.txtCom.Text = tableAddress.CurrentRow.Cells[6].Value.ToString();
                update.txtVi.Text = tableAddress.CurrentRow.Cells[7].Value.ToString();
                update.comboCountry.Text = tableAddress.CurrentRow.Cells[8].Value.ToString();
                update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if(tableAddress.Rows.Count > 0)
            {
                Classes.CRUDAdresses delete = new Classes.CRUDAdresses();
                idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                Dr = MessageBox.Show("Voulez-vous Supprimer Cette Adresse??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    delete.SupprimerAdresse(idA);
                    AfficherAdresses("");
                    MessageBox.Show("Adresse Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Suppresion Annulee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tableAddress_Click(object sender, EventArgs e)
        {

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            Modals.PreviewRapport printer = new Modals.PreviewRapport();
            db = new Classes.Config();
            con = db.getSqlConnection();
            if (tableAddress.Rows.Count > 0)
            {
                try
                {
                    if (db.ServerType == "Sql Server")
                    {
                        con.Open();
                        try
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                String sql = "select * from listPersonWithNumberAndAddress";

                                cmd = new SqlCommand(sql, con);
                                SqlDataAdapter data = new SqlDataAdapter(cmd);
                                DataTable tablePersonWithAddr = new DataTable();
                                data.Fill(tablePersonWithAddr);
                                var listPersonneWithAddr = tablePersonWithAddr;

                                printer.preview.LocalReport.ReportEmbeddedResource = "GestionPersonne.Rapports.ListePersonnes.rdlc";
                                printer.preview.LocalReport.DataSources.Add(new ReportDataSource("listePersonnesNumAdresse", listPersonneWithAddr));
                                printer.preview.RefreshReport();
                                printer.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfficherAdresses("");
        }
    }
}

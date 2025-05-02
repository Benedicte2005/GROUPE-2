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
    public partial class Utilisateurs : UserControl
    {
        private Classes.Config db;
        private SqlConnection con;
        private SqlCommand cmd;
        public int idU;
        private Classes.Cryptage cryptage;
        private DialogResult Dr;
        private static Utilisateurs user;
        public static Utilisateurs interfaces
        {
            get
            {
                if(user == null)
                {
                    user = new Utilisateurs();
                }
                return user;
            }
        }
        public Utilisateurs()
        {
            InitializeComponent();
        }

        public void AfficherUtilisateur(String text)
        {
            try
            {
                db = new Classes.Config();
                con = db.getSqlConnection();
                String proc = "SearchUser";
                if (db.ServerType == "Sql Server")
                {
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            tableUser.Rows.Clear();
                            cmd = new SqlCommand(proc, con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 250)).Value = text;
                            SqlDataReader dataReader = cmd.ExecuteReader();
                            int num = 1;
                            while (dataReader.Read())
                            {
                                try
                                {
                                    tableUser.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2));
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (tableUser.Rows.Count > 0)
            {
                cryptage = new Classes.Cryptage();
                Modals.AddUpdateUtilisateur updateModal = new Modals.AddUpdateUtilisateur(this);
                updateModal.idU = Convert.ToInt32(tableUser.CurrentRow.Cells[1].Value);
                updateModal.txtutilisateur.Text = tableUser.CurrentRow.Cells[2].Value.ToString();
                updateModal.txtPass.Text = cryptage.DecryptData(tableUser.CurrentRow.Cells[3].Value.ToString());
                updateModal.txtPass.UseSystemPasswordChar = false;

                updateModal.titre.Text = "Modifier Utilisateur";
                updateModal.btSave.Text = "Modifier";
                updateModal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if (tableUser.Rows.Count > 0)
            {
                if (tableUser.Rows.Count == 1)
                {
                    MessageBox.Show("Vous ne Pouvez pas supprimer Tout les Utilisateurs", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Classes.CRUDUtilisateurs delete = new Classes.CRUDUtilisateurs();
                    idU = Convert.ToInt32(tableUser.CurrentRow.Cells[1].Value);
                    Dr = MessageBox.Show("Voulez-vous Supprimer Cet Utilisateur??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        delete.SupprimerUtilisateur(idU);
                        AfficherUtilisateur("");
                        MessageBox.Show("Utilisateur Supprimer Avec Succe", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annulee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            AfficherUtilisateur("");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Modals.AddUpdateUtilisateur add = new Modals.AddUpdateUtilisateur(this);
            add.ShowDialog();
        }
    }
}

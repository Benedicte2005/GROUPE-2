using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne.Classes
{
    class CRUDTelephones
    {
        private Config db;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;

        public bool AjouterTel(int idP, String initial, String num)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "AddPhone";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                    sqlcmd.Parameters.Add(new SqlParameter("@initial", SqlDbType.VarChar, 4)).Value = initial;
                    sqlcmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 9)).Value = num;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }

        public bool ModifierTel(int id, int idP, String initial, String num)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "UpdatePhone";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@idT", SqlDbType.BigInt)).Value = id;
                    sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                    sqlcmd.Parameters.Add(new SqlParameter("@initial", SqlDbType.VarChar, 4)).Value = initial;
                    sqlcmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 9)).Value = num;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }

        public bool SupprimerTel(int id)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "DeletePhone";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@idT", SqlDbType.BigInt)).Value = id;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }
    }
}

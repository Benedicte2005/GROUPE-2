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
    class CRUDPersonnes
    {
        private Config db;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;
        public bool AjouterPersonne(String name, String lastname, String firstname, char sex)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String sql = "AddPerson";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = name;
                    sqlcmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = lastname;
                    sqlcmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = firstname;
                    sqlcmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.Char, 1)).Value = sex;

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

        public bool ModifierPersonne(int id, String name, String lastname, String firstname, char sex)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String sql = "UpdatePerson";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.BigInt)).Value = id;
                    sqlcmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = name;
                    sqlcmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = lastname;
                    sqlcmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = firstname;
                    sqlcmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.Char, 1)).Value = sex;

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

        public bool SupprimerPersonne(int id)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String sql = "DeletePerson";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.BigInt)).Value = id;

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
        public int selectPhoneByIdsql(int idP)
        {
            int totPhone = 0;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String sql = "select COUNT(idP) from telephone where idP=@idP";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.Parameters.AddWithValue("@idP", idP);
                    totPhone = (int)sqlcmd.ExecuteScalar();

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        return totPhone;
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
            return totPhone;
        }
        public int selectAddressByIdsql(int idP)
        {
            int totaddress = 0;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String sql = "select COUNT(idP) from adresse where idP=@idP";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.Parameters.AddWithValue("@idP", idP);
                    totaddress = (int)sqlcmd.ExecuteScalar();

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        return totaddress;
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
            return totaddress;
        }
    }
}

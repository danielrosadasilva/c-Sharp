using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace academia
{
    internal class Banco
    {
        private static SQLiteConnection connection;

        //  Funções Genericas
        private static SQLiteConnection conexaoBanco()
        {
            connection = new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
            connection.Open();
            return connection;
        }
        public static DataTable dql(string sql)     //data query language (select)
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            var vcon = conexaoBanco();
            try
            {
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    ad = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    ad.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                vcon.Close();
                throw e;
            }
        }

        public static void dml(string q, string msgOk = null, string msgERRO = null)  //Data Manipulation Language (insert,delete,update)
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            var vcon = conexaoBanco();
            try
            {
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = q;
                    ad = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    if (msgOk != null)
                    {
                        MessageBox.Show(msgOk);
                    }
                }
            }
            catch (Exception e)
            {
                vcon.Close();
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + e.Message);
                }
                throw e;
            }
        }
    }
}

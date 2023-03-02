using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;

namespace academia
{
    internal class Banco
    {
        private static SQLiteConnection connection;
        private static SQLiteConnection conexaoBanco()
        {
            connection = new SQLiteConnection("Data Source=C:\\Users\\danie\\source\\repos\\academia\\academia\\banco\\bd_academia.db");
            connection.Open();
            return connection;  
        }
        public static DataTable obterTodosUsuarios()
        {
            SQLiteDataAdapter ad = null;
            DataTable dt=new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    ad=new SQLiteDataAdapter(cmd.CommandText,conexaoBanco());
                    ad.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                conexaoBanco().Close();
                throw e;
            }
            
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    ad = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    ad.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                conexaoBanco().Close();
                throw e;
            }
        }
    }
}

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
        //// Cadastro Usuario\\\\\
        public static void novoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já Existe");
                return;
            }
            else
            {

                try
                {

                    var cmd = conexaoBanco().CreateCommand();
                    cmd.CommandText = "INSERT INTO tb_usuarios(T_NOMEUSUARIO,T_USERNAME,T_PASSWORD,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES(@nome,@username,@password,@status,@nivel)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@password", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Usuario Inserido com Sucesso!");
                    conexaoBanco().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro");
                    conexaoBanco().Close();
                }
            }
        }

        ////Rotinas Gerais\\\\
        public static bool existeUsername(Usuario u)
        {
            
            bool res;
            SQLiteDataAdapter ad = null;
            DataTable dt=new DataTable();
            var cmd=conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.username+"'";
            ad = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
            ad.Fill(dt);
         
            if (dt.Rows.Count > 0)      
            {
                res = true;              
            }
            else
            {
                res = false;                
            }

            return res;
        }
    }
}

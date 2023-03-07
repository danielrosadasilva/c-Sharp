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
            var vcon = conexaoBanco();
            try
            {   
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    ad=new SQLiteDataAdapter(cmd.CommandText,vcon);
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
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            var vcon =conexaoBanco();
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
                var vcon=conexaoBanco();
                try
                {

                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "INSERT INTO tb_usuarios(T_NOMEUSUARIO,T_USERNAME,T_PASSWORD,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES(@nome,@username,@password,@status,@nivel)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@password", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Usuario Inserido com Sucesso!");
                    vcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro");
                    vcon.Close();
                }
            }
        }
        //Gestao usuarios\\\
        public static DataTable obterUsuariosIdNome()
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            var vcon = conexaoBanco();
            try
            {
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuario' ,T_NOMEUSUARIO as 'Nome Usuario' FROM tb_usuarios";
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
        public static DataTable obterDadosUsuario(string id)
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            var vcon = conexaoBanco();
            try
            {
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO='"+id+"'";
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
        ////Rotinas Gerais\\\\
        public static bool existeUsername(Usuario u)
        {
            var vcon = conexaoBanco();
            bool res;
            SQLiteDataAdapter ad = null;
            DataTable dt=new DataTable();
            var cmd=vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.username+"'";
            ad = new SQLiteDataAdapter(cmd.CommandText, vcon);
            ad.Fill(dt);
         
            if (dt.Rows.Count > 0)      
            {
                res = true;              
            }
            else
            {
                res = false;                
            }
            vcon.Close();
            return res;
        }
    }
}

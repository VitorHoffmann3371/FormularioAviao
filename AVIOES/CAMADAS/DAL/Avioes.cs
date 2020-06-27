using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.DAL
{
    public class Avioes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Avioes> Select()
        {
            List<MODEL.Avioes> lstAvioes = new List<MODEL.Avioes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avioes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Avioes aviao = new MODEL.Avioes();
                    aviao.id = Convert.ToInt32(dados["id"].ToString());
                    aviao.modelo = dados["modelo"].ToString();
                    aviao.fabricante = dados["fabricante"].ToString();
                    aviao.ano = Convert.ToInt32(dados["ano"].ToString());
                    aviao.cor = dados["cor"].ToString();
                    lstAvioes.Add(aviao);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar Banco sql-Avioes");
            }
            finally
            {
                conexao.Close();
            }

            return lstAvioes;
        }

        public List<MODEL.Avioes> SelectByID(int id)
        {
            List<MODEL.Avioes> lstAvioes = new List<MODEL.Avioes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avioes WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Avioes aviao = new MODEL.Avioes();
                    aviao.id = Convert.ToInt32(dados["id"].ToString());
                    aviao.modelo = dados["modelo"].ToString();
                    aviao.fabricante = dados["fabricante"].ToString();
                    aviao.ano = Convert.ToInt32(dados["ano"].ToString());
                    aviao.cor = dados["cor"].ToString();
                    lstAvioes.Add(aviao);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar Banco sql-Avioes");
            }
            finally
            {
                conexao.Close();
            }

            return lstAvioes;
        }

        public List<MODEL.Avioes> SelectByModelo(string modelo)
        {
            List<MODEL.Avioes> lstAvioes = new List<MODEL.Avioes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avioes WHERE (modelo LIKE @modelo)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@modelo", "%" + modelo + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Avioes aviao = new MODEL.Avioes();
                    aviao.id = Convert.ToInt32(dados["id"].ToString());
                    aviao.modelo = dados["modelo"].ToString();
                    aviao.fabricante = dados["fabricante"].ToString();
                    aviao.ano = Convert.ToInt32(dados["ano"].ToString());
                    aviao.cor = dados["cor"].ToString();
                    lstAvioes.Add(aviao);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar Banco sql-Avioes");
            }
            finally
            {
                conexao.Close();
            }

            return lstAvioes;
        }

        public MODEL.Avioes SelectByModeloNew(string modelo)
        {
            MODEL.Avioes aviao = new MODEL.Avioes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Avioes WHERE modelo=@modelo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    aviao.id = Convert.ToInt32(dados["id"].ToString());
                    aviao.modelo = dados["modelo"].ToString();
                    aviao.fabricante = dados["fabricante"].ToString();
                    aviao.ano = Convert.ToInt32(dados["ano"].ToString());
                    aviao.cor = dados["cor"].ToString();                    
                }

            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando Select de clientes por modelo");
            }
            finally
            {

                conexao.Close();
            }

            return aviao;
        }
        public void Insert(MODEL.Avioes aviao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Avioes VALUES(@modelo, @fabricante, @ano, @cor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@modelo", aviao.modelo);
            cmd.Parameters.AddWithValue("@fabricante", aviao.fabricante);
            cmd.Parameters.AddWithValue("@ano", aviao.ano);
            cmd.Parameters.AddWithValue("@cor", aviao.cor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Avioes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Avioes aviao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Avioes SET modelo=@modelo, fabricante=@fabricante, ano=@ano, cor=@cor WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aviao.id);
            cmd.Parameters.AddWithValue("@modelo", aviao.modelo);
            cmd.Parameters.AddWithValue("@fabricante", aviao.fabricante);
            cmd.Parameters.AddWithValue("@ano", aviao.ano);
            cmd.Parameters.AddWithValue("@cor", aviao.cor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Avioes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idAviao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Avioes WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAviao);            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql remover Avioes");
            }
            finally
            {
                conexao.Close();
            }
        }
        
    }
}

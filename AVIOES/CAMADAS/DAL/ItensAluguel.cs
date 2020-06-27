using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVIOES.CAMADAS.DAL
{
    public class ItensAluguel
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.ItensAluguel> Select()
        {
            List<MODEL.ItensAluguel> lstItensAluguel = new List<MODEL.ItensAluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Itens_Aluguel";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.ItensAluguel ItensAluguel = new MODEL.ItensAluguel();
                    ItensAluguel.id = Convert.ToInt32(dados["id"].ToString());
                    ItensAluguel.aluguelID = Convert.ToInt32(dados["aluguelID"].ToString());
                    ItensAluguel.aviaoID = Convert.ToInt32(dados["aviaoID"].ToString());
                    ItensAluguel.validade = Convert.ToDateTime(dados["validade"].ToString());

                    //recuperar aviao
                    CAMADAS.BLL.Avioes bllAvi = new BLL.Avioes();
                    CAMADAS.MODEL.Avioes aviao = bllAvi.SelectByModeloNew(ItensAluguel.modelo);
                    ItensAluguel.modelo = aviao.modelo;

                    lstItensAluguel.Add(ItensAluguel);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar Itens do Aluguel");
            }
            finally
            {
                conexao.Close();
            }

            return lstItensAluguel;
        }

        public List<MODEL.ItensAluguel> SelectByAlug(int idAlug)
        {
            List<MODEL.ItensAluguel> lstItensAluguel = new List<MODEL.ItensAluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Itens_Aluguel WHERE aluguelID=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAlug);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.ItensAluguel ItensAluguel = new MODEL.ItensAluguel();
                    ItensAluguel.id = Convert.ToInt32(dados["id"].ToString());
                    ItensAluguel.aluguelID = Convert.ToInt32(dados["aluguelID"].ToString());
                    ItensAluguel.aviaoID = Convert.ToInt32(dados["aviaoID"].ToString());
                    ItensAluguel.validade = Convert.ToDateTime(dados["validade"].ToString());

                    //recuperar aviao
                    CAMADAS.BLL.Avioes bllAvi = new BLL.Avioes();
                    CAMADAS.MODEL.Avioes aviao = bllAvi.SelectByModelo(ItensAluguel.modelo)[0];
                    ItensAluguel.modelo = aviao.modelo;

                    lstItensAluguel.Add(ItensAluguel);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar Itens do Aluguel");
            }
            finally
            {
                conexao.Close();
            }

            return lstItensAluguel;
        }
        public void Insert(MODEL.ItensAluguel ItensAluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Itens_Aluguel VALUES(@aluguelID, @aviaoID, @validade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@aluguelID", ItensAluguel.aluguelID);
            cmd.Parameters.AddWithValue("@aviaoID", ItensAluguel.aviaoID);
            cmd.Parameters.AddWithValue("@validade", ItensAluguel.validade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir novo Item de Aluguel");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.ItensAluguel ItensAluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Itens_Aluguel SET aluguelID=@aluguelID, aviaoID=@aviaoID, validade=@validade WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", ItensAluguel.id);
            cmd.Parameters.AddWithValue("@aluguelID", ItensAluguel.aluguelID);
            cmd.Parameters.AddWithValue("@aviaoID", ItensAluguel.aviaoID);
            cmd.Parameters.AddWithValue("@validade", ItensAluguel.validade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Itens do Aluguel");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idItensAluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Itens_Aluguel WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idItensAluguel);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql remover Item do Aluguel");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

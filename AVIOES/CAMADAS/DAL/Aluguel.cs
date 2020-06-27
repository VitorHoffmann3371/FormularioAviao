using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.DAL
{
    public class Aluguel
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Aluguel> Select()
        {
            List<MODEL.Aluguel> lstAluguel = new List<MODEL.Aluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluguel";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Aluguel aluguel = new MODEL.Aluguel();
                    aluguel.id = Convert.ToInt32(dados["id"].ToString());
                    aluguel.clienteID = Convert.ToInt32(dados["clienteID"].ToString());
                    aluguel.data = Convert.ToDateTime(dados["data"].ToString());


                    //recuperar cliente
                    CAMADAS.BLL.Clientes bllCli = new BLL.Clientes();
                    CAMADAS.MODEL.Clientes cliente = bllCli.SelectByID(aluguel.clienteID);
                    aluguel.nome = cliente.nome;
                    lstAluguel.Add(aluguel);
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

            return lstAluguel;
        }
        public void Insert(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Aluguel VALUES(@clienteID, @data);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@clienteID", aluguel.clienteID);
            cmd.Parameters.AddWithValue("@data", aluguel.data);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir novo Aluguel");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Aluguel SET clienteID=@clienteID, data=@data WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aluguel.id);
            cmd.Parameters.AddWithValue("@clienteID", aluguel.clienteID);
            cmd.Parameters.AddWithValue("@data", aluguel.data);            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Aluguel");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idAluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Aluguel WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAluguel);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql remover Aluguel");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

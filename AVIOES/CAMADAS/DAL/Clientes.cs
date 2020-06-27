using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIOES.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = Convert.ToInt32(dados["cpf"].ToString());
                    cliente.rg = Convert.ToInt32(dados["rg"].ToString());
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.uf = dados["uf"].ToString();
                    cliente.telefone = Convert.ToInt32(dados["telefone"].ToString());
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando Select de clientes");
            }
            finally
            {

                conexao.Close();
            }

            return lstClientes;
        }

        public MODEL.Clientes SelectByID(int id)
        {
            MODEL.Clientes cliente = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = Convert.ToInt32(dados["cpf"].ToString());
                    cliente.rg = Convert.ToInt32(dados["rg"].ToString());
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.uf = dados["uf"].ToString();
                    cliente.telefone = Convert.ToInt32(dados["telefone"].ToString());
                }

            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando Select de clientes por id");
            }
            finally
            {

                conexao.Close();
            }

            return cliente;
        }

        public List<MODEL.Clientes> SelectByNome(string nome)
        {
            List<MODEL.Clientes> lstCliente = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes WHERE (nome LIKE @nome)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = Convert.ToInt32(dados["cpf"].ToString());
                    cliente.rg = Convert.ToInt32(dados["rg"].ToString());
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.uf = dados["uf"].ToString();
                    cliente.telefone = Convert.ToInt32(dados["telefone"].ToString());
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando Select de clientes por nome");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }

        public List<MODEL.Clientes> SelectByIDNew(int id)
        {
            List<MODEL.Clientes> lstCliente = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = Convert.ToInt32(dados["cpf"].ToString());
                    cliente.rg = Convert.ToInt32(dados["rg"].ToString());
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.uf = dados["uf"].ToString();
                    cliente.telefone = Convert.ToInt32(dados["telefone"].ToString());
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando Select de clientes por nome");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }
        public void Insert(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values (@nome, @cpf, @rg, @cidade, @endereco, @uf, @telefone);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@uf", cliente.uf);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Inserção de Clientes");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Clientes SET nome=@nome, cpf=@cpf, rg=@rg, cidade=@cidade, endereco=@endereco, uf=@uf, telefone=@telefone WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@uf", cliente.uf);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Atualização de Clientes");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE Clientes WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Remoção de Clientes");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}

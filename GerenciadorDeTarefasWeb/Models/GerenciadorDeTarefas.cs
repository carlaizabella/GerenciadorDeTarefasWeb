using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefasWeb.Models
{
	public class GerenciadorDeTarefas
	{
		private string connectionString;
		public GerenciadorDeTarefas(string conexaoComBanco)
		{
			this.connectionString = conexaoComBanco;
		}


		string titulo;
		string descricao;
		string statusDaTarefa; //["A Fazer", "Em Andamento", "Concluído"] ; // A Fazer, Em Andamento, Concluído
		string prioridadeDaTarefa; // = ["Baixa", "Média", "Alta", "Urgente"]; // Baixa, Média, Alta e Urgente



		public void AdicionarTarefas(string titulo, string descricao, string statusDaTarefa, string prioridadeDaTarefa)
		{
			using (SqlConnection conexao = new SqlConnection(connectionString))
			{
				conexao.Open();

				string comandoSql = "INSERT INTO Tarefas(Titulo, Descricao, StatusTarefa, Prioridade, DataCriacao, DataConclusao) VALUES (@Titulo, @Descricao, @StatusTarefa, @Prioridade, @DataCriacao, @DataConclusao)";
				//linha de comando; segunda é conexão
				using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
				{
					comando.Parameters.AddWithValue("@Titulo", titulo);
					comando.Parameters.AddWithValue("@Descricao", descricao);
					comando.Parameters.AddWithValue("@StatusTarefa", statusDaTarefa);
					comando.Parameters.AddWithValue("@Prioridade", prioridadeDaTarefa);
					comando.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
					comando.Parameters.AddWithValue("@DataConclusao", DateTime.Now.AddDays(15));
					comando.ExecuteNonQuery(); //consultar sem retorno
					Console.WriteLine("Tarefa adicionada com sucesso! CONGRATULATIONNN....");
				}
			}
		}

		public void ListarTarefas()
		{
			using (SqlConnection conexao = new SqlConnection(connectionString))
			{
				conexao.Open();

				string comandoSql = "SELECT * FROM Tarefas";
				//linha de comando; segunda é conexão
				using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
				{
					using (SqlDataReader dadosRetornados = comando.ExecuteReader())
					{
						while (dadosRetornados.Read())
						{
							Console.WriteLine($"|ID: {dadosRetornados["Id"]}, Título: {dadosRetornados["Titulo"]}, Descrição: {dadosRetornados["Descricao"]} |");
						}
					}
				}
			}
		}

		public void RemoverTarefa(int Id)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(connectionString))
				{
					conexao.Open();

					string comandoSql = "DELETE FROM Tarefas WHERE Id = @Id";
					//linha de comando; segunda é conexão

					using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
					{
						comando.Parameters.AddWithValue("@Id", Id);
						comando.ExecuteNonQuery(); //consultar sem retorno
						Console.WriteLine("Tarefa Excluída com SUCESSUUUUUU!");
					}
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Não foi possível excluir!");

			}
		}

		public void AtualizarInformacaoDaTarefa(int Id, string titulo, string descricao, string statusDaTarefa, string prioridadeDaTarefa)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(connectionString))
				{
					conexao.Open();

					string comandoSql = "UPDATE Tarefas SET Titulo = @Titulo, Descricao = @Descricao, StatusTarefa = @StatusTarefa, Prioridade = @Prioridade WHERE Id = @Id";
					//linha de comando; segunda é conexão

					using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
					{
						comando.Parameters.AddWithValue("@Id", Id);
						comando.Parameters.AddWithValue("@Titulo", titulo);
						comando.Parameters.AddWithValue("@Descricao", descricao);
						comando.Parameters.AddWithValue("@StatusTarefa", statusDaTarefa);
						comando.Parameters.AddWithValue("@Prioridade", prioridadeDaTarefa);

						comando.ExecuteNonQuery(); //consultar sem retorno
						Console.WriteLine("Tarefa ATUALIZADAAAAAAAAAAAAA, ISSO AIII!");
					}
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Não foi possível ATUALIZAR A TAREFA!");

			}



		}


	}
}
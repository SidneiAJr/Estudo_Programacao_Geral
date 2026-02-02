using System;
using System.Runtime.InteropServices.Marshalling;
using MySql.Data.MySqlClient;

namespace teste
{
	class program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Menu | 1- Verificar Conex Banco | 2- Lista Simples");
			int op;
			op = int.Parse(Console.ReadLine());
			switch (op){
			case 1:
			ConectarBanco cx1 = new ConectarBanco("localhost","empresa","3306","root","root");
					cx1.verificarconexção();
		    break;
			case 2:
			ListaTodos ls1 = new ListaTodos();
					ls1.listar();
			break;
		default:
		break;
			}
		}
	}

	interface verificaBanco
	{
		public void verificarconexção();
	}


	class ConectarBanco : verificaBanco
	{
		private String Host;
		private String Banco;
		private String Porta;
		private String password;
		private String user;

		public ConectarBanco(string Host, string Banco, string Porta, string password, string user)
		{
			this.Host = Host;
			this.Banco = Banco;
			this.Porta = Porta;
			this.password = password;
			this.user = user;
		}
		public void verificarconexção()
		{
			string connectionString = $"Server={Host};Port={Porta};Database={Banco};Uid={user};Pwd={password};";

			try
			{
				using (MySqlConnection conn = new MySqlConnection(connectionString))
				{
					conn.Open();
					Console.WriteLine("Conexão aberta com sucesso!");
					// Aqui você pode executar comandos SQL
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro na conexão: " + ex.Message);
			}
		}
	}

	class ListaTodos
	{
		private string connectionString;

		public ListaTodos()
		{
			this.connectionString = "Server=localhost;Port=3306;Database=empresa;Uid=root;Pwd=root;";
		}

		public void listar()
		{
			string sql = "SELECT id_funcionario, nome_funcionario FROM funcionarios";
			try
			{
				using (MySqlConnection conn = new MySqlConnection(connectionString))
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(sql, conn))
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Console.WriteLine($"ID: {reader.GetInt32(0)}, Nome: {reader.GetString(1)}");
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao listar dados: " + ex.Message);
			}
		}

	}







}

using System;
using Mono.Data.Sqlite;
using System.IO;
using System.Collections.Generic;


namespace libbrisa
{

	public class clsAcessoBanco
	{
		public const string db_file = "dpFsing.db3";
		public static string db_path = "\\"; //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), db_file);


			public static SqliteConnection GetConnection()
			{
				bool exists = File.Exists(db_path);

				if (!exists)
					SqliteConnection.CreateFile(db_path);

				var conn = new SqliteConnection("Data Source=" + db_path);
				if (!exists)
					CreateDatabase(conn);

				return conn;
			}

			private static void CreateDatabase (SqliteConnection conn)
			{
			var sql = @"CREATE TABLE F05Apontamentos (
		                Id INTEGER, 
		                Funcionario VARCHAR(250),
                        qtde float,
						hraTrab float
                        );";

				conn.Open();

				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery();
				}

				conn.Close();
			}

		public static bool inserir (string tabela, string campos, string valores){

			using (var conn = GetConnection())
			{
				conn.Open();

				using (var cmd = conn.CreateCommand())
				{

					cmd.CommandText = @"     INSERT INTO " + tabela +" ( " +  campos + ")  VALUES (" + valores + ")"; 
					return cmd.ExecuteNonQuery () > 0;
				}
			}
		}


		}

}


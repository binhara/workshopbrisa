using System;
using Mono.Data.Sqlite;
using System.IO;
using System.Collections.Generic;

namespace eCadCon
{
	class Repository
	{
		public const string db_file = "ecadcon.db3";
		public static string db_path = Path.Combine (System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal), db_file);

		public static SqliteConnection GetConnection ()
		{
			bool exists = File.Exists (db_path);

			if (!exists)
				SqliteConnection.CreateFile (db_path);

			var conn = new SqliteConnection ("Data Source=" + db_path);
			if (!exists)
				CreateDatabase (conn);

			return conn;
		}

		//public static Person Person { get; set; }

		private static void CreateDatabase (SqliteConnection conn)
		{
			var sql = @"CREATE TABLE PERSON (
		Id INTEGER PRIMARY KEY AUTOINCREMENT, 
		Name VARCHAR(250),
		Sex INTEGER,
		Color INTEGER,
		Birthdate DATETIME,
		Street VARCHAR(250),
		Number VARCHAR(250),
		Neighborhood VARCHAR(250),
		Cep VARCHAR(250),
		ReferenceName VARCHAR(250),
		Relationship INTEGER,
		FatherName VARCHAR(250),
		MotherName VARCHAR(250),
		Rg VARCHAR(250),
		RgExpeditioner VARCHAR(250),
		Cpf VARCHAR(250),
		VoterDocument VARCHAR(250),
		VotingZone VARCHAR(250),
		VotingSession VARCHAR(250),
		Ctps VARCHAR(250),
		CtpsSeries VARCHAR(250),
		CtpsUf VARCHAR(250),
		Email VARCHAR(250),
		Phone1 VARCHAR(250),
		Phone2 VARCHAR(250),
		Phone3 VARCHAR(250),
		Nationality VARCHAR(250),
		Uf VARCHAR(250),
		City VARCHAR(250),
		RelationshipStatus INTEGER,
		OcupationLevel VARCHAR(250),
		Company VARCHAR(250),
		ContractDate DATETIME,
		Position VARCHAR(250),
		MinimumSalaries VARCHAR(250),
		IncomeType INTEGER,
		CotractType INTEGER,
		WorkType INTEGER,
		Inss BOOLEAN,
		BolsaFamilia BOOLEAN,
		BolsaFamiliaNumber VARCHAR(250),
		Education INTEGER,
		ConclusionGrade VARCHAR(250),
		Rent INTEGER,
		RentValue VARCHAR(250),
		Iptu VARCHAR(250),
		HouseLevel INTEGER,
		HouseType INTEGER,
		ComfortLevel INTEGER,
		Rooms VARCHAR(250),
		Bedrooms VARCHAR(250),
		Zoning VARCHAR(250),
		Water BOOLEAN,
		Bathroom BOOLEAN,
		Floor BOOLEAN,
		WaterTreatment BOOLEAN,
		GarbageTreatment BOOLEAN,
		FloorMaterial INTEGER,
		WallMaterial INTEGER,
		HealthType VARCHAR(250),
		HealthClass VARCHAR(250),
		HealthStartDate DATETIME,
		HealthEndDate DATETIME
);";

			conn.Open ();

			using (var cmd = conn.CreateCommand ()) {
				cmd.CommandText = sql;
				cmd.ExecuteNonQuery ();
			}

			conn.Close ();
		}
	}
}


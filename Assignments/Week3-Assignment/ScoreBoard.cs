using Microsoft.Data.SqlClient;
namespace Week3_Assignment
{
    public class Sports
    {
        private string connectionString = "Data Source=HARSHITHP-PC;Initial Catalog=W3_Assignment;Integrated Security=True;Encrypt=False";

        public int SportID { get; set; }
        public string SportName { get; set; }
        public void CreateSportsTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "CREATE TABLE Sports (SportID int not null unique, SportName varchar(20) not null unique)";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Sport Table created successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void AddSport(int sportID, string sportName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Sports (SportID, SportName) VALUES (@SportID, @SportName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SportID", sportID);
                command.Parameters.AddWithValue("@SportName", sportName);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Sport {sportName} added successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Failed to add sport {sportName}!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void RemoveSport(int sportID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Sports WHERE SportID = @SportID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SportID", sportID);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Sport deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete sport!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public List<Sports> GetSports()
        {
            List<Sports> sportsList = new List<Sports>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SportID, SportName FROM Sports";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Sports sport = new Sports();
                    sport.SportID = (int)reader["SportID"];
                    sport.SportName = reader["SportName"].ToString();
                    sportsList.Add(sport);
                }
                reader.Close();
            }
            return sportsList;
        }

    }

    public class Tournament
    {
        private string connectionString = "Data Source=HARSHITHP-PC;Initial Catalog=W3_Assignment;Integrated Security=True;Encrypt=False";

        public void CreateTournamentTable()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "CREATE TABLE Tournament (tournamentID int IDENTITY (1, 1) primary key not null , tournamentName nchar(20) not null unique, tournamentDate nchar(20), tournamentSport varchar(20) not null unique)";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Tournament Table created successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void AddTournament(string tournamentName, string tournamentDate, string tournamentSport)
        {
            if (CheckDuplicateTournament(tournamentName))
            {
                Console.WriteLine("Tournament already exists!");
                return;
            }
            string query = "INSERT INTO Tournament (TournamentName, TournamentDate,tournamentSport) VALUES (@Name, @Date,@Sport)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", tournamentName);
                command.Parameters.AddWithValue("@Date", tournamentDate);
                command.Parameters.AddWithValue("@Sport", tournamentSport);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Tournament added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private bool CheckDuplicateTournament(string name)
        {
            string query = "SELECT COUNT(*) FROM Tournament WHERE TournamentName = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return false;
        }
        public void RemoveTournament(string tournamentName)
        {
            if (!CheckDuplicateTournament(tournamentName))
            {
                Console.WriteLine("Tournament does not exist!");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tournament WHERE TournamentName = @TournamentName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TournamentName", tournamentName);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Tournament deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete Tournament!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
    public class ScoreBoard{
        private string connectionString = "Data Source=HARSHITHP-PC;Initial Catalog=W3_Assignment;Integrated Security=True;Encrypt=False";
        public void CreateScoreBoardTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "CREATE TABLE ScoreBoard (scoreID int IDENTITY (1, 1) primary key not null , scoreTeam1 int not null, scoreTeam2 int not null, scoreTournament varchar(20) not null)";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("ScoreBoard Table created successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
    public class Runner
    {
        public Runner()
        {
            Sports sport = new Sports();
            sport.CreateSportsTable();
            sport.AddSport(1, "Cricket");
            sport.AddSport(2, "Football");
            sport.AddSport(3, "Basketball");
            sport.AddSport(4, "Hockey");
            List<Sports> sportsList = sport.GetSports();
            sport.RemoveSport(3);
            foreach (Sports s in sportsList)
            {
                Console.WriteLine($"{s.SportID} - {s.SportName}");
            }

            Tournament tournament = new Tournament();
            tournament.CreateTournamentTable();
            tournament.AddTournament("Tournament 1", "2020-01-01", "Cricket");
            tournament.AddTournament("Tournament 2", "2020-01-01", "Football");
            tournament.RemoveTournament("Tournament 1");

            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.CreateScoreBoardTable();


        }
    }

}
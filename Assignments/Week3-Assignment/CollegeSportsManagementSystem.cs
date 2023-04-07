using Microsoft.Data.SqlClient;
namespace Week3_Assignment
{
    public class HelperClass
    {
        internal string connectionString = "Data Source=HARSHITHP-PC;Initial Catalog=W3_Assignment;Integrated Security=True;Encrypt=False";
        public void CreateTable(string query, string successMessage)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(successMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public bool CheckDuplicate(string name, string table, string column)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column} = @Name";

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
    }
    public class Sports : HelperClass
    {

        public int SportID { get; set; }
        public string SportName { get; set; }
        public void CreateSportsTable()
        {
            string query = "CREATE TABLE Sports (SportID int not null unique, SportName varchar(20) not null unique)";
            CreateTable(query, "Sports Table created successfully!");
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

    public class Tournament : HelperClass
    {
        public void CreateTournamentTable()
        {
            string query = "CREATE TABLE Tournament (tournamentID int IDENTITY (1, 1) primary key not null , tournamentName nchar(20) not null unique, tournamentDate nchar(20), tournamentSport varchar(20) not null unique)";
            CreateTable(query, "Tournament Table created successfully!");
        }
        public void AddTournament(string tournamentName, string tournamentDate, string tournamentSport)
        {
            if (CheckDuplicate(tournamentName, "Tournament", "tournamentName"))
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


        public void RemoveTournament(string tournamentName)
        {
            if (CheckDuplicate(tournamentName, "Tournament", "TournamentName"))
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
    public class Teams : HelperClass
    {
        public void CreateTeamsTable()
        {
            string query = "create table Teams(teamID int identity (1,1) primary key not null,"
            + "teamName varchar(20) not null unique, teamSport varchar(20) not null,tournament_ID int not null,"
            + "foreign key(tournament_ID) references Tournament(tournamentID)"
            + "on delete cascade)";
            CreateTable(query, "Teams Table created successfully!");
        }
        public void AddTeams(string teamName, string teamSport, int tournamentID)
        {
            if (CheckDuplicate(teamName, "Teams", "teamName"))
            {
                Console.WriteLine("Team already exists!");
                return;
            }
            string query = "INSERT INTO Teams (teamName, teamSport, tournament_ID) VALUES (@Name, @Sport, @TournamentID)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", teamName);
                command.Parameters.AddWithValue("@Sport", teamSport);
                command.Parameters.AddWithValue("@TournamentID", tournamentID);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Team added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
    public class Matches : HelperClass
    {
        public void CreateMatchesTable()
        {
            string query = "create table Matches(Id int identity (1,1) primary key not null, Name varchar(20) not null,"
            + "Team1_ID int not null, Team2_ID int not null, Tournament_ID int not null,"
            + "foreign key(Team1_ID) references Teams(teamID), foreign key(Team2_ID) references Teams(teamID),"
            + "foreign key(Tournament_ID) references Tournament(tournamentID)" + "on delete cascade)";
            CreateTable(query, "Matches Table created successfully!");
        }
        public void AddMatches(string name, int team1ID, int team2ID, int tournamentID)
        {
            if (CheckDuplicate(name, "Matches", "Name"))
            {
                Console.WriteLine("Match already exists!");
                return;
            }
            string query = "INSERT INTO Matches (Name, Team1_ID, Team2_ID, Tournament_ID) VALUES (@Name, @Team1_ID, @Team2_ID, @Tournament_ID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Team1_ID", team1ID);
                command.Parameters.AddWithValue("@Team2_ID", team2ID);
                command.Parameters.AddWithValue("@Tournament_ID", tournamentID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Match added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
    public class Players : HelperClass
    {
        public void CreatePlayersTable()
        {
            string query = "create table Players(playerID int identity (1,1) primary key not null,"
            + "playerName varchar(20) not null, playerTeamID int not null,"
            + "foreign key(playerTeamID) references Teams(teamID)"
            + "on delete cascade)";
            CreateTable(query, "Players Table created successfully!");
        }
        public void AddPlayer(string playerName, int playerTeamID)
        {
            if (CheckDuplicate(playerName, "Players", "playerName"))
            {
                Console.WriteLine("Player already exists!");
                return;
            }
            string query = "INSERT INTO Players (playerName, playerTeamID) VALUES (@Name, @TeamID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", playerName);
                command.Parameters.AddWithValue("@TeamID", playerTeamID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Player added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }

    public class ScoreBoard : HelperClass
    {
        public void CreateScoreBoardTable()
        {
            string query = "CREATE TABLE ScoreBoard (scoreID int IDENTITY (1, 1) primary key not null , scoreTeam1 int not null, scoreTeam2 int not null, scoreTournament varchar(20) not null)";
            CreateTable(query, "ScoreBoard Table created successfully!");
        }
    }

    public class CollegeSportsManagementSystem
    {
        public CollegeSportsManagementSystem()
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

            Teams teams = new Teams();
            teams.CreateTeamsTable();
            teams.AddTeams("Team 1", "Cricket", 1);
            teams.AddTeams("Team 2", "Cricket", 1);

            Matches matches = new Matches();
            matches.CreateMatchesTable();
            matches.AddMatches("Match 1", 1, 2, 1);

            Players players = new Players();
            players.CreatePlayersTable();
            players.AddPlayer("Player 1", 1);
        }
    }

}
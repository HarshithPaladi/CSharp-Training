using Microsoft.Data.SqlClient;
namespace SQLConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=HARSHITHP-PC;Initial Catalog=PracticeDatabase;Integrated Security=True;Encrypt=False;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from technologies";
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine($"ID     -    Tech");
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32(1)}    -   {reader.GetString(0)}");
            }
            connection.Close();
        }
    }
}
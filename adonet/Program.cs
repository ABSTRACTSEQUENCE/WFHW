using System;
using System.Data.SqlClient;
namespace adonet
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=HOME-PC\\SQLEXPRESS; Database=AdonetHW; Trusted_Connection=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            //1
            {
                /* cmd.CommandText = @"SELECT FirstName, LastName, [Position].PositionName FROM Employee, Position
									 WHERE [Employee].PositionID = [Position].PositionID";
				 SqlDataReader data = cmd.ExecuteReader();
				 if (data.HasRows)
					 while (data.Read())
						 for (int i = 0; i < data.FieldCount; i++)
						 {
							 Console.WriteLine($"{data.GetName(i)}: {data[i]}\n");
						 }
					 */
            }
            //2
            {
                /*cmd.CommandText = "SELECT FirstName, LastName, DateOfBirth FROM Customers";
                SqlDataReader data = cmd.ExecuteReader();
                for (int i = 0; i < data.FieldCount; i++)
                {
                    Console.WriteLine(data.GetName(i));
                    while (data.Read())
                    {
                        Console.WriteLine(data[i]);
                    }
                    data.Close();
                    data = cmd.ExecuteReader();
                    Console.WriteLine("-----------------");
                }*/
            }
            //3
            {
                cmd.CommandText = "SELECT FirstName, LastName FROM Customers";
                SqlDataReader data = cmd.ExecuteReader();
                Console.WriteLine("First names:");
                while (data.Read())
                    Console.WriteLine(data["FirstName"]);
                Console.WriteLine("Second names:");
                data.Close();
                data = cmd.ExecuteReader();
                while (data.Read())
                    Console.WriteLine(data["LastName"]);
            }
        }
    }
}

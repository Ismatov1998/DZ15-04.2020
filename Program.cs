using System;
using System.Data;
using System.Data.SqlClient;

namespace Fg
{
    class Program
    {
        static void Main(string[] args)
        {
           
    

            //@"Data source=localhost; Initial catalog=DBName; Integrated Security=True"                                               DB
            const string conString = @"Data source=localhost; Initial catalog=Conect; Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            con.Open();//Открывает соединение
            // if (con.State == ConnectionState.Open)
            // {
            //     System.Console.WriteLine("Connected successfully!!!");
            // }
            // else
            // {
            //     System.Console.WriteLine("Ooops, troubles with connection!!!");
            // }
            // string insertSqlCommand1 = string.Format($"delete Table_1 where id=84"); 
            // SqlCommand command = new SqlCommand(insertSqlCommand1, con);
            //var result1 = command.ExecuteNonQuery();
            
             Console.WriteLine("Введите 1 если хотите взять выбрать всё таблицу");
            int n= Console.REadline();
           
            string commandText = "Select * from Person";
            SqlCommand command = new SqlCommand(commandText, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"ID:{reader.GetValue("id")},FirstName:{reader.GetValue("name")},LastName{reader.GetValue("LastName")},MiddleName{reader.GetValue("MiddleName")},BirthDate{reader.GetValue("BirthDate")}");
            }
            reader.Close();

            string insertSqlCommand = string.Format($"insert into Person Values('{"Test"}','{"Testov"}',{"Testovich"},'{"2020-04-15 00:00:00"}')");
            command = new SqlCommand(insertSqlCommand, con);
            var result = command.ExecuteNonQuery();
            
            
            
            // string insertSqlCommand1 = string.Format($"delete Table_1 where id=72"); 
            // command = new SqlCommand(insertSqlCommand1, con);
            // var result1 = command.ExecuteNonQuery();
          
           
        
            
            con.Close(); //<<<<<<<<<<<<<<<< Вот так
        
         }
        }
 }



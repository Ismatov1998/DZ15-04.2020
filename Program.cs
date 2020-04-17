using System;
using System.Data;
using System.Data.SqlClient;

namespace Fg
{
    class Program
    {
        static void Main(string[] args)
        {
           
    

                 
            const string conString = @"Data source=localhost; Initial catalog=Conect; Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            con.Open();
            
             Console.WriteLine("Введите 1 если хотите делать Select");
             Console.WriteLine("Введите 2 если хотите делать Insert ");
             Console.WriteLine("Введите 3 если хотите делать Select by id");
             Console.WriteLine("Введите 4 если хотите update");
             Console.WriteLine("Введите 5 если хотите delete");

            int n=Convert.ToInt32( Console.ReadLine());
            if(n==1)
            {
            string commandText = "Select * from Person";
            SqlCommand command = new SqlCommand(commandText, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"ID: {reader.GetValue("id")},FirstName: {reader.GetValue("FirstName")},LastName: {reader.GetValue("LastName")},MiddleName: {reader.GetValue("MiddleName")},BirthDate: {reader.GetValue("BirthDate")}");
            }
            reader.Close(); 
            }
            if(n==2)
            {
              Console.WriteLine("введите имю:");
              Console.WriteLine("фамилю:");
              Console.WriteLine("отчеству");
              Console.WriteLine("DateTime в формате yy-mm-dd hh:mm:ss ");
              string a=Console.ReadLine(); 
              string b=Console.ReadLine(); 
              string c=Console.ReadLine(); 
              string d=Console.ReadLine();
            string insertSqlCommand = string.Format($"insert into Person([FirstName],[LastName],[MiddleName],[BirthDate]) Values('{a}','{b}','{c}','{d}')");
            SqlCommand command = new SqlCommand(insertSqlCommand, con);
            var result = command.ExecuteNonQuery(); 
            string commandText = "Select * from Person";
             command = new SqlCommand(commandText, con);
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"ID: {reader.GetValue("id")},FirstName: {reader.GetValue("FirstName")},LastName: {reader.GetValue("LastName")},MiddleName: {reader.GetValue("MiddleName")},BirthDate: {reader.GetValue("BirthDate")}");
            }
            reader.Close();

            
            }
            if(n==3)
            {
            Console.WriteLine("введите ID");
            int a1=Convert.ToInt32(Console.ReadLine());  
            string insertSqlCommand = string.Format($"select * from Person where id={a1}");
            SqlCommand command = new SqlCommand(insertSqlCommand, con);
            var result = command.ExecuteNonQuery();
            

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"ID: {reader.GetValue("id")},FirstName: {reader.GetValue("FirstName")},LastName: {reader.GetValue("LastName")},MiddleName: {reader.GetValue("MiddleName")},BirthDate: {reader.GetValue("BirthDate")}");
            }
           
            reader.Close();
            }
            if(n==5)
            {
             Console.WriteLine("введите ID");
            int a1=Convert.ToInt32(Console.ReadLine());  

             string insertSqlCommand = string.Format($"delete Person where id={a1}");
            SqlCommand command = new SqlCommand(insertSqlCommand, con);
             var result = command.ExecuteNonQuery();

            string commandText = "Select * from Person";
            command = new SqlCommand(commandText, con);
            
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine($"Таблица после удаления {a1} го строка");
            while (reader.Read())
            {
                System.Console.WriteLine($"ID: {reader.GetValue("id")},FirstName: {reader.GetValue("FirstName")},LastName: {reader.GetValue("LastName")},MiddleName: {reader.GetValue("MiddleName")},BirthDate: {reader.GetValue("BirthDate")}");
            }
            
            reader.Close();

                
             
             
           
            }
            if(n==4)
            {
                Console.WriteLine("Введите FirstName");
                Console.WriteLine("Введите LastName");
                Console.WriteLine("Введите MiddleName");
                Console.WriteLine("Введите DateTime ");
                Console.WriteLine("Введите ID стороку который хотите обновлять");
                string s1=(Console.ReadLine());
                string s2=(Console.ReadLine());
                string s3=(Console.ReadLine());
                string s4=(Console.ReadLine());
                int n2=Convert.ToInt32(Console.ReadLine());

                string insertSqlCommand = $"Update Person set FirstName='{s1}',LastName='{s2}',MiddleName='{s3}',BirthDate='{s4}' where id={n2}";
                SqlCommand command = new SqlCommand(insertSqlCommand, con);
                var result = command.ExecuteNonQuery();

                string commandText = "Select * from Person";
                command = new SqlCommand(commandText, con); 

                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"Таблица после обновления");
                 while (reader.Read())
                 {
                     
                    System.Console.WriteLine($"ID: {reader.GetValue("id")},FirstName: {reader.GetValue("FirstName")},LastName: {reader.GetValue("LastName")},MiddleName: {reader.GetValue("MiddleName")},BirthDate: {reader.GetValue("BirthDate")}");
                 }
                   
                
                   reader.Close();

                


            }
        
          
           
        
            
            con.Close(); 
        
         }
        }
 }



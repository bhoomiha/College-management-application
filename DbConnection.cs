using System;
using MySql.Data.MySqlClient;
public class DbConnection{
    static string connectionDB = @"server = localhost;
        userid = root; password =pass; database=collegemanagement;";
    static MySqlConnection? connect ;
    public static MySqlConnection createConnection(){
           
    try{
       connect = new MySqlConnection(connectionDB);
      }
     catch(MySqlException e){
         Console.WriteLine("Error: "+ e.Message.ToString());
    }
    return connect;          
}}
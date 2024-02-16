using System;
using MySql.Data.MySqlClient;
public class StaffDAO{
    public void showAllStaff(int role_id){
        if(role_id ==1 || role_id==2 || role_id==3){
            try{
                MySqlConnection connection = DbConnection.createConnection();
                connection.Open();
                string query = "select * from staff";
                MySqlCommand command = new MySqlCommand(query,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "[ID]\t\t[Name]\t\t[Designation]\t\t[Department]\t\t[Email]\n";

                if(reader.HasRows){
                while(reader.Read()){
                    Console.WriteLine(reader.GetInt32(0));
                    data += reader.GetInt32(0) +"\t\t" + reader.GetString(1) +"\t\t" + reader.GetString(2)
                    +"\t\t" + reader.GetString(3) +"\t\t"+ reader.GetString(5)+Environment.NewLine;
                }
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Data is empty");
            }
            connection.Close();
            }
            catch{
                Console.WriteLine("Error");
            }}
            else{
                Console.WriteLine("you have no acess to view all staff details");
            }
    }

    public void insertStaff(Staff staf, int Role_id){
        if(Role_id ==1){
        try{
            MySqlConnection connect = DbConnection.createConnection();
            connect.Open();
        
            string cmd = "insert into staff(staff_name,Role_name,Department,username,email,password) values(@staff_name,@Role_name,@Department,@username,@email,@password)";
            MySqlCommand command= new MySqlCommand(cmd,connect);
        
            command.Parameters.AddWithValue("@staff_name",staf.getName());
            command.Parameters.AddWithValue("@Role_name",staf.getDesignation());
            command.Parameters.AddWithValue("@Department",staf.getDepartment());
            command.Parameters.AddWithValue("@username",staf.getUsername());
            command.Parameters.AddWithValue("@email",staf.getEmail());
            command.Parameters.AddWithValue("@password",staf.getpassword());
        
            command.Prepare();
            command.ExecuteNonQuery();
            connect.Close();
            Console.WriteLine("Added successfully");
        }
        catch{
            Console.WriteLine("Fill correct details!");
        }}
        else{
            Console.WriteLine("You have no acess to insert staff");
        }
    }
    public void  updateDetails(string update, int staffId, int choice,int Role_id){
        if(Role_id==1 || Role_id==4){
        try{
            MySqlConnection connection = DbConnection.createConnection();
            connection.Open();
            string query;
            if(choice ==1){
             query = " update staff set email = '" + update + "' where staff_id= " +staffId ;}
            else{
             query ="update staff set password = '"+update +"' where staff_id ="+staffId ;
            }
            MySqlCommand command = new MySqlCommand(query,connection);
        
            command.Prepare();
            command.ExecuteNonQuery();
        
            connection.Close();
        }catch{

        }}else{Console.WriteLine("You have no acess to update staff details");}
    }
    public void deleteRecord(int staf_id,int Role_id){
        if(Role_id ==1){
        try{
            MySqlConnection connection = DbConnection.createConnection();
            connection.Open();
            string query = "delete from staff where staff_id=" +staf_id;
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Deleted successfully");

        }
        catch{
            Console.WriteLine("wrong details");
        }}else{Console.WriteLine("You have no acess to delete record");}

    }
    public void showStaff(int staff_id){
        try{
            MySqlConnection connection = DbConnection.createConnection();
            connection.Open();
            string query = "select * from staff where staff_id=" +staff_id;
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            var data = "[ID]\t\t[Name]\t\t[Designation]\t\t[Department]\t\t[Email]\n";
            if(reader.HasRows){
                while(reader.Read()){
                    Console.WriteLine(reader.GetInt32(0));
                    data += reader.GetInt32(0) +"\t\t" + reader.GetString(1) +"\t\t" + reader.GetString(2)
                    +"\t\t" + reader.GetString(3) +"\t\t"+ reader.GetString(5)+Environment.NewLine;
                }
                Console.WriteLine(data);
            }
            connection.Close();
        }catch{

        }
    }



}
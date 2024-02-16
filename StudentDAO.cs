
using System;
using MySql.Data.MySqlClient;
public class StudentDAO{
    int flag=0;
public void showAllStudents(int role_id) {
    if (role_id ==1 || role_id ==2 || role_id ==3 || role_id==4){
    try{
        MySqlConnection connection = DbConnection.createConnection();
        connection.Open();
        string cmd = "select * from student";
        MySqlCommand command = new MySqlCommand(cmd,connection);
        MySqlDataReader reader = command.ExecuteReader();

        var data = "[ID]\t\t[Name]\t\t[AdmissionID]\t\t[Department]\t\t[Email]\t\t[Passingyear]\n";
        if(reader.HasRows){
            while(reader.Read()){
                data += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" +
                 reader.GetInt32(2) + "\t\t" + reader.GetString(3) +"\t\t"+ reader.GetString(5)+
                 "\t\t"+ reader.GetInt32(7) + Environment.NewLine;
            }
            Console.WriteLine(data);
        }else{
            Console.WriteLine("Data is empty...");
            Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
        }
        connection.Close();
                
        }catch(MySqlException e){
            Console.WriteLine("Error: "+ e.Message.ToString());
        }}else{Console.WriteLine("You have no acess to view all students");}
         
    }

public int insertStudent(Student s,int role_id){
    if(role_id==1){
    try{
        
        MySqlConnection connection = DbConnection.createConnection();
        connection.Open();
    
        string query = "insert into student(student_name, Admission_id, Department,username,email,password,passingyear)values(@student_name, @Admission_id, @Department,@username,@email,@password,@passingyear)";
        MySqlCommand command = new MySqlCommand(query, connection);

        command.Parameters.AddWithValue("@student_name",s.getName());
        command.Parameters.AddWithValue("@Admission_id", s.getAdmissionId());
        command.Parameters.AddWithValue("@Department",s.getDepartment());
        command.Parameters.AddWithValue("@username",s.getUsername());
        command.Parameters.AddWithValue("@email",s.getEmail());
        command.Parameters.AddWithValue("@password",s.getPassword());
        command.Parameters.AddWithValue("@passingyear", s.getPassingyear());
    
        command.Prepare();
        command.ExecuteNonQuery();
        connection.Close();
        flag=1;
        return flag;
}catch{
        return flag;
    }}
    else{
        Console.WriteLine("You have no acess to insert student");
        return flag;
    
    }
}

public void deleteStudent(int studentid,int Role_id){
    if(Role_id ==1){
    try{
        MySqlConnection connection = DbConnection.createConnection();
        connection.Open();
        string query ="delete from student where student_id =" +studentid;
        MySqlCommand command = new MySqlCommand(query,connection);
        command.Prepare();
        command.ExecuteNonQuery();
        connection.Close();
        Console.WriteLine("Deleted sucessfully");
        
    }catch{
        Console.WriteLine("No such student");

    }}else{Console.WriteLine("You have no acess to delete student");}
}
public void updateStudentDetails(string update, int stuId,int choice ){
    try{
        MySqlConnection connection = DbConnection.createConnection();
        connection.Open();
        string query;
        if(choice==1){
         query = " update student set email = '" + update + "' where student_id= " +stuId ;}
         else{
            query = "update staff set password= '" +update +"' where student_id=" +stuId;
         }
            MySqlCommand command = new MySqlCommand(query,connection);
        
            command.Prepare();
            command.ExecuteNonQuery();
        
            connection.Close();
        }catch{

        }

}
public void showStudent(int studentId){
    try{
        MySqlConnection connection = DbConnection.createConnection();
        connection.Open();
        string query = "select * from student where student_id="+studentId;
        MySqlCommand command = new MySqlCommand(query,connection);
        MySqlDataReader reader = command.ExecuteReader();
         var data = "[ID]\t\t[Name]\t\t[AdmissionID]\t\t[Department]\t\t[Email]\t\t[Passingyear]\n";
        if(reader.HasRows){
            while(reader.Read()){
                data += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" +
                 reader.GetInt32(2) + "\t\t" + reader.GetString(3) +"\t\t"+ reader.GetString(5)+
                 "\t\t"+ reader.GetInt32(7) + Environment.NewLine;
            }
            Console.WriteLine(data);
        }else{
            Console.WriteLine("Data is empty...");
            Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
        }
        connection.Close();
    }catch{}
}

}

        
    
    
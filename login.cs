using MySql.Data.MySqlClient;
class Login {
 Validator validator3 = new Validator();
  StudentDAO studentDAO3 = new StudentDAO();  
    public void enterDetails(int select){

        String username = validator3.validateName("username");
        Console.WriteLine("Enter password");
        String? password = Console.ReadLine();
        try{
            MySqlConnection connection = DbConnection.createConnection();
            connection.Open();
            string cmd ;

            if(select ==1){
             cmd = "select username,password,Role_name from staff where username='"+username+"' and password='"+password+"'";}
             else{
             cmd= "select username, password,student_id from student where username='"+username+"' and password='"+password+"' ";
             }
            MySqlCommand command = new MySqlCommand(cmd,connection);
            MySqlDataReader reader = command.ExecuteReader();
            
            if(reader.Read()){
              String name = reader.GetString(0);
              Console.WriteLine("Welcome " +name);
              string Role_name;
              if(select==1){
               Role_name =  reader.GetString(2);
               getRole(Role_name);}
               else{
                 int Student_id = reader.GetInt32(2);
                 studentDAO3.showStudent(Student_id);

               }
              
              
            }
            else{
                Console.WriteLine("no such user"); 
            }
            connection.Close();
        }catch{
            Console.WriteLine("Invalid details");
        }
    }

    public void getRole(String Role_name){
        try{
            MySqlConnection connection = DbConnection.createConnection();
            connection.Open();
            string cmd ="select Role_id from Role where Role_name = '"+Role_name+"'";
             MySqlCommand command = new MySqlCommand(cmd,connection);
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read()){
                int id = reader.GetInt32(0);
                chooseRoles(id);
            }
              else{
                Console.WriteLine("no such user"); 
            }
            connection.Close();}
    catch{
            Console.WriteLine("Invalid details");
        }}

    public void chooseRoles(int Role_id){
        Staff staff2 = new Staff(1);
        switch(Role_id){
            case 1: displayAdminRoles();
                    Admin admin = new Admin();
                    admin.doRoles(Role_id);
                    break;
            case 2: showPrincipalRoles();
                    staff2.givePrincipalHODAcess(Role_id);
                    break;
            case 3: showHodroles();
                    staff2.givePrincipalHODAcess(Role_id);
                    break;
            case 4: showStaffRoles();
                    staff2.giveStaffAcess(Role_id);
                    break;
            /*case 5: showStudentAcess();
                    student1.giveStudentAcess();
                    break;*/
            default: Console.WriteLine("Invalid details");
                    break;
                    
        }
           
    }
    public void displayAdminRoles(){
              Console.WriteLine("Admin Roles");
                    Console.WriteLine("Enter 1 to add student");
                    Console.WriteLine("Enter 2 to add staff");
                    Console.WriteLine("Enter 3 to view students details");
                    Console.WriteLine("Enter 4 to view staff details");
                    Console.WriteLine("Enter 5 to update student details");
                    Console.WriteLine("Enter 6 to update staff details");
                    Console.WriteLine("Enter 7 to delete a student record");
                    Console.WriteLine("Enter 8 to delete a staff record");}
    
    public void showPrincipalRoles(){
        Console.WriteLine("Principal Roles");
                    Console.WriteLine("Enter 1 to view staff details");
                    Console.WriteLine("Enter 2 to view student details");}
    public void showHodroles(){
        Console.WriteLine("HOD roles");
                    Console.WriteLine("Enter 1 to view staff details");
                    Console.WriteLine("Enter 2 to view student details");
    }
    public void showStaffRoles(){
        Console.WriteLine("Staff roles");
                    Console.WriteLine("Enter 1 to view student details");
                    Console.WriteLine("Enter 2 to update self details");
                    Console.WriteLine("Enter 3 to view self details");}
    /*public void showStudentAcess(){
        Console.WriteLine("Student Acess");
                    Console.WriteLine("Enter 1 to view details");
                    //Console.WriteLine("Enter 2 to update details");

    }*/


}
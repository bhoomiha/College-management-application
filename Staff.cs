using MySql.Data.MySqlClient;
public class Staff : Member {
    StaffDAO staffDAO1 = new StaffDAO();
    StudentDAO studentDAO1 = new StudentDAO();
    private string? Designation = System.String.Empty;
    Validator validator2 = new Validator();
    string password;
    public Staff() :base(1){

        Designation =validator2.validateName("Designation"); 

    }
    public Staff(int num){
        //Console.WriteLine(num);
    }
    public string getDesignation(){
        if(Designation != null) 
        return Designation;
        else{
            return "Not filled";
        }
    }
    public int updateStaff(){
        Console.WriteLine("Enter staff_id");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }
    public void setPassword(){
        string extra = getEmail();
        password = extra.Substring(1,3)+getDepartment();
    }
    public string getpassword(){
        return password;
    }

    public void givePrincipalHODAcess(int role_id){
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option){
            case 1 : staffDAO1.showAllStaff(role_id);
                     break;
            case 2 : studentDAO1.showAllStudents(role_id);
                     break;
        }
    }

    public void giveStaffAcess(int role_id){
        int option = Convert.ToInt32(Console.ReadLine());
        int staf_id;
        switch(option){
            case 2 :  (int choice,string update) = getChoice();
                      int staff_id=updateStaff();
                     staffDAO1.updateDetails(update,staff_id, choice,role_id);
                     break;
            case 1 : studentDAO1.showAllStudents(role_id);
                     break;
            case 3 : staf_id = updateStaff();
                     staffDAO1.showStaff(staf_id);
                     break;

    }
    }
       
         

/*private int salary=0;
    private int salaryEarned=0;
    public Teacher() :base(){
        Console.WriteLine("Enter salary");
        salary = Convert.ToInt32(Console.ReadLine());
    }
    public int getSalary(){
        return  salary;
    }
    public void setSalary(int salary){
        this.salary=salary;
    }
    public void receiveSalary(int salary){
        salaryEarned+=salary;
        //School.updateTotalMoneySpent(salary);}
    */
    
    }
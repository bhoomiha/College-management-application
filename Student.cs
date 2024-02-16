using System.Collections;
using System;
public class Student: Member {
    private string Admission_Id;
    private string? passingyear;
   Validator validator1 = new Validator();
    static int addon;
    private string password = System.String.Empty;

    StudentDAO studentDAO2 = new StudentDAO();
    public Student() : base(1){
        Admission_Id= validator1.validateID();
        passingyear = validator1.validateYear();
    }
    public Student(int num){}
    public void setAdmissionId(string admission_id){
        Admission_Id = admission_id; 
    }
   public string getAdmissionId(){
    return Admission_Id;
   }
   public void setPassingyear(string passingyear){
    this.passingyear = passingyear;
   }
   public string getPassingyear(){
    return passingyear;
   }
   
   public void setpassword(){
    string r= getUsername();
    addon++;
   // char extrachar = Convert.ToChar(addon);
    string year = getPassingyear();
    password = r.Substring(1,2)+year.Substring(2)+addon;
   }
   
   public string getPassword(){
    return password;
   }

   public int updateStudent(){
    Console.WriteLine("Enter id");
    int idd = Convert.ToInt32(Console.ReadLine());
    return(idd);
   }

    
    
    }
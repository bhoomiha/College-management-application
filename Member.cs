public class Member{
    private string name =System.String.Empty;
    private string? email =System.String.Empty;
    private string? deparment = System.String.Empty;
    private string username = System.String.Empty;
    Validator validator = new Validator();

    public Member(int n){
        name = validator.validateName("name");
        email = validator.validateMail();
        deparment = validator.validateName("department");
    }
    public Member(){}
    public string getEmail(){
        if(email != null){
        return email;}
        else{ return "not filled";}
    }
    public string getName(){
        return name;
    }
    public string getDepartment(){
        if(deparment!=null){return deparment;}
        else{return "notfilled";}
    }
    public void setUsername(){
       username = getName().ToLower();
   }
   public string getUsername(){
    if(username!=null){return username;}
    else{return "not filled";}
   }

public (int,string) getChoice(){
   Console.WriteLine("Enter 1 to update Email-ID");
    Console.WriteLine("Enter 2 to update password");
    int  choice = Convert.ToInt32(Console.ReadLine());
    string? update =System.String.Empty;
    if(choice ==1){
        Console.WriteLine("Enter new email");
        update= validator.validateMail();
        return(choice,update);}
        else{
            Console.WriteLine("Enter new password");
            update = Console.ReadLine();
            return(choice,update);
        }
    

}

}

class CollegeWeb{ 
      
     static public  void Main(){
         int useroption;
        Login login = new Login();
         Console.WriteLine("----College Management Application----");
         while(true){
            Console.WriteLine("Enter 1 for staff login");
            Console.WriteLine("Enter 2 for student login");
            Console.WriteLine("Enter 3 to exit");
            //Console.WriteLine("Enter 4 to display student");
            
            useroption =  Convert.ToInt32(Console.ReadLine());

            switch(useroption){

            case 1 :Console.WriteLine("Staff Login");
                    login.enterDetails(1);
                    break;
            case 2 :Console.WriteLine("Student Login");
                    login.enterDetails(2);
                    break;
            case 3: Environment.Exit(1);
                    break;
            default: Console.WriteLine("Enter valid input");
                     Environment.Exit(1);
                     break;
            
           }
        }
        
    }}

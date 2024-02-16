using System;
using System.Text.RegularExpressions;
using System.Net.Mail;
class Validator{
    private static Regex IDPattern = new Regex(@"^\d{1,4}$");
    private static Regex namePattern = new Regex(@"^[a-zA-Z]+$");
    private static Regex yearPattern = new Regex(@"^\d{4}$");
public string validateName(string namee){
    string? name;
    while(true){  
    Console.WriteLine("Enter "+namee);
    name = Console.ReadLine();
    if(!namePattern.IsMatch(name)){
      Console.WriteLine("enter valid name");
    }else{break;}
    }
    return name;
}
public string validateYear(){
    string? year;
    while(true){
        Console.WriteLine("Enter passingyear");
        year=Console.ReadLine();
        if(!yearPattern.IsMatch(year)){
            Console.WriteLine("Enter valid year");
        }else{break;}
    }
    return year;
}
public string validateID(){
    string? Id;
    while(true){
        Console.WriteLine("Enter AdmisssionId");
        Id = Console.ReadLine();
        if(!IDPattern.IsMatch(Id)){
            Console.WriteLine("enter valid Id");
        }else{break;}
    }
    return Id;
}
public string validateMail(){
    string? Mail;
    while(true){
        Console.WriteLine("Enter EmailId");
        Mail = Console.ReadLine();
        if(! isValidMail(Mail)){
            Console.WriteLine("Enter valid EmailId");
        }else{break;}
        }
        return Mail;
}

public bool isValidMail(string mailId){
    try{
        MailAddress mail = new MailAddress(mailId);
        return true;
    }catch{
return false;}
}}
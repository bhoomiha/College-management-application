public class Admin{
    public void doRoles(int Role_id){
        StudentDAO studentdao = new StudentDAO();
        StaffDAO staffDAO = new StaffDAO();
        Student student1 = new Student(1);
        Staff staff1 = new Staff(3);

        int id = Role_id;
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option){
            case 1: Student student = new Student();
                    student.setUsername();
                    student.setpassword();
                    
                    int state=studentdao.insertStudent(student,Role_id);
                    if(state!=0)
                    Console.WriteLine("Added Successfully");
                    break;

            case 2: Staff staff = new Staff();
                    staff.setUsername();
                    staff.setPassword();
                    staffDAO.insertStaff(staff,Role_id);
                    
                     break;

            case 3: studentdao.showAllStudents(Role_id);
                    break;
            
            case 4: staffDAO.showAllStaff(Role_id);
                    break;

            case 5: (int opt, string updation) = student1.getChoice();
                    int studentId = student1.updateStudent();
                    studentdao.updateStudentDetails(updation,studentId,opt);
                    break;

            case 6: (int choice,string update) = staff1.getChoice();
                    int staff_id= staff1.updateStaff();
                     staffDAO.updateDetails(update,staff_id, choice,Role_id);
                     break;

            case 7: int student_id = student1.updateStudent();
                     studentdao.deleteStudent(student_id,Role_id);
                     break;
             

            case 8: int stafid = staff1.updateStaff();
                    staffDAO.deleteRecord(stafid,Role_id);
                    break;

        }
    }
    
}
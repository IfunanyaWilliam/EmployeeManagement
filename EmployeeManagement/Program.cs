namespace EmployeeManagement
{


    public class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee(001, "Ifunanya Onah", new DateTime(2017,11,11));
            employee1.JobTitle = "Software Developer";
            employee1.Department = "Information Technology";

            Employee employee2 = new Employee(002, "Nwachukwu Uzor", new DateTime(2019, 12, 11));
            employee2.JobTitle = "Deveops Engineer";
            employee2.Department = "Information Technology";

            Employee employee3 = new Employee(003, "Raphael Isaac", new DateTime(2020, 1, 6));
            employee3.JobTitle = "Network Engineer";
            employee3.Department = "Information Technology";

            Employee employee4 = new Employee(004, "Temilade Olamide", new DateTime(2009, 9, 4));
            employee4.JobTitle = "Program Manager";
            employee4.Department = "Administration";

            Employee employee5 = new Employee(005, "Taiwo Tajudeen", new DateTime(2017, 11, 11));
            employee5.JobTitle = "Front Desk";
            employee5.Department = "Administration";


                           
            Employee[] employeeRecord = new Employee[] { employee1, employee2, employee3, employee4, employee5 };


            static void DisplayEmployeeDetails(Employee staff)
            {
                //Console.WriteLine($"StaffID \t  Full Name \t Job Title \t Department");
                Console.WriteLine($"{staff.StaffId} \t\t {staff.EmploymentDate.Date.ToString("dd/MM/yyyy")} \t\t {staff.FullName} \t\t {staff.JobTitle} \t {staff.Department}");

            }


            Console.WriteLine($"StaffID \t Employment Date \t  Full Name \t Job Title \t Department");
            foreach (Employee employee in employeeRecord)
            {
                DisplayEmployeeDetails(employee);
            }

           
        }
    }
}

/*
 * 
Perform the following operations in the Main() method of Program.cs:
1. Create 5 employees by instantiating the Employee class
○ Make staff id and name attributes different for each employee.
○ Give each employee a different job title.
○ Assign 3 employees the same department, and the other 2 a different department.
2. Store all 5 employees in an array of type Employee. 
3. Using a loop, display the records from the array in the form of a register:
○ The first line should provide attribute headings, separated by tab spaces. 
○ The attributes in each record should be, separated by tab spaces.
○ Each record should appear on a new lin 

*/
namespace EmployeeManagement
{
    public class Employee
    {
        private int _StaffId;
        private string _FullName;
        private DateTime _EmploymentDate;
        

        public Employee(int staffID, string fullName, DateTime employmentDate)
        {
            _StaffId = staffID;
            _FullName = fullName;
            _EmploymentDate = employmentDate;

        }


        public DateTime time = new DateTime();

        public int StaffId {    get { return _StaffId;} }

        public string FullName { get { return _FullName;} }

        public DateTime EmploymentDate { get { return _EmploymentDate;} }

        public string Department { get; set; }

        public string JobTitle { get; set; }


        

        /// <summary>
        /// A method that displays when an employee checks in at work. 
        /// </summary>
        public void ClockIn()
        {   
            DateTime time = DateTime.Now;
            Console.WriteLine($"{_FullName} Clocked in at {time.ToString("F")}");
        }

        /// <summary>
        /// A method that displays when an employee Clocks Out
        /// </summary>
        public void ClockOut()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"{_FullName} Clocked out at {time.ToString("F")}");
        }


        public void Work()
        {
            Console.WriteLine($"{_FullName} is currently working");
        }


    }
}
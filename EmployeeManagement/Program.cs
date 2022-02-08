namespace EmployeeManagement
{


    public class Program
    {
        public void Main()
        {

        }
    }

    public class Employee
    {
        private int _StaffId;
        private string _FullName;
        private DateTime _EmploymentDate;

        public int staffId {    get { return _StaffId;} }

        public string FullName { get { return _FullName;} }

        public DateTime dateTime { get { return _EmploymentDate;} }

        /// <summary>
        /// A method that displays when an employee checks in at work. 
        /// </summary>
        public void ClockIn()
        {
            _EmploymentDate = DateTime.Now;
            Console.WriteLine();
        }


    }
}
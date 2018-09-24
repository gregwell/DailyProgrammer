class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>() { 
                new Employee(5112, "John", 1000.34),
                new Employee(5113, "Kennedy", 20045.10),
                new Employee(5115, "John", 5000.23),
                new Employee(5116, "Anna", 32400.43)
            };
        }
    }
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public Employee(int _id, string _name, double _salary)
        {
            id = _id;
            name = _name;
            salary = _salary;
        }
    }

var empList = Employees.Where(emp => emp.name == "John");
           foreach(var emp in empList){
               Console.WriteLine(emp.id);
               // 5112
               // 5115
           }
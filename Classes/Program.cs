// See https://aka.ms/new-console-template for more information

Action<Object> cw = Console.WriteLine;

User user = new User();
user.Email = "user@gmail.com";
user.Name = "user real name";
user.Username = "user username";


Employee employee = new Employee();
employee.SetId("890");
employee.SetName("Jonh Doe");
employee.SetEmail("JonhDoe@gmail.com");
employee.SetUsername("JonhDoe");
employee.ViewData();

employee.salary = "10.000";
String salaryEmployee = employee.salary;
cw($"salary is = {salaryEmployee}");

// Manager manager = new Manager{Name = "Merapi"};
Manager manager = new Manager();
manager.SetId("897");
manager.SetName("Name Manager");
manager.SetUsername("UserName Manager");
manager.SetEmail("manager@gmail.com");
manager.IsActive(true);
manager.ViewData();








class Employee
{
    Action<Object> cw = Console.WriteLine;

    private String id;
    private String name;
    private String username;
    private String email;

    public String salary;

    public Employee(){}

    public Employee(String name, String username, String email, String id)
    {
        this.id = id;
        this.name = name;
        this.username = username;
        this.email = email;
    }

    public void SetId(String id) {
        this.id = id;
    }

    public void SetName(String name) {
        this.name = name;
    }

    public void SetUsername(String username) {
        this.username = username;
    }

    public void SetEmail(String email) {
        this.email = email;
    }

    public virtual void ViewData()
    {
        cw("From data view");
        cw($"employee name : {name}");
        cw($"employee username : {username}");
        cw($"employee email : {email}");
        cw($"employee id : {id}");
    }
}
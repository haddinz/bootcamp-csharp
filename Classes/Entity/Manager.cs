class Manager : Employee
{
    Action<Object> cw = Console.WriteLine;

    private Boolean active;

    public Manager(){}

    public void IsActive(Boolean active) {
        this.active = active;
    }

    public override void ViewData()
    {
        base.ViewData();
        cw($"manager active : {active}");
    }
}

class Calculator {
	
	private int number = 0;

	public Calculator() {}
	
	public Calculator(int n)
	{
		this.number = n;
	}
	
	public static Calculator operator + (Calculator Calc1, Calculator Calc2)
	{
		Calculator Calc3 = new Calculator(0);
		Calc3.number = Calc2.number + Calc1.number;
		return Calc3;
	}
	
	public void display()
	{
		Console.WriteLine("{0}", number);
	}
}


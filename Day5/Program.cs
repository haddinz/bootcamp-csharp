class Program {
    static void Main() {

        void GetSumProcessA(int value){
            Console.WriteLine($"Integer value is {value}");
        }
        void GetSumProcessB(int value){
            Console.WriteLine($"Integer value is {value}");
        }
        void GetSumProcessC(int value){
            Console.WriteLine($"Integer value is {value}");
        }

        
        DelegateProgram delegateProgram = new();
        delegateProgram.DelegateRun(GetSumProcessA, 90);
        delegateProgram.DelegateRun(GetSumProcessB, 90);
        delegateProgram.DelegateRun(GetSumProcessC, 90);

        // EventHandler eventHandler = new();
        // eventHandler.OnRaiseCustomEvent("");

        EventHandler eventHandler = new EventHandler();
        eventHandler.OnClick += () => Console.WriteLine("Event: Button was clicked!");

        eventHandler.Click();

        int[] numberArray = new int[]{3, 2, 1};
        TryCatchElement tryCatchElement = new TryCatchElement(numberArray);
        Console.WriteLine(tryCatchElement.TryCatchService());

        Calculator num1 = new();
		Calculator num2 = new(40);
		Calculator num3 = new();	
		
		num3 = num1 + num2;
		
		num1.display();
		num2.display();
		num3.display();

        IteratoService iteratoService = new();

        foreach(int i in iteratoService.SumList()) {
            Console.WriteLine(i);
        }
    }
}


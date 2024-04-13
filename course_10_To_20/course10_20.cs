using System;
using ProjectA.TeamA;

//namespace alliases directive
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
class course10_20
{
    static void Main()
    { 

        //PART 10
        //if statement
        Console.WriteLine("Plese enter a number");
        int userNumber = int.Parse(Console.ReadLine());

        //&&-> will check true for both conditions if 1st condition fails it wion't check other condition
        if(userNumber == 10 && userNumber == 20){
            Console.WriteLine("You enter number 10 or 20");
        }
        //&-> will check 2nd condition even if first condition is false
        else if(userNumber == 30 & userNumber == 40){
            Console.WriteLine("You enter number 30 or 40");
        }
        //||-> will check only first condition if its true it won't check 2nd condition
        else if(userNumber == 1 || userNumber == 2){
            Console.WriteLine("You enter number 1 or 2");
        }
        //|->if 1st condition is false it will also check the 2nd condition 
        else if(userNumber == 50 | userNumber == 60){
            Console.WriteLine("You enter number 50 or 60");
        }
        else{
        Console.WriteLine("You enter number other than 1, 2, 10, 20, 30, 40, 50, 60");
        }


        //PART 11
        //Switch statement
        Console.WriteLine("Plese enter a number between 1 to 5");
        int userNumber1 = int.Parse(Console.ReadLine());
        
        switch(userNumber1){
            case 1:
                Console.WriteLine("You enter numebr 1");
                break;
                //can also combine cases
            case 2:
            case 3:
            case 4:
                Console.WriteLine("You enter numebr {0}",userNumber1);
                break;
            case 5:
                Console.WriteLine("You enter numebr 5");
                break;  
            default:
                Console.WriteLine("You enter numer not in between 1 to 5");
                break;              
        }


        //PART 12
        int TotalCOffeeCost = 0;

        start:
        Console.WriteLine("Please enter your coffee size\n1: Small\n2: Medium\n3: Large");
        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice){
            case 1:
                TotalCOffeeCost += 1;
                break;
            case 2:
                TotalCOffeeCost += 2;
                break;  
            case 3:
                TotalCOffeeCost += 3;
                break;    
            default: 
                goto start;

        }
        string userDecision;
        Console.WriteLine("Do you want to buy another coffee?");
        userDecision = Console.ReadLine();

        switch(userDecision.ToUpper()){
            case "YES":
                goto start;
            case "NO":
                break;
            default:
                Console.WriteLine("You choice {0} is invalid!! Please try again...", userDecision);
                goto start;        
        }
        Console.WriteLine("Thank you for shopping here");
        Console.WriteLine("Your total bill is {0}", TotalCOffeeCost);

        //PART 13
        //While Loop
        string userChoiceForTarget = "";
        do{
            Console.WriteLine("Please enter your target: ");
            int userTarget = int.Parse(Console.ReadLine());
            int start = 0;

            //program will print even numbers
            while(start<=userTarget){
                    Console.WriteLine(start);
                    start = start + 2; //this is the terminatery condition if its not there then the while condition will always be true 
                    //as 0<10 always so while loop becomes infinite
                }

            //Part 14
            //do while loop
            
            do{
                Console.WriteLine("Do you wish to continue? Yes or No?");
                userChoiceForTarget = Console.ReadLine().ToUpper();

                if(userChoiceForTarget != "YES" && userChoiceForTarget != "NO")
                {
                    Console.WriteLine("Invalid Choice Please try again");
                }

            }while(userChoiceForTarget != "YES" && userChoiceForTarget != "NO");

        }while(userChoiceForTarget == "YES");

        //PART 16
        //For loop and for each loop
        int[] Numbers = new int[5];
        Numbers[0] = 100;
        Numbers[1] = 101;
        Numbers[2] = 102;
        Numbers[3] = 103;
        Numbers[4] = 104;

        foreach(int k in Numbers)
            Console.WriteLine(k);
        for(int i=0; i < Numbers.Length; i++)
        {
            Console.WriteLine(Numbers[i]);
        }

        //Continue statement
        for(int i=0; i<=10; i++){
            if(i%2==1)
                continue;   //continue will skip this statement next to it if the condition is true
            //when i%2==1 continue will move to the the for loop increment/decrement statement
            Console.WriteLine(i);    
        }

        //PART 16
        //instance Methods in C sharp
        course10_20 instance_method_of_oddNumbers = new course10_20();
        instance_method_of_oddNumbers.OddNumbers();

        //calling static method by class name without any instance
        course10_20.evenNumbers(10);
        course10_20.evenNumbers(5);

        //Part 17 
        //TYPES OF PARAMETERS
        // 1. Value PARAMETERS
        // 2. Reference PARAMETERS
        // 3. Output PARAMETERS
        // 4. PARAMETER Arrays

        //pass by value
        //both variables are pointing to d/f memory locations
        course10_20 change_Value = new course10_20();
        int new_Value = 19;
        change_Value.Pass_By_Value(new_Value);
        Console.WriteLine("New value of the parameter is {0}", new_Value);


        //pass by reference
        //both variables are pointing to same memory locations
        Pass_By_Reference(ref new_Value);
        Console.WriteLine("New value of the parameter is {0}", new_Value);


        //Output parameter
        //used when you want return more than one value
        Calculations(10,10, out int total, out int product);
        Console.WriteLine("Sum is {0} and Product is {1}", total, product);

        //paramters array
        //when you want to use optional parameters you use params keyword
        int[] ranNums = new int[3];
        ranNums[0] = 1;
        ranNums[1] = 2;
        ranNums[2] = 3;
        //ParameterMethod();//it wont give any error but will not print anything since we had not given it anything yet

        course10_20.ParameterMethod(ranNums);
        ParameterMethod(1,2,3,4,5,6,7,8,9,10);


        //PART 18
        //Namespace 
        PATA.ClassA.printA();
        //calling teamB of PRoject A
        //to avoid abmiguity we use aliases directive
        PATB.ClassA.printA();

        //PART 19
        //Class
        //calling constructor with instance of that class
        namePrinting n1 = new namePrinting();  //no parameter is given to the constructor
        n1.printNames();
        // namePrinting nm = new namePrinting("AMINA", "FAYYAZ");
        // nm.printNames();
        

        //PART 20
        //Class
        Circle c1 = new Circle(4);
        float r1 = c1.CalculateArea();
        Console.WriteLine("AREA {0}", r1);
    }
    //instance method in class course10_20
    public void OddNumbers(){
        for(int i=1; i<=31; i++){
            if(i%2!=0){
                Console.WriteLine(i);
            }
        }
    }

    //static method
    public static void evenNumbers(int target_for_evenNumbers){
        for(int i=0; i<=target_for_evenNumbers; i++){
            if(i%2==0){
                Console.WriteLine(i);
            }
        }
    }
    //pass by value parameter
    public void Pass_By_Value(int j){
        j=101;
    }
    //pass by reference parameter
    public static void Pass_By_Reference(ref int j){
        j=101;
    }
    //out parameter
    public static void Calculations(int x, int y, out int sum, out int product){
        sum = x + y;
        product = x * y;
    }

    //parameter arrays
    public static void ParameterMethod(params int[] ranNums) //params has to be the last parameter in the parameter list and can have only one parameter array
    {
        Console.WriteLine("The number of elements present in the params are {0}", ranNums.Length);
        foreach(int n in ranNums){
            Console.WriteLine(n);
        }
    }
}
    //namespaces
namespace ProjectA
{
        namespace TeamA
        {
            class ClassA
            {
                public static void printA()
                {
                    Console.WriteLine("Team A of ClassA Method");
                }
            }
        }
    }
//another namespace
namespace ProjectA
{
        namespace TeamB
        {
            class ClassA
            {
                public static void printA()
                {
                    Console.WriteLine("Team B of ClassA Method");
                }
            }
        }
    }    
    
//pasrt 19
//Class
class namePrinting{
    string firstName, lastName;
    //default constructor that takes no parameters
    public namePrinting(): this("No first name is provided and ", "No Last name is provided"){

    }
    //Constructor
    //constructor doesn't have any return type
    public namePrinting(string FirstName, string LastName){
        this.firstName = FirstName;
        this.lastName = LastName;
    }
    public void printNames(){
        Console.WriteLine("Full name is {0}", this.firstName + " " + this.lastName);
    }
    //destructor have no return type and no parameters
    //it is used to clean up the resources used by the class that wasa holding on to during its lifetime
    //clean class' objects from the memory
    // ~namePrinting(){

    // }
}

//PART 20
//static and instance class member
class Circle
{
    static float PI = 3.14F;
    float radius;
    //static constructor is called before any instance method is called
    static Circle(){
        Circle.PI = 3.14F;
    }
    //instance member is called each time
    public Circle(float r){
        this.radius = r;
    }
    public float CalculateArea(){
        return Circle.PI * this.radius * this.radius;
    }
    // public void printCircle(){
    //     System.out.print("Area of Circle is {0}", )
    // }
}


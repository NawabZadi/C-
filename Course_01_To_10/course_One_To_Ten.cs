using System;
using System.Reflection.Metadata;
class Introduction
{
    static void Main()
    { 
        //PART 1 AND PART 2
        Console.WriteLine("Type your first name");
        var firstName = Console.ReadLine();

        Console.WriteLine("Type your Second name");
        var lastName = Console.ReadLine();

        //placeholder method
        Console.WriteLine("hello {0} {1}", firstName, lastName);

        //concatenation method
        //Console.WriteLine("Hello " + firstName + " " + lastName);


        //PART 3
        //Built in data types
        // int i = 0;
        Console.WriteLine("MIN VALUE: {0}",int.MinValue);
        Console.WriteLine("MAX VALUE: {0}",int.MaxValue);

        double d = 1.38489344;
        Console.WriteLine("value of d= {0}",d);
        Console.WriteLine("MIN VALUE: {0}",double.MinValue);
        Console.WriteLine("MAX VALUE: {0}",double.MaxValue);


        //PArt 4
        //Escape Sequence
        string s = "\"AMINA\"";
        Console.WriteLine("My Name is: \n{0}",s);
        //double back slash = one back slash
        Console.Write("AMINA FAYYAZ HERE!!!\tI am CS Student\\learning CSHARP\n");

        //Verbatim Literal:  @->will consider escape sequence as a part of the string
        Console.WriteLine(@"C:\\MSDN\\C#\\Introduction.cs");

        //PART 5
        //OPERATORS IN C#
        // 1. Assignmet OPERATORS "="
        // 2. Arithematic OPERATORS "+, -, *, /, %"
        // 3. COmparison OPERATORS "==, !=, <, <=, >, >="
        // 4. Conditional OPERATORS "&&, ||"
        // 5. Ternary OPERATOR "?"
        // 6. Null Calescing Operator "??"

        int Num = 10, Num1 = 9;  
        int sum=0;
        sum = Num + Num1;
        Console.WriteLine("Sum is: {0}",sum);
 
        bool isNum10;
        if(Num == 10)
        {
            isNum10 = true;
        }
        else
        {
            isNum10 = false;
        }
        Console.WriteLine("Is Number 10: {0}", isNum10);

        if(Num == 10 && Num1 == 9)
        {
            Console.WriteLine("Hello");
        }

        isNum10 = Num == 15 ? true : false;
        Console.WriteLine("Number = 10 {0}", isNum10);

        
        //part 6
        //Nullable Types
        bool? IsStudentmajor = null;  //user did not answer means we give it default value as null
        if(IsStudentmajor == true){
            Console.WriteLine("Student is a Major");
        }
        else if(IsStudentmajor == false){
            Console.WriteLine("Student isn't a Major");
        }
        else{ //so this statement will run
            Console.WriteLine("User didn't answer");
        }


        //Null Coalescing Operator
        int? TicketsOnSale = 100;
        int AvailableTickets;

        if(TicketsOnSale == null){
            AvailableTickets = 0;
        }
        else{
           // AvailableTickets = TicketsOnSale;  ->error cant convert int? to int

           AvailableTickets = TicketsOnSale.Value;      //this works because Value property of Nullable
           //AvailableTickets = (int)TicketsOnSale;       //also works, but its type casting
        }
        Console.WriteLine("Available tickets: {0}", AvailableTickets);


        //There is another way to do the same but using null coalescing operator

        AvailableTickets = TicketsOnSale ?? 0;   //if TicketsOnSale has some value then use that otherwise use 0
        Console.WriteLine("Available tickets: {0}", AvailableTickets);
        //the above if-else statements aare reduced to just one line


        //PART 7
        //Type conversions in C#
        //Implicit conversion
        int num = 100;
        float f = num;
        Console.WriteLine(f);

        //Explicit casting
        float g = 345.23F;
        //convert using cast operartor
        int num1 = (int)g;   //will lose the decimal part 
        int num2 = Convert.ToInt16(g);
        Console.WriteLine("Value of Number after conversion: {0}", num1);
        Console.WriteLine("Value of Number after conversion: {0}", num2); //wont make any difference but we use convert class

        float anothernum = 12313434533335.23F;
        int num3 = (int)anothernum;   
        Console.WriteLine("Value of Number after conversion: {0}", num3);

        //int num4 = Convert.ToInt64(anothernum); ->overflow exception


        string strNumer = "1900fd";  //"1900dfd" throws exception
        //int strtonum = int.Parse(strNumer);   //method to convert string to an integer only converts numbers not text
        int strtonum = 0;
        bool IsConversionSuccessfull =  int.TryParse(strNumer, out strtonum); //"1900dfd" can't be converted so 0 value will be shown
        
        if(IsConversionSuccessfull){
                Console.WriteLine(strtonum);
        }
        else{
            Console.WriteLine("Please enter a valid number");
        }


        //Part 8
        //ARRAYS
        int[] EvenNums = new int[3];
        EvenNums[0] = 0;
        EvenNums[1] = 2;
        EvenNums[2] = 4;
        //Console.WriteLine(EvenNums[0]);
        for(int i=0; i<=2; i++){
            int res = EvenNums[i];
            Console.WriteLine(res);
        }
    }
}


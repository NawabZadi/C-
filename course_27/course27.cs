public class Program
{
    private static void Main()
    {
        //properties
        // 1. Read/Write (both get and set method)
        // 2. Read only (only get method)
        // 3. Write only (only set method)
        // 4. Auto Implemented properties
        //Properties->to protect fields from publically use
        Student student = new Student();
        // student.setID(101);  //if this id value is null or negative it will throw an exception
        // Console.WriteLine("ID of student is {0}", student.getID());

        //student.setName("");->throws an excerption of null name
        student._Name = "Amina Fayyaz";
        Console.WriteLine("name of student is {0}", student._Name);


        //read only property by only getter method without setting its value
        Console.WriteLine("Passing marks is {0}", student.getMarks);

        student.ID = 100;
        Console.WriteLine("ID of student is {0}", student.ID);

        student.email = "abc@gmail.com";
        Console.WriteLine("ID of student is {0}", student.email);

        student.city = "abc";
        Console.WriteLine("ID of student is {0}", student.city);

    }
}
public class Student{
    private int _ID;
    private string Name;
    private int passing_Marks = 33;  //passing marks criteria

    //we have to make get snd set method for these two private fields here we'll use auto implemented property
    // private string email;
    // private string city;

    //compiler will automatically create private fields for email and city
    public string email{
        set;
        get;
    }
    public string city{
        set;
        get;
    }
    //setter and getter to avoid null or negative values


    //property
    public int ID
    {
        set
        {
        if(value <= 0){
            throw new Exception("ID cannot be 0 or a negative number");
        }
        this._ID = value;
        }
        get{
            return this._ID;
        }
    }

    //getter and setter for name field
    //read/write property
    public string _Name
    {
        set{
             if(string.IsNullOrEmpty(value)){
            throw new Exception("Name cannnot be empty or null");
        }
        this.Name = value;
        }
        get{
             return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;
        }
    }
 
 //read only property
    public int getMarks
    {
        get{
           return this.passing_Marks;
        }
    }
}
public class Program
{
   public static void Main()
    {
        //Properties->to protect fields from publically use
        Student student = new Student();
        student.setID(101);  //if this id value is null or negative it will throw an exception
        Console.WriteLine("ID of student is {0}", student.getID());

        //student.setName("");->throws an excerption of null name
        student.setName("Amina Fayyaz");
        Console.WriteLine("Name of the student is {0}", student.getName());

        //read only property by only getter method without setting its value
        Console.WriteLine("Passing marks is {0}", student.getMarks());

    }
}
public class Student{
    private int ID;
    private string Name;
    private int passing_Marks = 33;  //passing marks criteria

    //setter and getter to avoid null or negative values
    public void setID(int _ID){
        if(_ID <= 0){
            throw new Exception("ID cannot be 0 or a negative number");
        }
        this.ID = _ID;
    }
    public int getID(){
        return this.ID;
    }

    //getter and setter for name field
    public void setName(string _Name){
        if(string.IsNullOrEmpty(_Name)){
            throw new Exception("Name cannnot be empty or null");
        }
        this.Name = _Name;
    }

    public string getName(){
        if(string.IsNullOrEmpty(this.Name)){
            return "No Name";
        }
        else{
            return this.Name;
        }
    }
    public int getMarks(){
       return this.passing_Marks;
    }
}
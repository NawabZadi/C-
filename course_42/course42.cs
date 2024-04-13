using System;
using System.IO;
using System.Runtime.Serialization;
public class Program
{
    public static void Main()
    {
        try{        
            throw new UserAlreadyLoggedInException("User is already logged in...");
        }
        catch(UserAlreadyLoggedInException ex){
            Console.WriteLine(ex.Message);
        }
    }
}
[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()  //communicating with base class uing base keyword
    {
        
    }
    public UserAlreadyLoggedInException(string message) : base(message)  //communicating with base class uing base keyword
    {

    }
    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)  //communicating with base class uing base keyword
    {
        
    }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)  //communicating with base class uing base keyword
    {
        
    }
}
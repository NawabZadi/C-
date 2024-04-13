using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_61
{
    public partial class patialCustomer
    {
    private string _firstName;
    private string _lastName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    }
}
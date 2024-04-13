using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_61
{
    public class partialCustomer
    {
     public string GetFullName()
    {
        return _firstName + ", " + _lastName;
    }
    }
}
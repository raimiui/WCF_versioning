using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcfService
{
    public class MyService : IMyService
    {
        public EmpInfo UpdateEmployeeData(EmpInfo info)
        {
            return info;
        }

        public EmpInfo GetEmployeeDatabyID(int EmpID)
        {
            if (EmpID == 1)
                //return new EmpInfo { EmpID = 1, EmpName = "Kausik" };
                return new EmpInfo { EmpID = 1, EmpName = "Kausik", EmpAddress = "Salt Lake" };
            else
                return null;
        }
    }
}

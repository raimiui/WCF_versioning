using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWCFService_Semi_Strict_Sample
{
    public class MyService_Semi_Strict : IMyService_Ver2
    {
        public EmpInfo UpdateEmployeeData(EmpInfo info)
        {
            return info;
        }

        public EmpInfo GetEmployeeDatabyID(int EmpID)
        {
            if (EmpID == 1)
                return new EmpInfo { EmpID = 1, EmpName = "Kausik" };
            else
                return null;
        }
    }
}

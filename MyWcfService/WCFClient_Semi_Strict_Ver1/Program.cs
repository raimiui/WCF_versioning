using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClient_Semi_Strict_Ver1.MySvcSemiStrict;

namespace WCFClient_Semi_Strict_Ver1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceAContractClient proxy = new ServiceAContractClient())  
            {
                
                var sc = proxy.UpdateEmployeeData(new EmpInfo { EmpID = 1, EmpName = "Kausik" });
                Console.WriteLine("Employee ID: " + sc.EmpID);
                Console.WriteLine("Employee Name: " + sc.EmpName);
                      
            }
            Console.ReadLine();  
        }
    }
}

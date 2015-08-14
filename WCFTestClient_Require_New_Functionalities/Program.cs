using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFTestClient_Require_New_Functionalities.MyService;
using System.Runtime.Serialization;

namespace WCFTestClient_Require_New_Functionalities
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceAContractClient proxy = new ServiceAContractClient())
            {
                var sc = proxy.UpdateEmployeeData(new EmpInfo { EmpID = 1, EmpName = "Kausik", EmpAddress="Salt Lake" });
                Console.WriteLine("Employee ID: " + sc.EmpID);
                Console.WriteLine("Employee Name: " + sc.EmpName);
                Console.WriteLine("Employee Address: " + sc.EmpAddress);

                
                
                //Implementing new functionalities in the client application
                sc = proxy.GetEmployeeDatabyID(1);
                Console.WriteLine("Retrieving Employee Details:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Employee ID: " + sc.EmpID);
                
            }
            Console.ReadLine();  
        }
    }
}

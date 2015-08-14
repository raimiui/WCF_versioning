using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClient_Semi_Strict_Ver2.MySvcSemiStrictV2;

namespace WCFClient_Semi_Strict_Ver2
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

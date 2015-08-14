using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClient_Strict_Ver2.MySvcStrict;

namespace WCFClient_Strict_Ver2
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

            using (ServiceAContract1Client proxy = new ServiceAContract1Client())
            {

                //Implementing new functionalities in the client application
                var mc = proxy.GetEmployeeDatabyID(1);
                Console.WriteLine("Retrieving Employee Details:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Employee ID: " + mc.EmpID);
        
            }

            Console.ReadLine();  
        }


        }
    }

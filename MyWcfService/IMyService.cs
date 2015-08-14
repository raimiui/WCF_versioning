using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcfService
{
   
    [ServiceContract(Name = "ServiceAContract", Namespace = "http://www.mynamespace.com/samples/2012/03")] 
    public interface IMyService
    {
        [OperationContract]
        EmpInfo UpdateEmployeeData(EmpInfo info);

        //Adding new method 
        [OperationContract]
        EmpInfo GetEmployeeDatabyID(int EmpID);
    }

    
    [DataContract(Name = "EmpInfo",Namespace="http://schemas.mynamespace.com/samples/2012/03")] 
    public class EmpInfo
    {
        [DataMember]
        public int EmpID;
        [DataMember]
        public string EmpName;
        //Adding new non-required members  
        [DataMember(IsRequired = false)]
        public string EmpAddress;
       
    }
}


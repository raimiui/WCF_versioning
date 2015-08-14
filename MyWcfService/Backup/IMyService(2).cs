using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWCFService_Semi_Strict_Sample
{
    [ServiceContract(Name = "ServiceAContract", Namespace = "http://www.mynamespace.com/samples/2012/03")]
    public interface IMyService
    {
        [OperationContract]
        EmpInfo UpdateEmployeeData(EmpInfo info);

    }

    [ServiceContract(Name = "ServiceAContract", Namespace = "http://www.mynamespace.com/samples/2012/04")]
    public interface IMyService_Ver2 : IMyService
    {
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
        
    }
}

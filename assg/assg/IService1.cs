using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace assg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAddEmpRecords
    {
        [OperationContract]
        string AddEmployee(string id, string name);


        [OperationContract]
        int delete(string id);

        [OperationContract]
    Employee AddRemarks(string id, string remarks);

    }
     [ServiceContract]
    public interface IRetrieveDetails
    {
        [OperationContract]
        Employee Search(string id);

        [OperationContract]
        IEnumerable<Employee> GetAllDetails();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Remarks { get; set; }
    }

}

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
         Remarks AddRemarks(string id, string remarks);

        [OperationContract]
        void ClearAllData();

    }
     [ServiceContract]
    public interface IRetrieveDetails
    {
        [OperationContract]
        Employee Search(string id);

        [OperationContract]
        Employee SearchByName(string name);

        [OperationContract]
        IEnumerable<Employee> GetAllDetails();

        [OperationContract]
        IEnumerable<Remarks> GetAllRemarks();

        [OperationContract]
        string GetNameFromId(string id);

        [OperationContract]
        IEnumerable<Remarks> GetRemarks(string id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]

    public class Employee
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Id { get; set; }

    }

    [DataContract]
    public class Remarks {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Remark { get; set; }
        [DataMember]
        public DateTime GetDateTime { get; set; }
    }

}

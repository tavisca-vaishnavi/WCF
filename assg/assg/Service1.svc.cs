using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace assg
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Service1 : IAddEmpRecords, IRetrieveDetails
    {
         public List<Employee> EmpList = new List<Employee>();
         public List<Remarks> RemarkList = new List<Remarks>();
         public string AddEmployee(string id, string name)
         {
             Employee emp = new Employee();
            
            
             
                 foreach (Employee e in EmpList)
                 {
                     if (e.Id.Equals(id))
                         throw new FaultException(new FaultReason("Id Already Exists"), new FaultCode("103"));
                 }
                 emp.Id = id;
                 emp.Name = name;
                 EmpList.Add(emp);
                 return "Added Record";
             
         }

        public Remarks AddRemarks(string id, string remarks)
        {
            Remarks remark = new Remarks();
            foreach (Employee e in EmpList)
            {
                if (e.Id.Equals(id))
                {
                    //e.Remarks = remarks;
                   
                    remark.Id = id;
                    remark.Remark = remarks;
                    remark.GetDateTime = DateTime.Now;
                    RemarkList.Add(remark);
                    return remark;
                }
            }
            throw new FaultException(new FaultReason("Employee Record Not Found For Inserting Remarks"), new FaultCode("102"));
        }

        public Employee Search(string id)
        {
            Employee emp = new Employee();
            foreach (Employee e in EmpList)
            {
                if (e.Id.Equals(id))
                    return e;
            }

            throw new FaultException(new FaultReason("Employee Record Not Found"), new FaultCode("101"));
        }

        public string GetNameFromId(string id) {
            Employee emp = new Employee();
            foreach (Employee e in EmpList)
            {
                if (e.Id.Equals(id))
                    return e.Name;
            }
            return null;
        }
        public IEnumerable<Remarks> GetRemarks(string id) {
            Remarks rem = new Remarks();
            return RemarkList.Where(remark => remark.Id == id).ToList();
        }
        public int delete(string id)
        {
            foreach (Employee e in EmpList)
            {
                if (e.Id.Equals(id))
                {
                    EmpList.Remove(e);
                    return 1;
                }
            }
            return 0;
        }

        public Employee SearchByName(string name)
        {
            Employee emp = new Employee();
            foreach (Employee e in EmpList)
            {
                if (e.Name.Equals(name))
                    return e;
            }

            throw new FaultException(new FaultReason("Employee Record of this name Not Found"), new FaultCode("105"));
        }

        IEnumerable<Employee> IRetrieveDetails.GetAllDetails()
        {
            return EmpList;
        }

        IEnumerable<Remarks> IRetrieveDetails.GetAllRemarks()
        {
            return RemarkList;
        }


        public void ClearAllData() { 
            EmpList.Clear();
        }
    }
}

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

         public string AddEmployee(string id, string name)
         {
             Employee emp = new Employee();
             id = id.Trim();
             if (id == null || id == "")
             {
                 throw new FaultException(new FaultReason("Id Null Not Allowed"), new FaultCode("104"));
             }
             else
             {
                 foreach (Employee e in EmpList)
                 {
                     if (e.id.Equals(id))
                         throw new FaultException(new FaultReason("Id Already Exists"), new FaultCode("103"));
                 }
                 emp.id = id;
                 emp.Name = name;
                 EmpList.Add(emp);
                 return ("Added Record");
             }
         }

        public Employee AddRemarks(string id, string remarks)
        {
           
            foreach (Employee e in EmpList)
            {
                if (e.id.Equals(id))
                {
                    e.Remarks = remarks;
                    return e;
                }
            }
            throw new FaultException(new FaultReason("Employee Record Not Found For Inserting Remarks"), new FaultCode("102"));
        }

        public Employee Search(string id)
        {
            Employee emp = new Employee();
            foreach (Employee e in EmpList)
            {
                if (e.id.Equals(id))
                    return e;
            }

            throw new FaultException(new FaultReason("Employee Record Not Found"), new FaultCode("101"));
        }


        public int delete(string id)
        {
            foreach (Employee e in EmpList)
            {
                if (e.id.Equals(id))
                {
                    EmpList.Remove(e);
                    return 1;
                }
            }
            return 0;
        }
        IEnumerable<Employee> IRetrieveDetails.GetAllDetails()
        {
            return EmpList;
        }

        public void ClearAllData() { 
            EmpList.Clear();
        }
    }
}

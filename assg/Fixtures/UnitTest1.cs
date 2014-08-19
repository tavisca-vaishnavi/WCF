using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assg;
using Fixtures.myservice;
using System.ServiceModel;
using System.Collections.Generic;

namespace Fixtures
{
    [TestClass]
    public class Fixture
    {
        AddEmpRecordsClient client = new AddEmpRecordsClient();
        RetrieveDetailsClient client2 = new RetrieveDetailsClient();
        [TestMethod]
        public void CheckEmployeeExist()
        {
            Employee emp = new Employee();
            int len = client2.GetAllDetails().Count;
            try
            {
                client.AddEmployee("72", "Vaish");
                client.AddEmployee("72", "Vaishu");
            }
            catch (FaultException e)
            {
                Assert.AreEqual(1, client2.GetAllDetails().Count);
            }
            finally {
                client.ClearAllData();
            }
           
        }
        [TestMethod]
        public void CheckNullId()
        {
            Employee emp = new Employee();
           
            int len = client2.GetAllDetails().Count;
            try
            {
                client.AddEmployee("", "AAA");
            }
            catch (FaultException e)
            {
                Assert.AreEqual(len, client2.GetAllDetails().Count);
            }
            finally
            {
                client.ClearAllData();
            }
        }
        [TestMethod]
        public void IdNotExists()
        {
            Employee emp = null;
            try
            {
                emp = client2.Search("10");
            }
            catch (FaultException e)
            {
                if (e.Code.Name == "101")
                {
                    Console.WriteLine("{0}", e.Reason);
                    Assert.AreEqual("Employee Record Not Found", e.Reason.ToString());
                    Assert.IsNull(emp);
                }
            }
            finally
            {
                client.ClearAllData();
            }
        }
        
        [TestMethod]
        public void SearchExistingId()
        {
            Employee e = new Employee();
            client.AddEmployee("1", "AAA");
            e = client2.Search("1");
            Assert.AreEqual(e.Id, "1");
            client.ClearAllData();
        }
        
        [TestMethod]
        public void AddRecordTest()
        {
            string result;
            result = client.AddEmployee("51", "Vaish");
            Assert.AreEqual("Added Record", result);
            client.ClearAllData();
        }
        
        [TestMethod]
        public void AddRemarksTest()
        {
            Employee test = null;
            Remarks remark = new Remarks();
            client.AddEmployee("112", "Vaishnavi");
            test = client.AddRemarks("112", "good");
            Assert.IsNotNull(test);
            client.ClearAllData();
        }

        [TestMethod]
        public void DeleteTest()
        {
            client.AddEmployee("110", "Vaish");
            int val = client.delete("110");
            Assert.AreEqual(1, val);
        }
        [TestMethod]
        public void SearchByNameTest()
        {
            Employee e = new Employee();
            client.AddEmployee("1111", "AAA");
            e = client2.SearchByName("AAA");
            Assert.AreEqual(e.Name, "AAA");
            client.ClearAllData();
        }
        [TestMethod]
        public void AddRemarkForNotExistingId()
        {
            try {
                Employee eForRemarks = new Employee();
                eForRemarks = client.AddRemarks("2", "good");
            }
            catch (FaultException e) {
                if (e.Code.Name == "102")
                {
                    Console.WriteLine("{0}", e.Reason);
                    Assert.AreEqual("Employee Record Not Found For Inserting Remarks", e.Reason.ToString());
                    
                }
            }
        }
        [TestMethod]
        public void SearchForNotExistingNameTest() {
            Employee emp = null;
            try
            {
                emp = client2.SearchByName("BBB");
            }
            catch (FaultException e)
            {
                if (e.Code.Name == "105")
                {
                    Console.WriteLine("{0}", e.Reason);
                    Assert.AreEqual("Employee Record of this name Not Found", e.Reason.ToString());
                    Assert.IsNull(emp);
                }
            }
        }
        [TestMethod]
        public void GetDetailsTest() {
            List<Employee> AllEmpDetails = new List<Employee>();
            AllEmpDetails = client2.GetAllDetails();
            Assert.IsNotNull(AllEmpDetails);
        }
    }
}

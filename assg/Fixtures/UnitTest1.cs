using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assg;
using Fixtures.myservice;
using System.ServiceModel;

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
            int len = client2.GetAllDetails().Length;
            try
            {
                client.AddEmployee("72", "Vaish");
                client.AddEmployee("72", "Vaishu");
            }
            catch (FaultException e)
            {
                Assert.AreEqual(1, client2.GetAllDetails().Length);
            }
            finally {
                client.ClearAllData();
            }
           
        }
        [TestMethod]
        public void CheckNullId()
        {
            Employee emp = new Employee();
            int len = client2.GetAllDetails().Length;
            try
            {
                client.AddEmployee("", "AAA");
            }
            catch (FaultException e)
            {
                Assert.AreEqual(len, client2.GetAllDetails().Length);
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
            Assert.AreEqual(e.id, "1");
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
    }
}

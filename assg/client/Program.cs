using client.myservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            AddEmpRecordsClient client = new AddEmpRecordsClient();
            RetrieveDetailsClient client2 = new RetrieveDetailsClient();
            string choice;
            string result;
            int ch;
            do
            {
                Console.WriteLine("************ MENU *************");
                Console.WriteLine("1. Add Records");
                Console.WriteLine("2. Search Records");
                Console.WriteLine("3. Add Remarks to Records");
                Console.WriteLine("4. Get All Records");
                Console.WriteLine("5. Delete");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your Choice:");
                choice = Console.ReadLine();
                bool output = Int32.TryParse(choice, out ch);

                switch (ch)
                {
                    case 1:
                        //Add Records
                        Console.WriteLine("Enter Id");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        try
                        {
                            result = client.AddEmployee(id, name);
                            Console.WriteLine(result);

                        }
                        catch (FaultException e)
                        {
                            if (e.Code.Name == "103")
                            {
                                Console.WriteLine("{0}", e.Reason);
                            }
                            if (e.Code.Name == "104")
                            {
                                Console.WriteLine("{0}", e.Reason);
                            }

                        }
                        break;

                    case 2:
                        //search records
                        Console.WriteLine("Enter Id");
                        string idForSearch = Console.ReadLine();
                        Employee SearchedEmp = new Employee();
                        try
                        {
                            SearchedEmp = client2.Search(idForSearch);
                            if (SearchedEmp != null)
                            {
                                Console.WriteLine("Required Emp ID " + SearchedEmp.Id);
                                Console.WriteLine("Required Emp Name " + SearchedEmp.Name);
                                // Console.WriteLine("Required Emp Remarks " + SearchedEmp.Remarks);
                            }
                        }
                        catch (FaultException e)
                        {
                            if (e.Code.Name == "101")
                            {
                                Console.WriteLine("{0}", e.Reason);
                            }
                        }
                        break;

                    case 3:
                        //Add Remarks To Records

                        Console.WriteLine("Enter Employee Id");
                        string idForRemarks = Console.ReadLine();
                        Console.WriteLine("Enter Remarks");
                        string remarks = Console.ReadLine();
                        Remarks e_obj = new Remarks();
                        Employee emp = new Employee();
                        e_obj.GetDateTime = DateTime.Now;
                        try
                        {
                            e_obj = client.AddRemarks(idForRemarks, remarks);
                            string nameForRemarks = client2.GetNameFromId(idForRemarks);
                            if (e_obj != null)
                            {
                                Console.WriteLine("Emp ID " + e_obj.Id);
                                Console.WriteLine("Emp Name " + nameForRemarks);
                                Console.WriteLine("Emp Remarks " + e_obj.Remark);
                                Console.WriteLine("Remarks Added On : " + e_obj.GetDateTime);
                            }
                        }
                        catch (FaultException ex)
                        {
                            if (ex.Code.Name == "102")
                            {
                                Console.WriteLine("{0}", ex.Reason);
                            }
                        }
                        break;

                    case 4:
                        //Get All Records
                        Console.WriteLine("***** All Records *****");
                        List<Employee> AllEmpDetails = new List<Employee>();
                        List<Remarks> AllRemarkDetails = new List<Remarks>();
                        //string remarkForSelectedEmployee;
                        AllEmpDetails = client2.GetAllDetails();

                        foreach (Employee e1 in AllEmpDetails)
                        {
                            Console.WriteLine("Emp ID " + e1.Id);
                            Console.WriteLine("Emp Name " + e1.Name);
                            List<Remarks> remarksList = client2.GetRemarks(e1.Id);
                            foreach (Remarks rem in remarksList)
                            {
                                Console.WriteLine("Emp Remarks "+rem.Remark);
                                Console.WriteLine("Time " + rem.GetDateTime);
                            }
                            //Console.WriteLine("Emp ID" + e1.Remarks);
                        }
                        break;

                    case 5:
                        //Delete Record
                        Console.WriteLine("Enter Id to delete Record");
                        string idToDelete = Console.ReadLine();
                        int del = client.delete(idToDelete);
                        if (del == 1)
                            Console.WriteLine("Successfully Deleted");
                        else
                            Console.WriteLine("Failed to Delete Record");
                        break;
                }
            } while (ch != 6);
        }
    }
}

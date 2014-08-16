using client.myservice;
using System;
using System.Collections.Generic;
using System.Linq;
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
                        string result = client.AddEmployee(id, name);
                        Console.WriteLine(result);
                        break;

                    case 2:
                        //search records
                        Console.WriteLine("Enter Id");
                        string idForSearch = Console.ReadLine();
                        Employee SearchedEmp = new Employee();
                        SearchedEmp = client2.Search(idForSearch);
                        if (SearchedEmp != null)
                        {
                            Console.WriteLine("Required Emp ID " + SearchedEmp.id);
                            Console.WriteLine("Required Emp Name " + SearchedEmp.Name);
                            Console.WriteLine("Required Emp Remarks " + SearchedEmp.Remarks);
                        }
                        else
                            Console.WriteLine("No Records Found");
                        break;

                    case 3:
                        //Add Remarks To Records
                        Console.WriteLine("Enter Employee Id");
                        string idForRemarks = Console.ReadLine();
                        Console.WriteLine("Enter Remarks");
                        string remarks = Console.ReadLine();
                        Employee e_obj = new Employee();
                        e_obj = client.AddRemarks(idForRemarks, remarks);
                        if (e_obj != null)
                        {
                            Console.WriteLine("Emp ID" + e_obj.id);
                            Console.WriteLine("Emp ID" + e_obj.Name);
                            Console.WriteLine("Emp ID" + e_obj.Remarks);
                        }
                        break;

                    case 4:
                        //Get All Records
                        Console.WriteLine("***** All Records *****");
                        List<Employee> AllEmpDetails = new List<Employee>();
                        AllEmpDetails = client2.GetAllDetails();
                        foreach (Employee e1 in AllEmpDetails)
                        {
                            Console.WriteLine("Emp ID" + e1.id);
                            Console.WriteLine("Emp ID" + e1.Name);
                            Console.WriteLine("Emp ID" + e1.Remarks);
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








            //Added
            //string result=client.AddEmployee("101", "drux");
            //Console.WriteLine(result);
            //search
            Employee e = new Employee();
            //e = client2.Search("101");
            //if (e != null)
            //{
            //    Console.WriteLine("Emp ID" + e.id);
            //    Console.WriteLine("Emp ID" + e.Name);
            //    // Console.WriteLine("Emp ID" + e.Remarks);
            //}

            //all details
            //List<Employee> AllEmpDetails = new List<Employee>();
            //AllEmpDetails = client2.GetAllDetails();
            //foreach (Employee e1 in AllEmpDetails)
            //{
            //    Console.WriteLine("Emp ID" + e1.id);
            //    Console.WriteLine("Emp ID" + e1.Name);
            //    Console.WriteLine("Emp ID" + e1.Remarks);
            //}

            ////Add Remarks
            //Employee e_obj = new Employee();
            //e_obj = client.AddRemarks("101", "very poor");
            //if (e != null)
            //{
            //    Console.WriteLine("Emp ID" + e_obj.id);
            //    Console.WriteLine("Emp ID" + e_obj.Name);
            //    Console.WriteLine("Emp ID" + e_obj.Remarks);
            //}

            //delete
            //int del = client.delete("101");
            //Console.WriteLine("deleted");

           
        }
    }
}

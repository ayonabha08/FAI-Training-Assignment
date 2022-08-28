﻿using System;

namespace AssignmentSolution
{
    namespace CustomerRecords
    {
        class Customer
        {
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Address { get; set; }
        }
    }

    namespace Repository
    {
        using CustomerRecords;
        class CustomerRepo
        {
            public CustomerRepo(int size)//constructor
            {
                _customers = new Customer[size];
            }
            private Customer[] _customers = null;//null for reference types

            public void AddNewCustomer(Customer customer)
            {
                //find the first occurance of null in the array
                for (int i = 0; i < _customers.Length; i++)
                {
                    if (_customers[i] == null)
                    {
                        _customers[i] = new Customer
                        {
                            CustomerID = customer.CustomerID,
                            CustomerName = customer.CustomerName,
                            Address = customer.Address,
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No more customers can be added here!!!");
            }

            public void UpdateBook(int id, Customer customer)
            {
                //find the first occurance of null in the array
                for (int i = 0; i < _customers.Length; i++)
                {
                    if (_customers[i] != null && _customers[i].CustomerID == id)
                    {
                        _customers[i] = new Customer
                        {
                            CustomerID = customer.CustomerID,
                            CustomerName = customer.CustomerName,
                            Address = customer.Address,
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No customer was found to Update!!!");
            }

            public void DeleteCustomer(int id)
            {
                //Iterate thru the array
                for (int i = 0; i < _customers.Length; i++)
                {
                    //find the matching book with id and non null
                    if (_customers[i] != null && _customers[i].CustomerID == id)
                    {
                        //set it to null. U cannot delete an object in .NET. 
                        _customers[i] = null;//Informal Deletion
                        //exit the function.
                        return;
                    }
                }
            }

            public Customer FindCustomer(int id)
            {
                foreach (Customer customer in _customers)
                {
                    if (customer.CustomerID == id)
                        return customer;
                }
                throw new Exception("No customer was found by id " + id);
            }
        }
    }

    namespace UserInterface
    {
        using CustomerRecords;
        /// <summary>
        /// Helper class to take inputs from the User based on the questions asked.
        /// </summary>
        class Util
        {
            public static string GetString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            public static int GetNumber(string question)
            {
                return int.Parse(GetString(question));
            }
            public static short GetShortNumber(string question) => short.Parse(GetString(question));

            public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
        }

        class UIClass
        {
            private static Repository.CustomerRepo repo = null;
            const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~CUSTOMER REPOSTORE MANAGER~~~~~~~~~~~~~~~~~~~~~~~\nTO ADD NEW CUSTOMER------------>PRESS N\nTO UPDATE CUSTOMER------------->PRESS U\nTO REMOVE A CUSTOMER----------->PRESS D\nTO FIND BY ID-------------->PRESS F\nPS: ANY OTHER KEY IS EXIT.............................................";
            static void Main(string[] args)
            {
                int size = Util.GetNumber("Enter the no of Customers in the records");
                repo = new Repository.CustomerRepo(size);
                var processing = true;
                do
                {
                    string choice = Util.GetString(menu);
                    processing = processMenu(choice);
                } while (processing);
            }

            private static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "N"://for adding
                        addingCustomerFeature();
                        break;
                    case "D"://for deleting
                        deletingCustomerFeature();
                        break;
                    case "U"://for updating
                        updatingCustomerFeature();
                        break;
                    case "F"://finding by id
                        findingByIdFeature();
                        break;
                    default:
                        return false;
                }
                return true;
            }

            private static void findingByIdFeature()
            {
                //take id from the user
                int id = Util.GetNumber("Enter the Id of the customer to find");
                //call the repo function
                var foundCustomer = repo.FindCustomer(id);
                if (foundCustomer != null)
                {
                    //display the book details 
                    Console.WriteLine($"The Name of the customer is {foundCustomer.CustomerName} ID: {foundCustomer.CustomerID} who resides in {foundCustomer.Address}");
                }
                else
                {
                    Console.WriteLine("Customer Record not found to display!!!!");
                }
            }

            private static void updatingCustomerFeature()
            {
                //take inputs from the user
                var c = createCustomer();
                //call the add method of the repo and pass the book into it. 
                repo.UpdateBook(c.CustomerID, c);
                //display the message
                Console.WriteLine("Customer Record updated successfully");
            }

            private static Customer createCustomer()
            {
                int id = Util.GetNumber("Enter the Id of the customer ");
                string name = Util.GetString("Enter the name ");
                string address = Util.GetString("Enter the address ");
                //create the new book object
                Customer c = new Customer
                {
                    CustomerID = id,
                    CustomerName = name,
                    Address = address,                         
                };
                return c;
            }
            private static void deletingCustomerFeature()
            {
                //Ask the user to enter the id of the book
                int id = Util.GetNumber("Enter the Id of the customer to remove");
                //call the Repo's function to delete
                repo.DeleteCustomer(id);
                //display the message
                Console.WriteLine("Book deleted Successfully");
            }

            private static void addingCustomerFeature()
            {
                //take inputs from the user
                Customer c = createCustomer();
                //call the add method of the repo and pass the book into it. 
                repo.AddNewCustomer(c);
                //display the message
                Console.WriteLine("Customer added successfully");
            }
        }
    }
}
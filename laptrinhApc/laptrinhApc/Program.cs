using laptrinhApc.session4;
using System;
using System.Collections.Generic;


namespace laptrinhApc.demo4

{
    public class Program
    {
        public static void Main(string[] args) {
            voidStringDelegate vsd = new voidStringDelegate(DemoDelegate.Goodbye);
            vsd("xin chao");
            voidStringDelegate vsd1 = new voidStringDelegate(new DemoDelegate().SayHello);
            vsd("hello");

            var t2 = new DemoDelegate();
            t2.SayHello("T2210A");
            DemoDelegate.Goodbye("T2210A");

            

            DisplayMessage("Hello world", DemoDelegate.Goodbye);

            voidStringDelegate vsd2 = new voidStringDelegate (new DemoDelegate().SayHello);
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2("T2210A");
            DisplayMessage("Hello world", DemoDelegate.Goodbye);
            void StringDelegate vsd3 = delegate (string e)
            {
                Console.WriteLine(e);   
            }
        }
        static void DisplayMessage(string message, voidStringDelegate.callback)
        {
            callback(message);
        }









     /*   public static void Main(String[] args)
        {
            Teacher t = new Teacher();
            t.Tels.Add("5840594");
            t.Tels.Add("1234567");
            Console.WriteLine(t.Tels);
            t[0] = "34564758";
        }


        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            while (true)
            {
                Console.WriteLine("1. Add Vietnamese Customer");
                Console.WriteLine("2. Add Foreign Customer");
                Console.WriteLine("3. Display Invoices");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        customers.Add(AddVietnameseCustomer());
                        break;
                    case 2:
                        customers.Add(AddForeignCustomer());
                        break;
                    case 3:
                        DisplayInvoices(customers);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        static VietnameseCustomer AddVietnameseCustomer()
        {
            Console.Write("Customer Code: ");
            string code = Console.ReadLine();
            Console.Write("Full Name: ");
            string name = Console.ReadLine();
            Console.Write("Invoice Date (dd/mm/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Customer Type: ");
            string type = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            return new VietnameseCustomer
            {
                CustomerCode = code,
                FullName = name,
                InvoiceDate = date,
                CustomerType = type,
                Quantity = quantity,
    
            };
        }

        static ForeignCustomer AddForeignCustomer()
        {
            Console.Write("Customer Code: ");
            string code = Console.ReadLine();
            Console.Write("Full Name: ");
            string name = Console.ReadLine();
            Console.Write("Invoice Date (dd/mm/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nationality: ");
            string nationality = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            return new ForeignCustomer
            {
                CustomerCode = code,
                FullName = name,
                InvoiceDate = date,
                Nationality = nationality,
                Quantity = quantity,
               
            };
        }

        static void DisplayInvoices(List<Customer> customers)
        {
            Console.WriteLine("Invoices:");
            foreach (var customer in customers)
            {
                double totalAmount = customer.CalculateTotalAmount();
                Console.WriteLine($"Customer: {customer.FullName}, Total Amount: {totalAmount}");
                
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }*/
    }
}

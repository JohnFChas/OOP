using OOPTenta.Filters;
using OOPTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta.Managers
{
    class Manager : IManager
    {
        event EventHandler CustomerTooYoung;

        public List<Customer> Customers { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Manager()
        {
            CustomerTooYoung += delegate
            {
                Console.WriteLine("Customer needs to be 18 or older");
            };

            Customers = new List<Customer>
            {
                new Customer { Name = "John", Email = "email@email.com", Age = 12 },
                new Customer { Name = "Sara", Email = "email@email.com", Age = 12 },
                new Customer { Name = "Adam", Email = "email@email.com", Age = 12 },
                new Customer { Name = "Lisa", Email = "email@email.com", Age = 12 },
                new Customer { Name = "Peter", Email = "email@email.com", Age = 12 }
            };

            Tickets = new List<Ticket>
            {
                new Ticket { Buyer = Customers[0], Price = 100 },
                new Ticket { Buyer = Customers[1], Price = 150 },
                new Ticket { Buyer = Customers[2], Price = 150 },
                new VIPTicket { Buyer = Customers[3], Price = 300, VipLevel = 4 },
                new VIPTicket { Buyer = Customers[4], Price = 200, VipLevel = 2 }
            };
        }

        public void AddCustomer()
        {
            Console.Clear();

            var newCustomer = new Customer();

            Console.Write("Name: ");
            newCustomer.Name = Console.ReadLine();

            Console.Write("Email: ");
            newCustomer.Email = Console.ReadLine();

            Console.Write("Age: ");
            newCustomer.Age = int.Parse(Console.ReadLine());

            Customers.Add(newCustomer);

            Console.WriteLine("Customer {0} added", newCustomer.Name);
        }

        public void BookTicket()
        {
            Console.WriteLine("Select customer:");
            for (int i = 0; i < Customers.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Customers[i].Name);
            }

            var index = int.Parse(Console.ReadLine()) - 1;

            if (Customers[index].Age < 18)
            { 
                CustomerTooYoung.Invoke(this, EventArgs.Empty);
                return;
            }

            Console.Write("VIP Ticket? (y/n): ");
            var vip = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
            int vipLevel = 1;

            if (vip)
            { 
                Console.Write("VIP Level: ");
                vipLevel = int.Parse(Console.ReadLine());
            }

            var newTicket = vip ? new VIPTicket { VipLevel = vipLevel } : new Ticket();

            newTicket.Buyer = Customers[index];

            Console.Write("Ticket price: ");
            newTicket.Price = float.Parse(Console.ReadLine());

            Tickets.Add(newTicket);

            Console.WriteLine("Ticket booked for {0}, price was {1}", newTicket.Buyer.Name, newTicket.Price);
        }

        public void SearchCustomer()
        {
            Console.Write("Customer name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Results:");
            foreach (var customer in Customers.Where(c => c.Name.ToLower().Contains(name.ToLower())))
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine("\t{0}'s tickets:", customer.Name);

                foreach (var ticket in Tickets.Where(t => String.Equals(t.Buyer.Name, customer.Name)))
                {
                    Console.WriteLine("\t{0}", ticket.PrintInfo());
                }
            }
        }

        public void Filter()
        {
            Console.WriteLine("1. Premium deluxe tickets (price of 500 or more)");
            Console.WriteLine("2. VIP tickets");

            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    PrintWhere(TicketFilters.IsPremiumDeluxe);
                    break;

                case 2:
                    Console.Write("Minimum VIP level: ");
                    var minLevel = int.Parse(Console.ReadLine());

                    PrintWhere((ticket) =>
                    {
                        if (ticket.GetType() != typeof(VIPTicket))
                            return false;

                        return ((VIPTicket)ticket).VipLevel >= minLevel;
                    });
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private void PrintWhere(TicketFilter filter)
        {
            foreach (var ticket in Tickets)
            {
                if (filter(ticket))
                    Console.WriteLine(ticket.PrintInfo());
            }
        }
    }
}

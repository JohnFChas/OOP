using Labb3.Models;
using Labb3.Models.Events;
using Labb3.Models.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Runtime
    {
        public void Start()
        {
            List<Event> events = new List<Event>();

            events.AddRange(new Event[]
            {
                new Movie
                {
                    Name = "The Matrix",
                    Start = DateTime.Now,
                    Length = 120,
                    Type = Event.EventType.Movie
                },
                new Concert
                {
                    Name = "Up the irons",
                    Start = DateTime.Now,
                    Artist = "Iron Maiden",
                    Type = Event.EventType.Concert
                }
            });

            List<MovieTicket> movieTickets = new List<MovieTicket>();
            List<ConcertTicket> concertTickets = new List<ConcertTicket>();

            movieTickets.AddRange(new MovieTicket[]
            {
                new MovieTicket { Movie = new Movie { Name = "The movie", Start = DateTime.Now, Length = 120 } }
            });

            concertTickets.AddRange(new ConcertTicket[]
            {
                new ConcertTicket { Concert = new Concert { Name = "The concert", Start = DateTime.Now, Artist = "Dude with guitar" } }
            });

            // Print movie tickets
            foreach (var ticket in movieTickets)
            {
                Console.WriteLine("{0} has booked a ticket for the movie {1}, length: {2}",
                    ticket.Person,
                    ticket.Movie.Name,
                    ticket.Movie.Length);
            }

            // Print concert tickets
            foreach (var ticket in concertTickets)
            {
                Console.WriteLine("{0} has booked a ticket for the concert {1} by the artist {2}",
                    ticket.Person,
                    ticket.Concert.Name,
                    ticket.Concert.Artist);
            }

            #region Type casting
            //List<Ticket> tickets = new List<Ticket>();

            //tickets.AddRange(new Ticket[]
            //{
            //    new Ticket { Event = events[0], Person = "John" },
            //    new Ticket { Event = events[1], Person = "Anna" }
            //});

            //// Print movie tickets
            //foreach (var ticket in tickets.Where(t => t.Event.Type == Event.EventType.Movie))
            //{
            //    Console.WriteLine("{0} has booked a ticket for the {1} {2}, length: {3}",
            //        ticket.Person,
            //        ((Movie)ticket.Event).Type.ToString(),
            //        ((Movie)ticket.Event).Name,
            //        ((Movie)ticket.Event).Length);
            //}

            //// Print concert tickets
            //foreach (var ticket in tickets.Where(t => t.Event.Type == Event.EventType.Concert))
            //{

            //}
            #endregion
        }
    }
}

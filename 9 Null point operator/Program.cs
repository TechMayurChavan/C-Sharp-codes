using System;
namespace MyProgram {
    class Program{
        static void Main(string [] args){
            int AvailableTickets;
            int ? TicketsOnSale=5;
            AvailableTickets=TicketsOnSale ?? 0;
            Console.WriteLine(" availableTickets:"+"  " + AvailableTickets);
  
        }
    }
}


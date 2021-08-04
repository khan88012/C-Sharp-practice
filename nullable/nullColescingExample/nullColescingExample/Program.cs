using System;

namespace nullColescingExample
{
    class Program
    {
        static void Main(string[] args)
        {
      //code without null coalescing Operator
      Console.WriteLine("without coalescing");

      int AvailableTickets;
      int? TicketsOnSale = null;
      //TicketsOnSale = 8;

      if (TicketsOnSale == null)
      {
        AvailableTickets = 0;
      }
      else
      {
        AvailableTickets = (int)TicketsOnSale;
      }

      Console.WriteLine("Available Tickets={0}", AvailableTickets);




      //code with null coalescing Operator  ( ??  )
      Console.WriteLine("with coalescing");

      int availableTickets;
      int? ticketonsale = null;
      //ticketonsale = 34;
      availableTickets = ticketonsale ?? 0;// if the ticketonsale is null then 0 otherwise ticketonsale has whatever integer value         will be assigned ot availableTickets
      Console.WriteLine("Available Tickets={0}", availableTickets);

    }
  }
}

using System;

namespace Expert
{
    public class ConsolePrinter
    {
        public static void PrintTicket(SaleTicket ticket)
        {
            Console.WriteLine(ticket.GetTicketText());
        }
    }
}
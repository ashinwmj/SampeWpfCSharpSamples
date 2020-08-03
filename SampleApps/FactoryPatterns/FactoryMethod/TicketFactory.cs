using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.FactoryMethod
{
    /// <summary>
    /// Factory to create ticket objects
    /// </summary>
    public class TicketFactory
    {
        public static ITicket CreateTicket(TicketType ticketType)
        {
            ITicket ticket = null;
            switch (ticketType)
            {
                case TicketType.Ordinary:
                    ticket = new OrdinaryTicket();
                    break;
                case TicketType.Tatkal:
                    ticket = new TatkalTicket();
                    break;
            }

            return ticket;
        }
    }

    public enum TicketType
    {
        Ordinary,
        Tatkal
    }

  
}

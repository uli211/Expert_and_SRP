//----------------------------------------------------------------------------
// <copyright file="SaleTicket.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Expert
{
    public class SaleTicket
    {
        private ArrayList lineItems = new ArrayList();

        public DateTime DateTime { get; set; }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (TicketLineItem item in this.lineItems)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        public void AddLineItem(TicketLineItem item)
        {
            this.lineItems.Add(item);
        }

        public void RemoveLineItem(TicketLineItem item)
        {
            this.lineItems.Remove(item);
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Fecha: {this.DateTime}");
            foreach (TicketLineItem item in this.lineItems)
            {
                item.PrintTicketLine();
            }

            Console.WriteLine($"Total: ${this.Total}");
        }
    }
}
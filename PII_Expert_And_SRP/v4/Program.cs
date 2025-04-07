//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Expert
{
    public class Program
    {
        private static ArrayList productCatalog = new ArrayList();

        public static void Main(string[] args)
        {
            PopulateCatalog();

            SaleTicket ticket = new SaleTicket();
            ticket.DateTime = DateTime.Now;
            ticket.AddLineItem(new TicketLineItem(1, ProductAt(0)));
            ticket.AddLineItem(new TicketLineItem(2, ProductAt(1)));
            ticket.AddLineItem(new TicketLineItem(3, ProductAt(2)));
            ConsolePrinter.PrintTicket(ticket);
        }

        private static void PopulateCatalog()
        {
            AddProductToCatalog("Product 1", 100.00);
            AddProductToCatalog("Product 2", 200.00);
            AddProductToCatalog("Product 3", 300.00);
        }

        private static void AddProductToCatalog(string description, double price)
        {
            productCatalog.Add(new ProductSpecification(description, price));
        }

        private static ProductSpecification ProductAt(int index)
        {
            return productCatalog[index] as ProductSpecification;
        }
    }
}

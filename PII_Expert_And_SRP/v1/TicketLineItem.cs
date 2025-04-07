//--------------------------------------------------------------------------------
// <copyright file="TicketLineItem.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Expert
{
    public class TicketLineItem
    {
        public TicketLineItem(double quantity, ProductSpecification product)
        {
            this.Quantity = quantity;
            this.Product = product;
        }

        public double Quantity { get; set; }

        public ProductSpecification Product { get; set; }
    }
}
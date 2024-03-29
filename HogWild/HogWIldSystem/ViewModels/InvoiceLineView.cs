﻿namespace HogWIldSystem.ViewModels
{
    public class InvoiceLineView
    {
        public int InvoiceLineID { get; set; }
        public int InvoiceID { get; set; }
        public int PartID { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Taxable { get; set; }
        public decimal ExtentPrice => Price * Quantity;
        public bool RemoveFromViewFlag { get; set; }
    }
}

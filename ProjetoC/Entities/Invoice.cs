﻿using System.Globalization;
namespace Course.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTa: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

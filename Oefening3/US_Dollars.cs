using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class US_Dollars
    {
        public double amount { get; set; }

        public US_Dollars(double amount)
        {
            this.amount = amount;
        }

        public US_Dollars()
        {
        }

        public override string ToString()
        {
            return amount.ToString();
        }
    }

    internal class Euro : US_Dollars
    {
        public double in_eur;
        public Euro(double amount) : base(amount)
        {
            in_eur = amount * 1.03;
        }

        public override string? ToString()
        {
            return in_eur.ToString();
        }
    }

    internal class Pound : US_Dollars
    {
        public double in_pound;
        public Pound(double amount) : base(amount)
        {
            in_pound = amount * 0.90;
        }

        public override string? ToString()
        {
            return in_pound.ToString();
        }
    }

    internal class Yen : US_Dollars
    {
        public double in_yen;
        public Yen(double amount) : base(amount)
        {
            in_yen = amount * 145.34;
        }

        public override string? ToString()
        {
            return in_yen.ToString();
        }
    }

    internal class Frank : US_Dollars
    {
        public double in_frank;
        public Frank(double amount) : base(amount)
        {
            in_frank = amount * 0.99;
        }

        public override string? ToString()
        {
            return in_frank.ToString();
        }
    }

    internal class Rupees : US_Dollars
    {
        public double in_rupees;
        public Rupees(double amount) : base(amount)
        {
            in_rupees = amount * 82.83;
        }

        public override string? ToString()
        {
            return in_rupees.ToString();
        }
    }
}

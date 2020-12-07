using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace S10V137_Impostos.Entities
{
    abstract class Contribuinte
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();

        public override string ToString()
        {
            return Name + " $ " + Imposto().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

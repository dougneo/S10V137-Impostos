namespace S10V137_Impostos.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string name, double rendaAnual, double gastoSaude)
            : base(name, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000)
                return (RendaAnual * 0.15) - (GastoSaude * 0.5);
            else
                return (RendaAnual * 0.25) - (GastoSaude * 0.5);
        }
    }
}

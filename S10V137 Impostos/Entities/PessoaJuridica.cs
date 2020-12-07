namespace S10V137_Impostos.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string name, double rendaAnual, int funcionarios)
            : base(name, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            if (Funcionarios > 10)
                return RendaAnual * 0.14;
            else
                return RendaAnual * 0.16;
        }
    }
}

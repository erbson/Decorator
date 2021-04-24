using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ISS : Imposto
    {

        public ISS(Imposto outroImposto) : base(outroImposto) { }

        
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        private double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }

    }
}

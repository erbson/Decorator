using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ImpostoAlto : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20;
        }
    }
}

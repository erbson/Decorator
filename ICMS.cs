using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ICMS : Imposto
    {
       
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }
    }
}

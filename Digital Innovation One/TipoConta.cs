using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Innovation_One
{
    class TipoConta
    {
        public static TipoConta PessoaFisica { get; internal set; }

        public static explicit operator TipoConta(int v)
        {
            throw new NotImplementedException();
        }
    }
}

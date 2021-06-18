using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeTesteMoq
{
    public interface Interface_pessoa
    {
        (string pessoa, int idade) Calcular(string pessoa, int a, int b);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDePerformance03.Models;

namespace TesteDePerformance03
{
    public interface IPessoaRepository
    {
        IEnumerable<PessoaModel> GetAll();
        void Adicionar(PessoaModel novaPessoaModel);

    }
}

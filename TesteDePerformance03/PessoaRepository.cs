using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDePerformance03.Models;

namespace TesteDePerformance03
{
    public class PessoaRepository
    {
        public static List<PessoaModel> ListaPessoas { get; set; } = new List<PessoaModel>();
                

        public List<PessoaModel> GetAll()
        {
            return ListaPessoas;
        }

        public PessoaModel GetById(int id)
        {
            var pessoa = ListaPessoas.FirstOrDefault(x => x.Id == id);

            return pessoa;
        }

        public List<PessoaModel> ProcurarPorNome(string nome)
        {
            var resultado = ListaPessoas.Where(x => x.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));

            return resultado.ToList();
        }

        public void Adicionar(PessoaModel pessoaModelNova)
        {
            ListaPessoas.Add(pessoaModelNova);
        }

        public void Atualizar(PessoaModel pessoaModelAtualizada)
        {
            var pessoaModel = GetById(pessoaModelAtualizada.Id);

            pessoaModel.Nome = pessoaModelAtualizada.Nome;
        }

        public void Deletar(int id)
        {
            var removePessoa = GetById(id);

            ListaPessoas.Remove(removePessoa);
        }

        
    }
}

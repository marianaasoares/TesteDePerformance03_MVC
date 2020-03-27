using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDePerformance03.Models;

namespace TesteDePerformance03
{
    public class PessoaRepository
    {
        public static List<PessoaModel> listaPessoas { get; set; } = new List<PessoaModel>();
                

        public List<PessoaModel> GetAll()
        {
            return listaPessoas;
        }

        public PessoaModel GetById(int id)
        {
            var pessoa = listaPessoas.FirstOrDefault(x => x.Id == id);

            return pessoa;
        }

        public List<PessoaModel> ProcurarPorNome(string nome = null)
        {
            listaPessoas = GetAll();
            if (!string.IsNullOrWhiteSpace(nome))
            {
                listaPessoas = listaPessoas.Where(x => x.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));

            }

            return listaPessoas.ToList();
        }

        public void Adicionar(PessoaModel pessoaModelNova)
        {
            listaPessoas.Add(pessoaModelNova);
        }

        public void Atualizar(PessoaModel pessoaModelAtualizada)
        {
            var pessoaModel = GetById(pessoaModelAtualizada.Id);

            pessoaModel.Nome = pessoaModelAtualizada.Nome;
        }

        public void Deletar(int id)
        {
            var removePessoa = GetById(id);

            listaPessoas.Remove(removePessoa);
        }

        
    }
}

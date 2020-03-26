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
            var pessoa = listaPessoas.FirstOrDefault(x => x.id == id);

            return pessoa;
        }

        public List<PessoaModel> procurarPorNome(string nome)
        {
            var resultado = listaPessoas.Where(x => x.nome.Contains(nome.ToLower())).ToList();

            return resultado;
        }

        public void adicionar(PessoaModel pessoaModelNova)
        {
            listaPessoas.Add(pessoaModelNova);
        }

        public void atualizar(PessoaModel pessoaModelAtualizada)
        {
            var pessoaModel = GetById(pessoaModelAtualizada.id);

            pessoaModel.nome = pessoaModelAtualizada.nome;
        }

        public void deletar(int id)
        {
            var removePessoa = GetById(id);

            listaPessoas.Remove(removePessoa);
        }
    }
}

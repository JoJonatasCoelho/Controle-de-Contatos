using Primeiro_Site.Data;
using Primeiro_Site.Models;

namespace Primeiro_Site.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {   
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
           _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges(); 
           return contato;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}

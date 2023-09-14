using Primeiro_Site.Models;

namespace Primeiro_Site.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);    
        
        
    }
}

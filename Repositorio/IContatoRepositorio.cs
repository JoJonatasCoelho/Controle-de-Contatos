using Primeiro_Site.Models;

namespace Primeiro_Site.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);    
        ContatoModel Atualizar(ContatoModel contato);
        
        
    }
}

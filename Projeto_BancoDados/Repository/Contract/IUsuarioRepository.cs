using Projeto_BancoDados.Models;

namespace Projeto_BancoDados.Repository.Contract
{
    public interface IUsuarioRepository
    {
        //CRUD
        IEnumerable<Usuario> ObterTodosUsuarios();
        void CadastrarUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        Usuario ObterUsuario(int  id);
    }
}

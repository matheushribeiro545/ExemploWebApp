using Exemplo.WebApp.MVC.Models;

namespace Exemplo.WebApp.MVC.Services;

public interface IAutenticacaoService
{
    Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);

    Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);
}
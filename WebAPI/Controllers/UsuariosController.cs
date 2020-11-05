using System.Threading.Tasks;
using Aplicacion.Seguridad;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
  public class UsuariosController : CustomControllerBase
  {
    [HttpPost("login")]
    public async Task<ActionResult<Usuario>> Login(Login.Ejecuta parametros)
    {
      return await mediator.Send(parametros);
    }
  }
}

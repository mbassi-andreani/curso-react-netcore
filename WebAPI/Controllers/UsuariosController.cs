using System.Threading.Tasks;
using Aplicacion.Seguridad;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
  public class UsuariosController : CustomControllerBase
  {
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<ActionResult<UsuarioData>> Login(Login.Ejecuta parametros)
    {
      return await mediator.Send(parametros);
    }
  }
}

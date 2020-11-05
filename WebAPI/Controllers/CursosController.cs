using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Cursos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
  //[Route("api/[controller]")]
  [ApiController]
  public class CursosController : CustomControllerBase
  {
    [HttpGet]
    public async Task<ActionResult<List<Curso>>> Get() {
      return await mediator.Send(new Consulta.ListaCursos());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Curso>> Detalle(int id) {
      return await mediator.Send(new ConsultaId.CursoUnico() {
        Id = id
      });
    }

    [HttpPost]
    public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data) {
      return await mediator.Send(data);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Unit>> Editar(int id, Editar.Ejecuta data) {
      data.CursoId = id;
      return await mediator.Send(data);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> Borrar(int id) {
      return await mediator.Send(new Borrar.Ejecuta {
        CursoId = id
      });
    }
  }
}
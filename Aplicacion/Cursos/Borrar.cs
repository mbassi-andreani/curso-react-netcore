using System;
using System.Threading;
using System.Threading.Tasks;
using Aplicacion.ManejadorError;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class Borrar
    {
        public class Ejecuta : IRequest
        {
            public int CursoId {get; set;}
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly CursosOnlineContext _context;
            public Manejador(CursosOnlineContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var curso = await _context.Curso.FindAsync(request.CursoId);
                if(curso == null) {
                    throw new ManejadorExcepcion(System.Net.HttpStatusCode.NotFound,new { curso = "No se encontró el curso a borrar"});
                }
                _context.Curso.Remove(curso);
                var resultado = await _context.SaveChangesAsync(cancellationToken); //0 no se hizo una transacción, 1 se hizo 1 transaccion
                if(resultado > 0) {
                    return Unit.Value;
                }
                throw new ManejadorExcepcion(System.Net.HttpStatusCode.InternalServerError,new { curso = "No se borró el Curso"});
            }
        }
    }
}

/*

            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                
            }
*/
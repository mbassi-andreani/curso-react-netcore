using System;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            /*
                public byte[] FotoPortada {get; set;}
                public Precio PrecioPromocion {get; set;}
                public ICollection<Comentario> Comentarios {get; set;}
                public ICollection<CursoInstructor> InstructoresLink {get;set;}
            */
            public int CursoId {get; set;}
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public DateTime? FechaPublicacion { get; set; }
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
                if(curso != null) {
                    curso.Titulo = request.Titulo ?? curso.Titulo;
                    curso.Descripcion = request.Descripcion ?? curso.Descripcion;
                    curso.FechaPublicacion = request.FechaPublicacion ?? curso.FechaPublicacion;
                } else {
                    throw new Exception("No se encontró el curso a actualizar");
                }
                var resultado = await _context.SaveChangesAsync(cancellationToken); //0 no se hizo una transacción, 1 se hizo 1 transaccion
                if(resultado > 0) {
                    return Unit.Value;
                }
                throw new Exception("No se actualizó el Curso");
            }
        }
    }
}

/*

            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                
            }
*/
using System;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            /*
                public byte[] FotoPortada {get; set;}
                public Precio PrecioPromocion {get; set;}
                public ICollection<Comentario> Comentarios {get; set;}
                public ICollection<CursoInstructor> InstructoresLink {get;set;}
            */
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaPublicacion { get; set; }
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
                await _context.Curso.AddAsync(new Curso{
                    Titulo = request.Titulo,
                    Descripcion = request.Descripcion,
                    FechaPublicacion = request.FechaPublicacion
                });
                var resultado = await _context.SaveChangesAsync(cancellationToken); //0 no se hizo una transacción, 1 se hizo 1 transaccion
                if(resultado > 0) {
                    return Unit.Value;
                }
                throw new Exception("No se guardó el Curso");
            }
        }
    }
}

/*

            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                
            }
*/
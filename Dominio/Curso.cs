using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Curso
    {
        /*
        CursoId int NOT NULL PRIMARY KEY,
Titulo varchar(20),
Descripcion varchar(100),
FechaPublicacion datetime,
FotoPortada varchar(max)
        */
        public int CursoId {get; set;}
        public string Titulo {get; set;}
        public string Descripcion {get; set;}
        public DateTime? FechaPublicacion {get; set;}
        public byte[] FotoPortada {get; set;}
        public Precio PrecioPromocion {get; set;}
        public ICollection<Comentario> Comentarios {get; set;}
        public ICollection<CursoInstructor> InstructoresLink {get;set;}
    }
}
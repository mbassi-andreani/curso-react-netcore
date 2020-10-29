using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Precio
    {
        /*
        CREATE TABLE Precio (
PrecioId int NOT NULL PRIMARY KEY,
PrecioActual numeric(10,2),
Promocion numeric(10,2),
CursoId int FOREIGN KEY REFERENCES Curso(CursoId)
);
        */
        public Guid PrecioId {get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioActual {get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal Promocion {get; set;}
        public Guid CursoId {get; set;}
        public Curso Curso {get; set;}
    }
}
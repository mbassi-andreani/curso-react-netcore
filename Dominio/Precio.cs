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
        public int PrecioId {get; set;}
        public decimal PrecioActual {get; set;}
        public decimal Promocion {get; set;}
        public int CursoId {get; set;}
        public Curso Curso {get; set;}
    }
}
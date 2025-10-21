using System;

namespace GaleriadeArte
{
    public class Escultura
    {
        public int Id { get; set; }              // Identificador �nico
        public string Titulo { get; set; }       // Nombre de la obra
        public string Autor { get; set; }        // Creador de la escultura
        public double Precio { get; set; }       // Precio en moneda
        public string Estado { get; set; }       // Activo / Inactivo
        public DateTime FechaIngreso { get; set; } // Fecha de ingreso al inventario

        public string Tipo { get; set; }         // Tipo de escultura (ej: Moderna, Cl�sica...)
        public double Altura { get; set; }       // Altura en cm o m
        public double Volumen { get; set; }      // Volumen en cm� o m�
        public string Material { get; set; }     // Material principal (madera, bronce, etc.)
    }
}

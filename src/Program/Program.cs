using System;
using System.ComponentModel.DataAnnotations;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector_Archivo leer = new Lector_Archivo();
            Tablero tablero_1 = new Tablero(leer.ReadArchive());
            Imprimir_Tablero imprimir = new Imprimir_Tablero();
            imprimir.Imprimir(tablero_1);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista("Alumnos");

            lista.InsertarUltimo(15);
            lista.InsertarUltimo("Socorrito");
            lista.InsertarUltimo("Natasha");
            lista.InsertarPrimero("Claudia Marissa");
            Console.WriteLine(lista.BorrarUltimo() + " ha sido borrada de la lista.");
            lista.BorrarPrimero();
            lista.Imprimir();
        }
    }
}
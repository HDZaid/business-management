﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto2
{
    public class Lector : Usuario
    {
        public Lector(string iD = null, string nombre = null, string password = null) : base()
        {
            this.Rol = "Lector";
            if (iD == null)
            {
                Console.Write("Ingrese el nombre: ");
                ID = Console.ReadLine();
            }
            else
            {
                ID = iD;
            }

            if (nombre == null)
            {
                Console.Write("Ingrese el nombre: ");
                Name = Console.ReadLine();
            }
            else
            {
                Name = nombre;
            }

            if (password == null)
            {
                Console.Write("Ingrese la contraseña: ");
                Password = Console.ReadLine();
            }
            else
            {
                Password = password;
            }
        }
        /*
        public override void MostrarUsuario()
        {
            Console.WriteLine("Información del usuario:");
            base.MostrarUsuario();
            if (LibroLigado != null)
            {
                Console.WriteLine("Libro ligado:");
                LibroLigado.MostrarLibro();
            }
            else
            {
                Console.WriteLine("Este usuario no ha alquilado un libro.");
            }
        }
        //Lo unico que hara es llevarse el libro, no administrar la lista LeL
        public override void SolicitarLibro(Libro libroPrestar) 
        {
            libroPrestar.AumentarContadorPrestamo();
            this.LibroLigado = libroPrestar;
        }
        public override void DevolverLibro() 
        {
            
            this.LibroLigado = null;
        }
        */

    }
}

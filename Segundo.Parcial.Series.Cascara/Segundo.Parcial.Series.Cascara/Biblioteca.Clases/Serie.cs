﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Serie
    {
        private string genero;
        private string nombre;

        public Serie()
        { 
        }

        public Serie(string genero, string nombre)
        {
            this.genero = genero;
            this.nombre = nombre;
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return $"-Nombre: {nombre} -Genero: {genero}";
        }
    }
}

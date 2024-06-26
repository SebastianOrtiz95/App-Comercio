﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set;}
        public string imagenUrl { get; set; }
        public decimal precio { get; set; }
        public Categoria categoria { get; set; }
        public Marca marca { get; set; }

        public Articulos()
        {
            marca = new Marca();
            categoria = new Categoria();
        }
    }
    
}

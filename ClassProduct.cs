using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestionProductos
{
    public class ClassProduct
    {
        private int Codigo;
        private string Nombre;
        private float Precio;
        private int Inventario;
        private List<string> Clientes = new List<string>();

        public ClassProduct(int id, string nombre, float precio, int Inventario, List<string> Clientes){
            Codigo = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Inventario = Inventario;
            this.Clientes = Clientes;
        }

        public void mostrarProduct(){
        string tablaUsuario =
            "\n\n" +
            "".PadRight(30) +
            "\tCódigo".PadRight(20) +
            "Nombre".PadRight(20) +
            "Precio".PadRight(20) +
            "Stock\n".PadRight(20) +
            "Clientes\n" +
            "".PadRight(30) +        
            "______________________________________________________________________________________________\n";            
            
            tablaUsuario+=
                "".PadRight(30) +
                $"\t{this.Codigo}".PadRight(20) + 
                $"{this.Nombre}".PadRight(20) +
                $"{this.Precio}".PadRight(20) +
                $"{this.Inventario}\n".PadRight(20) +
                $"{string.Join("-",this.Clientes)}";
                ;
            
            ;
        }
    }
}
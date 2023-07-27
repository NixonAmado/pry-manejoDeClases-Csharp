
using System;
using System.Collections.Generic;
using System.Threading;

 namespace gestionProductos
 {

class Program {
    static Dictionary <long,ClassProduct> DicProductos = new Dictionary <long,ClassProduct>(); 
    
    static void Main() {
        bool continuar = true;
        do
        {
            MostrarMenu();
            Console.Write("Ingrese una opcion: ");
            if (int.TryParse(Console.ReadLine(), out int option))
            {
               switch(option)
               {
                    case 1: 
                        AgregarProducto();
                        break;
                    
                    case 2: 

                        //MostrarUsuario();
                        Thread.Sleep(5000);
                        break;
                    
                    case 3: 
                       
                        //MostrarUsuarios();
                        break;
                    
                    case 4: 
                       
                        //EliminarUsuario();
                        break;
    
                    case 5:
                        continuar = false;
                        break;
    
                    default:
                        //Console.Write("Press <Enter> to exit... ");
                        Console.WriteLine("Elija Opción entre 1 y 5");
                        Console.ReadKey();
                        //while (Console.ReadKey().Key != ConsoleKey.Enter) {}
                        break;
               }
            }
            else{
                Console.WriteLine("Por favor, ingrese una opcion valida");
                Console.ReadKey();
            }
                
        } while (continuar == true);


    }
    static void MostrarMenu(){
        Console.Clear();
        Console.WriteLine("".PadRight(50) + "************************************************ ");
        Console.WriteLine("".PadRight(50) + "                       Menu                      ");
        Console.WriteLine("".PadRight(50) + "************************************************ ");
        Console.WriteLine("".PadRight(50) + "       1. Agregar nuevo producto                 ");
        Console.WriteLine("".PadRight(50) + "       2. Mostrar detalles del producto          ");
        Console.WriteLine("".PadRight(50) + "       3. Mostrar todos los productos            ");
        Console.WriteLine("".PadRight(50) + "       4. Actualizar precio del producto         ");
        Console.WriteLine("".PadRight(50) + "       5. Actualizar listado de clientes         ");
    }
    
  
    



    static void AgregarProducto(){
        Console.Write("Ingresar numero de identificacion: ");
        if (!long.TryParse(Console.ReadLine(), out long numeroId))
        {
            Console.WriteLine("Ingrese un numero id valido");
        }
        
        Console.Write("Ingresar el nombre del producto: ");
        if (!long.TryParse(Console.ReadLine(), out long nombreProducto))
        {
            Console.WriteLine("No se aceptan numeros, por favor introduzca solo caracteres de string");
        }

        Console.Write("Ingresar el precio del producto: ");
        if (!float.TryParse(Console.ReadLine(), out float precioProducto))
        {
            Console.WriteLine("No se aceptan caracteres de string, por favor introduzca solo números");
        }

        Console.Write("Inventario del producto: ");
        if (!int.TryParse(Console.ReadLine(), out int inventario))
        {
            Console.WriteLine("No se aceptan caracteres de string ni numeros flotantes, por favor, introduzca solo numeros enteros");
        }
        
        Console.Write("Ingrese el numero de clientes: ");
        if (!int.TryParse(Console.ReadLine(), out int clientesNum))
        {
            Console.WriteLine("No se aceptan caracteres de string ni numeros flotantes, por favor, introduzca solo numeros enteros");
        }

        int contador = 0;
        List<string> ListaClientes = new List<string>(); 
        while(contador < clientesNum )
        {
            contador++;
            Console.Write($"Ingrese el cliente N°{contador}: ");
            string? cliente = Console.ReadLine();
            ListaClientes.Add(cliente ?? "");
        }
    
    Console.WriteLine(string.Join(" ", ListaHobbies));
    // Usuario NuevoUsuario = new Usuario(numeroId,nombre,edad,ListaHobbies);
    
    // DicUsuarios.Add(numeroId,NuevoUsuario);
    // Console.WriteLine(string.Join(" ", DicUsuarios));
    }
    
    
    
    
    // static void MostrarUsuario(){
        
    //     Console.Write("Ingresar id del usuario que desea ver : ");
    //     long IdVerUsuario = Convert.ToInt64(Console.ReadLine());
    //     //ICollection<int> claves = DicUsuarios.Keys;
        
    //     if (DicUsuarios.ContainsKey(IdVerUsuario))
    //     {
            
    //      //   tablaUsuario+=
    //         // "".PadRight(30) +
    //         // $"\t{IdVerUsuario}".PadRight(20) + 
    //         // $"{DicUsuarios[IdVerUsuario].nombre}".PadRight(20) +
    //         // $"{DicUsuarios[IdVerUsuario].edad}".PadRight(20) +
    //         // $"{string.Join("-", DicUsuarios[IdVerUsuario].hobbies)}";
            
    //         Console.WriteLine(tablaUsuario);
            
    //     }else{
    //         Console.WriteLine("no exite");
    //     }
    // }
    
    
    // static void MostrarUsuarios(){
    //      string tablaUsuario =
    //      "".PadRight(30) +
    //     "\tID".PadRight(20) +
    //     "NOMBRE".PadRight(20) +
    //     "EDAD".PadRight(20) +
    //     "HOBBIES\n" +
    //     "".PadRight(30) +
    //     "______________________________________________________________________________________________\n";
    //     |
    //     foreach(var key in DicUsuarios.Keys)
    //     {
    //         // tablaUsuario+=
    //         // "".PadRight(30) +
    //         // $"\t{key}".PadRight(20) + 
    //         // $"{DicUsuarios[key].nombre}".PadRight(20) +
    //         // $"{DicUsuarios[key].edad}".PadRight(20) +
    //         // $"{string.Join("-", DicUsuarios[key].hobbies)}\n";
            
    //     }
    //     Console.WriteLine(tablaUsuario);
    //     Thread.Sleep(5000);
    // }            
    
    // static void EliminarUsuario()
    // {
    //     MostrarUsuarios();
    //     Console.Write("ID usuario a eliminar: ");
    //     long EliminarId = Convert.ToInt64(Console.ReadLine());
    //     DicUsuarios.Remove(EliminarId);
    // }
    
        
    }
 }



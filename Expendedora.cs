using System;
using System.Threading;

namespace ExpendedoraBase
{
    public class Expendedora
    {
        string marca;
        byte temperatura;
        string codigo;
        float precio;
        public Expendedora(){
            Saludar();
            marca = "AMS";
            Console.WriteLine("Marca " + marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.WriteLine("Temperatura:" + temperatura + "°C");
            ControlarTiempoDisplay();
            codigo=MostrarCodigoDeProducto();
            ControlarTiempoDisplay();
            MostrarPrecio(codigo);
        }
        void Saludar(){
            Console.WriteLine("Bienvenido...");
        }
        string MostrarCodigoDeProducto(){ 
            Console.WriteLine("A1:Kinder Delice \tB2:Doritos \tC3:Donitas ");
            Console.Write("Ingresa el codigo del producto que quieres:");
            string codigo = Console.ReadLine(); //Variable Local...
            return codigo;
        }
        void MostrarPrecio(string codigo){
            switch (codigo){
                case "A1":
                    Console.WriteLine("El precio es:{0}", precio);
                    break;
                case "B2":
                    Console.WriteLine("El precio es:{0}", precio);
                    break;
                case "C3":
                    Console.WriteLine("El precio es:{0}", precio);
                    break;
                default:
                    Console.WriteLine("Producto no reconocido...");
                    break;
            }
        }
        void ControlarTiempoDisplay(){
            Thread.Sleep(2000);
            Console.Clear();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeAdopcioon
{
    class CentroDeAdopcion
    {
        static void Main(string[] args)
        {
            
        Boolean Salida = false;


        List<Adoptar> adoptars = new List<Adoptar>();

            while(Salida == false)
            {

                Console.WriteLine("Ingresa el numero de adopcion");
                long Num = Byte.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el Tipo de Mascota");
                Console.WriteLine("Perro");
                Console.WriteLine("Gato");
                Console.WriteLine("Otro");
                String mas = Console.ReadLine();

                Console.WriteLine("Peso (solo medida en kilogramos con punto decimal)");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Altura (metros con punto decimal)");
                double alt = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Nombre del animal");
                string nombre = Console.ReadLine();

                adoptars.Add(new Adoptar(Num,mas,peso,alt,nombre));

                for (int I = 0; I < adoptars.Count; I++)
                {
                    long na = adoptars[I].GetNuneroAdopcion();
                    string m = adoptars[I].GetMascota();
                    double p = adoptars[I].GetPeso();
                    double a = adoptars[I].GetAltura();
                    string n = adoptars[I].GetNombre();

                    Console.WriteLine("Numero de Adopcion: "+ na + ", Tipo de mascota: " + m + ", Peso: " + p + ", Altura: " +a+", Nombre de la mascota: "+n);
                    


                }

                string respuesta;
                Console.WriteLine("¿Desea Salir?");
                respuesta = Console.ReadLine();
                if (respuesta == "s" || respuesta == "si" || respuesta == "Si" || respuesta == "SI" || respuesta == "sI")
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Muy bien sigamos");
                }
            }

        }
    }
}

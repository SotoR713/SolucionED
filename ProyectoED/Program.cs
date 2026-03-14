namespace ProyectoED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            nombres[0] = "Juan";
            nombres[1] = "María";
            nombres[2] = "Pedro";
            nombres[3] = "Ana";
            nombres[4] = "Luis";
            //nombres[5] = "Carlos"; // Esto causará un error de índice fuera de rango

            // Imprimir el primer nombre
            //            Console.WriteLine(nombres[0]);

            //imprimir el segundo nombre utilizando una variable
            //          string segundoNombre = nombres[1];
            //           Console.WriteLine(segundoNombre);

            // imprimit todos los nombres utilizando un bucle for each
            //foreach (string nombre in nombres)
            //{
            //    Console.WriteLine(nombre);
            //}

            //imprimir todos los nombres utilizando un bucle for
            //for (int i = 0; i < nombres.Length; i++)
            //{
            //    Console.WriteLine(nombres[i]);
            //}

            ////imprimir todos los nombres utilizando while
            //int i = 0;
            //while (i < nombres.Length)
            //{
            //    Console.WriteLine(nombres[i]);
            //    i++;
            //}

            ////imprimir todos los nombres utilizando do while
            //int i= 0;
            //do 
            //{
            //    Console.WriteLine(nombres[i]);
            //    i++;
            //} while (i < nombres.Length);
        }
    }
}
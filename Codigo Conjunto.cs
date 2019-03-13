using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_tarea_de_gio_parte_2
{
    class Program
    {
        /// <summary>
        /// Metodo que devuelve la unión
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="u"></param>
        /// <param name="minU"></param>
        /// <param name="maxU"></param>
        /// <returns></returns>
        static int[] union(int[] a, int[] b, int[] u, int minU, int maxU)
        {
            var respuesta = new int[maxU];
            var valorDefecto = minU - 1;
            //Se recorre el vector de respuesta y cada posición se le asignaun valor por defecto que no este en el rango de U para no tener confuciones.
            for (int i = 0; i < respuesta.Length; i++)
            {
                respuesta[i] = valorDefecto;
            }
            respuesta[0] = a[0];
            var x = 0;  //Ultima posición donde se inserto un valor en vector respuesta.
            var valor = 0;
            //Se recorren los elementos de A
            for (int i = 1; i < a.Length; i++)
            {
                valor = a[i];
                if (!existe(valor, respuesta)) // sino existe
                {
                    x++;
                    respuesta[x] = a[i];
                }
            }
            //Se recorren los elementos de B
            for (int i = 1; i < b.Length; i++)
            {
                valor = b[i];
                if (!existe(valor, respuesta)) // sino existe
                {
                    x++;
                    respuesta[x] = b[i];
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Devuelve el complemento
        /// </summary>
        /// <param name="union"></param>
        /// <param name="minU"></param>
        /// <param name="maxU"></param>
        /// <returns></returns>
        static string Complemento(int [] union, int minU, int maxU)
        {
            var cadenaRespesta = ""; 
            var universo = new int[maxU - minU + 1];
            var contador = minU;
            var valor = 0;
            //Se crea el vector de universo U
            for (int i = 0; i < universo.Length; i++)
            {
                universo[i] = contador;
                contador++;
            }
            
            //Se busca los elementos posibles del universo U que no estén en los conjuntos A y B (unión)
            for (int i = 0; i < universo.Length; i++)
            {
                valor = universo[i];

                if (!existe(valor, union))
                {
                    cadenaRespesta += valor + ",";
                }
            }
            return cadenaRespesta.Substring(0, cadenaRespesta.Length - 1);
        }

        static string Intercepcion(int[] a, int[] b, int minU)
        {
            var cadenaRespesta = "";
            var valorDefecto = minU - 1;
            int[] inter;
            var x = -1;
            if (a.Length == b.Length)
                inter = new int[a.Length - 1 + 1];
            else if (a.Length > b.Length)
                inter = new int[a.Length - 1 + 1];
            else
                inter = new int[b.Length - 1 + 1];

            //Se llena con valores por defecto que no estén en el rango (0 y 30) ya que por defecto esta con ceros y este numero hace parte del universo.
            for (int i = 0; i < inter.Length; i++)
            {
                inter[i] = valorDefecto;
            }
            
            var valor = 0;
            //Se recorre A
            for (int i = 0; i < a.Length; i++)
            {
                valor = a[i];
                //Si existe el valor de A en B y para que no repita valores se valida que no exista este en el vector que se está creando para la respsuesta (en inter)
                if (existe(valor, b) && !existe(valor, inter))
                {
                    x++;
                    inter[x] = valor; 
                }
            }
            //Se devuelve la respuesta concatenada una variable string
            for (int i = 0; i < inter.Length; i++)
            {
                valor = inter[i];
                if (valor == valorDefecto)
                    break;
                cadenaRespesta += valor + ",";
            }
            return cadenaRespesta.Substring(0, cadenaRespesta.Length - 1);
        }

        /// <summary>
        /// Busca si el numero n especificado extiste en el vector dado
        /// </summary>
        /// <param name="n">el número a evaluar</param>
        /// <param name="vector">vector a buscar</param>
        /// <returns></returns>
        public static bool existe(int n, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == n)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] U = { 0, 0, 0, 1, 2, 2, 3, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12, 13, 14, 15, 16, 17, 18, 18, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
            int[] B = { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };

            var minU = 0;
            var maxU = 30;
            var un = union(A, B, U, minU, maxU);
            var valor = 0;
            var cadena = "";
            Console.WriteLine("LA UNIÓN ENTRE 'A' y 'B'");
            for (int i = 0; i < un.Length; i++)
            {
                valor = un[i];
                if (valor == minU - 1)
                {
                    break;
                }
                cadena += un[i] + ",";
            }
            //Se quita la coma del final que sobra
            cadena = cadena.Substring(0, cadena.Length - 1);
            Console.WriteLine(cadena);

            Console.WriteLine("\nEL COMPLEMENTO DE 'A' y 'B'");
            Console.WriteLine(Complemento(un,0,30));

            Console.WriteLine("\nLA INTERCEPCÍON DE 'A' y 'B'");
            Console.WriteLine(Intercepcion(A, B, 0));

            Console.ReadLine();
        }
    }
}

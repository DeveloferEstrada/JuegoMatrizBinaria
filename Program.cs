using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoMatrizBinaria
{
    class Program
    {
        public static int[,] matriz = new int[4, 4];
        public static void Main(string[] args)
        {
           
            string[] intentosMatriz = new string[2];
            int intentos = 4;
            string intento = string.Empty;

            while (intentos > 0)
            {
                
                //Llamamos método que imprime matriz en pantalla
                printMatriz(matriz);
                Console.WriteLine();
                Console.WriteLine("Escribe tu jugada (x,y) [Intento #"+intentos+"]");
                //Guardamos coordenada como string separada por coma
                intento = Console.ReadLine();
                Console.WriteLine();
                //Llenamos la matriz de intento o jugada con los valores del arreglo string separando por coma
                intentosMatriz = intento.Split(',');
                //Convertimos los valores en tipo entero y llamamos método de asignación de valores de la matríz
                setMatrizValue(Convert.ToInt32(intentosMatriz[0]), Convert.ToInt32(intentosMatriz[1]));
                intentos--;
                
            }


            Console.WriteLine();
            Console.WriteLine("El juego ha terminado, el resultado es:");
            Console.WriteLine();
            printMatriz(matriz);
            Console.ReadKey();
        }

        public static void setMatrizValue(int x,int y)
        {
            if(x<0 || x>3 || y<0 || y > 3)
            {
                Console.WriteLine("Jugada inválida");
                return;
            }
            matriz[x, y] = 1;

            int[] arriba = new int[2], izquierda = new int[2], derecha = new int[2], abajo = new int[2];

            arriba[0] = x-1;
            arriba[1] = y;

            if((x-1)>=0 && x - 1 <= 3)
            {
                matriz[arriba[0], arriba[1]] = 1;
            }

            izquierda[0] = x;
            izquierda[1] = y-1;

            if ((y - 1) >=0 && y-1 <= 3)
            {
                matriz[izquierda[0], izquierda[1]] = 1;
            }


            derecha[0] = x;
            derecha[1] = y + 1;

            if ((y + 1) >= 0 && y + 1 <= 3)
            {
                matriz[derecha[0], derecha[1]] = 1;
            }


            abajo[0] = x+1;
            abajo[1] = y;

            if ((x + 1) >= 0 && x + 1 <= 3)
            {
                matriz[abajo[0], abajo[1]] = 1;
            }


        }

        public static void printMatriz(int[,] matriz)
        {
            //Recorrer Matriz e imprimir sus valores actuales
            for(int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
            
        }

    }
}

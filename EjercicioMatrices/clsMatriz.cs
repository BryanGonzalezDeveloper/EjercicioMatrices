using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EjercicioMatrices
{
    class clsMatriz
    {
        public int Filas { get; set; }
        public int Columnas { get; set; }
        public delegate void Imprimir(int numero,int fila,int columna);
        public Imprimir imprimirMatriz;
        public clsMatriz(int cantidad)
        {
            Columnas = Filas = cantidad;
        }
        public void llenarMatriz()
        {
            int[,] matriz = new int[Filas, Columnas];
            Random alea = new Random();
           
            int num = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    num= alea.Next(100);
                    imprimirMatriz(num,i,j);
                }
            }
        }
    }
}

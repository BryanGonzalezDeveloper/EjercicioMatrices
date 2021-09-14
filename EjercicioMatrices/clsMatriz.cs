using System;
namespace EjercicioMatrices
{
    class clsMatriz
    {
        public int Filas { get; set; }
        public int Columnas { get; set; }
        int[,] matriz;
        public delegate void Imprimir(int numero,int fila,int columna);
        public Imprimir imprimirMatriz;
        public Imprimir DelSuma;

        public clsMatriz(int cantidad)
        {
            Columnas = Filas = cantidad;
        }
        public void llenarMatriz()
        {
            matriz = new int[Filas, Columnas];
            Random alea = new Random();
           
            int num = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    num= alea.Next(100);
                    matriz[i, j] = num;
                    imprimirMatriz(num,i,j);
                }
            }
        }

        public void sumarFila()
        {
            int sumaFila = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaFila = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sumaFila += matriz[i, j];
                }
                DelSuma(sumaFila, i, Columnas );
            }
        }

        public void sumarColumna()
        {
            int sumaColumna = 0;
            int row = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaColumna = 0;
                row = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sumaColumna += matriz[row, i];
                    row++;
                }
                DelSuma(sumaColumna, Filas , i);
            }
        }
    }
}

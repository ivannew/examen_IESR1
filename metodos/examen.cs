using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_IESR.metodos
{
     public class examen
    {
        public void problema1()
        {
      
            int[] arreglo = new int[100];
            Random alea= new Random();
            for(int i=0; i<arreglo.Length;i++)
            {
                int cali=alea.Next(1,100);
                arreglo[i]=cali;
                
            }
            int menos = 0;
            int pos = 0;
            int tem = 0;
            for(int i= 0; i<arreglo.Length-1;i++)
            {
                menos= arreglo[i];
                pos = i;
                for(int j=i+1; j<arreglo.Length; j++)
                {
                    if (arreglo[j]>menos)
                    {
                        menos = arreglo[j];
                        pos = j;
                    }
                    if(pos!=i)
                    {
                        tem = arreglo[pos];
                        arreglo[pos] = arreglo[j];
                        arreglo[j] = tem;
                    }

                }
            }
            Console.WriteLine("calificaciones");
            for(int i=0; i<arreglo.Length; i++)
            {
                Console.WriteLine("calificacion: "+arreglo[i]);
            }
            int numero = 75;
            int inicio = 0;
            int fin = arreglo.Length - 1;
            int resultado = -1;
            bool encontrar = false;

            while (inicio <= numero)
            {
                int medio = (inicio + fin) / 2;
                if (arreglo[medio] == fin)
                {
                    Console.WriteLine($"el {arreglo[medio]} esta{medio}");
                    encontrar = true;
                    break;
                }
                else if (arreglo[medio] < numero)
                {
                    fin = medio - 1;
                    medio = (inicio + fin) / 2;

                }
                else
                {
                    inicio = medio + 1;
                    medio = (inicio + fin) / 2;
                }
            }
            if (!encontrar)
            {
                Console.WriteLine("ese no es");
            }

        }
        
    }
}

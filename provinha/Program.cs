using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provinha
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            int[] valor1 = {3, 2, 1, 6, 0, 5};
            int[] valor2 = {7, 5, 13, 9, 1, 6, 4};

            var raiz1 = valor1.Max();
            var raizIndex1 = Array.IndexOf(valor1, valor1.Max());
            var fim1 = valor1.ToList().Count - (raizIndex1 +1);
            var esquerda1 = valor1.ToList().GetRange(0, raizIndex1);
            var direita1 = valor1.ToList().GetRange((raizIndex1 +1) , fim1);

            arvore.insereRaiz(raiz1);

            foreach (var esq in esquerda1)
            {
                arvore.insereEsquerda(esq);
            }

            foreach (var dir in direita1)
            {
                arvore.insereDireita(dir);
            }

            Console.WriteLine("Array de entrada: ");
            printList(valor1.ToList());
            Console.WriteLine("Raiz: \n"+ raiz1);
            Console.WriteLine("Galho da esquerda: ");
            printList(esquerda1.OrderByDescending(x => x).ToList());
            Console.WriteLine("Galho da direita: ");
            printList(direita1.OrderByDescending(x => x).ToList());

            var raiz2 = valor2.Max();
            var raizIndex2 = Array.IndexOf(valor2, valor2.Max());
            var fim2 = valor2.ToList().Count - (raizIndex2 + 1);
            var esquerda2 = valor2.ToList().GetRange(0, raizIndex2);
            var direita2 = valor2.ToList().GetRange((raizIndex2 + 1), fim2);

            arvore.insereRaiz(raiz2);

            foreach (var esq in esquerda2)
            {
                arvore.insereEsquerda(esq);
            }

            foreach (var dir in direita2)
            {
                arvore.insereDireita(dir);
            }

            Console.WriteLine("Array de entrada: ");
            printList(valor2.ToList());
            Console.WriteLine("Raiz: \n" + raiz2);
            Console.WriteLine("Galho da esquerda: ");
            printList(esquerda2.OrderByDescending(x => x).ToList());
            Console.WriteLine("Galho da direita: ");
            printList(direita2.OrderByDescending(x => x).ToList());

            //Console.WriteLine("\nresultado: ");
            //Console.WriteLine(arvore.listagem());

            Console.ReadKey();
        }

        private static void printList(List<int> listaParaPrint)
        {

            for (int i = 0; i < listaParaPrint.Count(); i++)
            {
                var item = listaParaPrint[i];

                if (i == listaParaPrint.Count() - 1)
                {
                    Console.WriteLine(item.ToString());

                }
                else
                {
                    Console.Write(item.ToString() + ", ");
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provinha
{
    class ArvoreBinaria
    {
        private Nodo raiz = null;
        private int qtde = 0;
        private string resultadoEsquerda = "";
        private string resultadoDireita = "";
        List<int> valoreDireita = new List<int>();
        List<int> valoreEsquerda = new List<int>();

        public bool VerificaNo(Nodo no)
        {
            return (no.Get_no_direita() == null) && (no.Get_no_esquerda() == null);
        }

        public Nodo CriaNo(Nodo Raiz)
        {
            Nodo no = new Nodo();
            no.Set_no_pai(Raiz);
            return no;
        }

        public void insereRaiz(int valor)
        {
            Nodo no_aux;
            no_aux = new Nodo();
            raiz = no_aux;
            no_aux.Set_valor(valor);
            no_aux.Set_no_direita(CriaNo(no_aux));
            no_aux.Set_no_esquerda(CriaNo(no_aux));
            qtde++;
        }

        public void insereDireita(int valor) 
        {
            Nodo no_aux;

            no_aux = raiz;

            while (VerificaNo(no_aux) == false)
            {
                no_aux = no_aux.Get_no_direita();
            }

            no_aux.Set_valor(valor);
            no_aux.Set_no_direita(CriaNo(no_aux));
            no_aux.Set_no_esquerda(CriaNo(no_aux));
            qtde++;
        }

        public void insereEsquerda(int valor)
        {
            Nodo no_aux;

            no_aux = raiz;

            while (VerificaNo(no_aux) == false)
            {
                no_aux = no_aux.Get_no_esquerda();
            }

            no_aux.Set_valor(valor);
            no_aux.Set_no_direita(CriaNo(no_aux));
            no_aux.Set_no_esquerda(CriaNo(no_aux));
            qtde++;
        }

        private void LeNodoEsquerdo(Nodo no)
        {
            if (VerificaNo(no))
                return;

            LeNodoEsquerdo(no.Get_no_esquerda());

            if (no.Get_no_pai() != null)
                valoreEsquerda.Add(no.Get_valor());
        }

        private void LeNodoDireita(Nodo no)
        {
            if (VerificaNo(no))
                return;

            LeNodoDireita(no.Get_no_direita());

            if (no.Get_no_pai() != null)
                valoreDireita.Add(no.Get_valor());
        }

        public string listagem()
        {
            LeNodoEsquerdo(raiz);
            LeNodoDireita(raiz);

            foreach (var item in valoreDireita.OrderByDescending(x => x))
            {
                resultadoDireita = resultadoDireita + "-" + item;
            }

            foreach (var item in valoreEsquerda.OrderByDescending(x => x))
            {
                resultadoEsquerda = resultadoEsquerda + "-" + item;
            }

            return "D: "+ resultadoDireita + " E: " + resultadoEsquerda;
        }
    }
}

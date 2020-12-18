using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provinha
{
    class Nodo
    {
        private Nodo no_pai = null;
        private Nodo no_direita = null;
        private Nodo no_esquerda = null;
        private int valor = 0;

        public int Get_valor() { return valor; }
        public void Set_valor(int v) { valor = v; }
        public void Set_no_pai(Nodo no) { no_pai = no; }
        public void Set_no_direita(Nodo no) { no_direita = no; }
        public void Set_no_esquerda(Nodo no) { no_esquerda = no; }
        public Nodo Get_no_pai(){ return no_pai; }
        public Nodo Get_no_direita() { return no_direita; }
        public Nodo Get_no_esquerda() { return no_esquerda; }
    }
}

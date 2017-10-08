using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Todos os métodos que devem ser implementados!!

namespace TrabalhoGrafos.Controller
{
    class Grafo
    {

        #region "Operações Fundamentais"

        //Constroi o grafo não dirigido
        public void construirGrafo(string v1, string v2)
        {
            //Pesquisa se já existe o vertice v1 
            //se sim ele só coloca o vertice v2 na lista de adjacencia do vertice v1

            //se não ele cria o vertice v1 antes de inserir v2
            //criarVertice(){ }

        }

        //cria o vertice como um "vetor" sem nenhuma aresta
        public void criarVertice(string v1)
        {
            Vertice vert = new Vertice(v1);
        }

        //"adiciona o vertice na lista de adjacencia, compreendida pelo objeto V1"
        public void adicionarVertice(Vertice V1,string v2) {

        }

        //Lê do arquivo txt os grafos e joga na memoria ram...na memoria executavel deste programa
        public void lerArqTxT() { }

        #endregion

        #region "Métodos de 1 a 6 p/grafo não dirigido"

        public bool isAdjacente(Vertice V1, Vertice V2) { return true; }

        public int getGrau(Vertice V1) { return 2; }

        public bool isRegular(Grafo G) { return true; }

        public bool isIsolado(Vertice V1) { return true; }

        public bool isPendente(Vertice V1) { return true; }

        public bool isNulo(Grafo G) { return true; }

        #endregion


        #region "Métodos de 7 a 13 p/grafo não dirigido"

        public bool isCompleto(Grafo G) { return true; }

        public bool isConexo(Grafo G) { return true; }

        public bool isBipartido(Grafo G) { return true; }

        public Grafo getComplementar(Grafo G) { return G; }

        public bool isEuleriano(Grafo G) { return true; }

        public bool isUnicursal(Grafo G) { return true; }

        public bool isHamiltoniano(Grafo G) { return true; }

        #endregion

        #region "Métodos de 14 a 18 p/grafo dirigido"

        public bool hasCiclo(Grafo G) { return true; }

        public int getGrauEntrada(Vertice v1) { return 2; }

        public void ordenacaoTopologica(Grafo G) { } //verifique se o grafo é acíclico antes

        public Grafo getTransposto(Grafo G) { return G; }

        public bool isFConexo(Grafo G) { return true; }

        #endregion

        #region "Demais Métodos"

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdenacaoTopologica
{
    public class Grafo
    {
        // Numero de Vértice do Meu Grafo
        protected int QuantidadeDeVertices { get => Arestas.GroupBy(vertice => vertice.Vertice).Count(); }

        // Referência à lista de adjacência de cada vertice.
        protected IList<Aresta> Arestas { get; set; }

        //Construtor
        public Grafo()
        {
            Arestas = new List<Aresta>();
        }

        // Adiciona arestas no grafo
        public void AdicionarAresta(Vertice vertice, Vertice verticeRelacionado)
        {
            Arestas.Add(new Aresta(vertice, verticeRelacionado));
        }

        private int Ordenar(IList<Aresta> listaDeAdjacencias, int contador, IList<Vertice> ordenacaoTopologica)
        {
            while (listaDeAdjacencias.Where(aresta => aresta.Vertice.GrauDeEntrada(listaDeAdjacencias) == 0).Count() > 0)
            {
                // Remove o da Fila de vertices e adiciona na lista de Ordenação Topológica.
                Vertice verticeDeGrauNulo = listaDeAdjacencias.FirstOrDefault(aresta => aresta.Vertice.GrauDeEntrada(listaDeAdjacencias) == 0).Vertice;
                ordenacaoTopologica.Add(verticeDeGrauNulo);

                IList<Aresta> arestasDoVerticeDeGrauNulo = listaDeAdjacencias.Where(aresta => aresta.Vertice == verticeDeGrauNulo).ToList();
                foreach (Aresta aresta in arestasDoVerticeDeGrauNulo)
                {
                    listaDeAdjacencias.Remove(aresta);
                    if(listaDeAdjacencias.Where(a => a.Vertice == aresta.VerticeRelacionado).Count() == 0)
                        ordenacaoTopologica.Add(aresta.VerticeRelacionado);
                }

                contador++;
            }

            return contador;
        }

        public void OrdenarTopologicamente()
        {
            // Array para armazenar os graus de entrada de todos os vertices.
            IList<Aresta> listaDeArestasAuxiliar = Arestas.ToList();

            // inicializa a contagem de vértices visitados.
            int contador = 0;

            // Lista para armazenar a Ordenação Topológica
            IList<Vertice> ordenacaoTopologica = new List<Vertice>();
            contador = Ordenar(listaDeArestasAuxiliar, contador, ordenacaoTopologica);

            ImprimirOrdenacaoTopologica(ordenacaoTopologica, contador);
        }

        private void ImprimirOrdenacaoTopologica(IList<Vertice> ordenacaoTopologica, int contador)
        {
            // Verifica se Tem ciclos.
            if (contador != QuantidadeDeVertices)
            {
                Console.WriteLine("O Grafo possui Ciclos");
                return;
            }

            // Imprime a ordenação Topológica
            foreach (Vertice vertice in ordenacaoTopologica)
                Console.Write(vertice.Nome + "; ");

            Console.Write("\n");
        }
    }
}

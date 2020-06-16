using System;

namespace OrdenacaoTopologica
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo();

            // criando vertices
            Vertice vertice0 = new Vertice("0");
            Vertice vertice1 = new Vertice("1");
            Vertice vertice2 = new Vertice("2");
            Vertice vertice3 = new Vertice("3");
            Vertice vertice4 = new Vertice("4");
            Vertice vertice5 = new Vertice("5");
            Vertice vertice6 = new Vertice("6");
            Vertice vertice7 = new Vertice("7");
            Vertice vertice8 = new Vertice("8");
            Vertice vertice9 = new Vertice("9");
            Vertice vertice10 = new Vertice("10");
            Vertice vertice11 = new Vertice("11");
            Vertice vertice12 = new Vertice("12");
            Vertice vertice13 = new Vertice("13");

            // adicionando vertices ao grafo por meio de Lista de Adjacência.
            grafo.AdicionarAresta(vertice2, vertice1);
            grafo.AdicionarAresta(vertice5, vertice1);
            grafo.AdicionarAresta(vertice0, vertice1);
            grafo.AdicionarAresta(vertice6, vertice4);
            grafo.AdicionarAresta(vertice6, vertice3);
            grafo.AdicionarAresta(vertice1, vertice7);
            grafo.AdicionarAresta(vertice1, vertice10);
            grafo.AdicionarAresta(vertice10, vertice9);
            grafo.AdicionarAresta(vertice10, vertice13);
            grafo.AdicionarAresta(vertice13, vertice8);
            grafo.AdicionarAresta(vertice8, vertice12);
            grafo.AdicionarAresta(vertice8, vertice11);

            //2; 5; 0; 6; 4; 3; 1; 7; 10; 9; 13; 8; 12; 11;
            Console.WriteLine("╔════════════════════════════════════════╗" + 
                            "\n  Ordenação Topológica do Grafo inserido: " + 
                            "\n╚════════════════════════════════════════╝");
          
            grafo.OrdenarTopologicamente();
        }
    }
}

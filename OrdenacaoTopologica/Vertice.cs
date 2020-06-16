using System.Collections.Generic;
using System.Linq;

namespace OrdenacaoTopologica
{
	public class Vertice
	{
		public string Nome { get; set; }

		public int GrauDeEntrada(IList<Aresta> vertices)
		{
			return vertices.Where(aresta => this != aresta.Vertice && aresta.Vertice.Nome == Nome).Count();
		}

		public Vertice(string descricao)
		{
			Nome = descricao;
		}
	}
}

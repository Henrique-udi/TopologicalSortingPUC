namespace OrdenacaoTopologica
{
	public class Aresta
	{
		public Aresta(Vertice vertice, Vertice verticeRelacionado)
		{
			Vertice = vertice;
			VerticeRelacionado = verticeRelacionado;
		}

		public Vertice Vertice { get; set; }
		public Vertice VerticeRelacionado { get; set; }
	}
}

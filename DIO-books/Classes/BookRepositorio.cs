using System;
using System.Collections.Generic;
using DIO_books.Interfaces;

namespace DIO_books
{
    public class BookRepositorio : IRepositorio<Books>
    {
        private List<Books> listaBooks = new List<Books>();
		public void Atualiza(int id, Books objeto)
		{
			listaBooks[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaBooks[id].Excluir();
		}

		public void Insere(Books objeto)
		{
			listaBooks.Add(objeto);
		}

		public List<Books> Lista()
		{
			return listaBooks;
		}

		public int ProximoId()
		{
			return listaBooks.Count;
		}

		public Books RetornaPorId(int id)
		{
			return listaBooks[id];
		}
    }
}

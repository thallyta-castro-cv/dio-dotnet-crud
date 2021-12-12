using System;

namespace DIO_books
{
    public class Books: IdBase
    {
        private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private string Autor { get; set; }
        private bool Excluido {get; set;}  

        public Books(int id, Genero genero, string titulo, string descricao, string autor)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Autor = autor;
            this.Excluido = false;
		}

         public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo(){
            return this.Titulo;
        }

         public int retornaId(){
            return this.Id;
        }

        public void Excluir(){
            this.Excluido =  true;
        }
    }
}


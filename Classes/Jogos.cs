using System;

namespace DIO.Jogos
{
    public class Jogos : EntidadeBase
    {
        private string Titulo { get; set; }
        private string Distribuidora {get; set;}
        private string Plataforma {get; set; }
        private string Descricao { get; set; }
        private Genero Genero { get; set; }
        private string Idioma {get; set;}
        private int Ano_Lancamento { get; set; }

        public Jogos(int id, string titulo, string Distribuidora, string Plataforma, string Descricao, string Idioma, int Ano_Lancamento)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Distribuidora = Distribuidora;
            this.Plataforma = Plataforma;
            this.Descricao = Descricao;
            this.Genero = Genero;
            this.Idioma = Idioma;
            this.Ano_Lancamento = Ano_Lancamento;
        }

        public override string ToString()
        { 
            string retorno = "";
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Distribuidora: " + this.Distribuidora + Environment.NewLine;
            retorno += "Plataforma: " + this.Plataforma + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Idioma: " + this.Idioma + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.Ano_Lancamento + Environment.NewLine;

            return retorno;
        }
        
        public string retornaTitulo()
        { 
            return this.Titulo;
        }

        internal int retornaId()
        { 
            return this.Id;
        }
    }
}
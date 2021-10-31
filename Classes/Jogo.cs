using System;

namespace DIO.Jogos
{
    public class Jogo : EntidadeBase
    {
        private string Titulo { get; set; }
        private string Plataforma {get; set; }
        private string Descricao { get; set; }
        private Genero Genero { get; set; }
        private string Idioma {get; set;}
        private int Ano_Lancamento { get; set; }

        private bool Excluido {get; set; }

        public Jogo(int id, string titulo, string plataforma, string descricao,Genero genero, string idioma, int ano_Lancamento)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Plataforma = plataforma;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Idioma = idioma;
            this.Ano_Lancamento = ano_Lancamento;
            this.Excluido = false;

        }

        public override string ToString()
        { 
            string retorno = "";
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Plataforma: " + this.Plataforma + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Idioma: " + this.Idioma + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.Ano_Lancamento + Environment.NewLine;
            //retorno += "Excluido: " + this.Excluido;

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
        public void Excluir() 
        { 
            this.Excluido = true;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;

namespace ClickJogos.Models
{
    public class Jogo
    {
        public long Id {get; set;}
        public string Titulo {get; set;}
        public string Genero {get; set;}
        public string Distribuidora {get; set;}
        public string Capa {get; set;}
        public string Descricao {get; set;}
        public string Plataforma {get; set;}
        public DateTime DataLancamento {get; set;}
    }
}
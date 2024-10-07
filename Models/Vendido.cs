using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace trilha_explorando_C_.Models
{
    public class Vendido
    {
        public int Id { get; set; }
        //ela serve para pegar variáveis que não segue o padrão de variável do c# e ser colocada em uma varíavel do modo correto sem precisar alterar como por exemplo Nome_Produto para Produto ou NomeProduto
        //[JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
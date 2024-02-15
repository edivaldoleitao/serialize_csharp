using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace projetoSerialize.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime data)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda =data;
        }

        public int Id { get; set; }
        
        // [JsonProperty("nome_produto")] -> caso o nome da propriedade lida no json seja diferente do nome 
        // no programa ou fora do padrão usado no programa, pois vai usar esse nome para deserializar o json
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
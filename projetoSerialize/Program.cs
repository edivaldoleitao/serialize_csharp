using System.Runtime.Serialization;
using Newtonsoft.Json;
using projetoSerialize.Models;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda venda = new Venda(1,"xampu", 12.00M, dataAtual);
Venda venda2 = new Venda(2,"xampu 2", 11.00M, dataAtual);

listaVendas.Add(venda);
listaVendas.Add(venda2);

//string serialized = JsonConvert.SerializeObject(venda, Formatting.Indented);
// a data vai ser salva em formato de iso 8601 no json
string serialized = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json",serialized);
//Console.WriteLine(serialized);




/////////////////////////////////////////////////////////////////////////////////////////////////////
// DESERIALIZAÇÃO

// string deserializado = File.ReadAllText("Arquivos/vendas.json");

// List<Venda>? vendas = JsonConvert.DeserializeObject<List<Venda>>(deserializado);

// foreach (Venda v in vendas)
// {
//     Console.WriteLine($"ID = {v.Id}, PRODUTO = {v.Produto}, Preço = {v.Preco}, DATA = {v.DataVenda}");
// }




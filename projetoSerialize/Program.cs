using Newtonsoft.Json;
using projetoSerialize.Models;

List<Venda> listaVendas = new List<Venda>();

Venda venda = new Venda(1,"xampu", 12.00M);
Venda venda2 = new Venda(2,"xampu 2", 11.00M);

listaVendas.Add(venda);
listaVendas.Add(venda2);

//string serialized = JsonConvert.SerializeObject(venda, Formatting.Indented);
string serialized = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json",serialized);

Console.WriteLine(serialized);
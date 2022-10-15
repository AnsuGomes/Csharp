using ExemploJson;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Venda> listaVendas = new List<Venda>();
      
        Venda v1 = new Venda(1, "Material de escritorio", 25.00M);
        Venda v2 = new Venda(2, "Computador", 250.00M);

        listaVendas.Add(v1);
        listaVendas.Add(v2);

        string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

        File.WriteAllText("models/vendas.json", serializado);

        Console.WriteLine(serializado);
    }
}
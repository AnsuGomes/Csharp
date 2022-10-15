using ExemploJson;
using Newtonsoft.Json;
using System.IO;
using System;

class Program
{
    private static void Main(string[] args)
    {
        Venda v1 = new Venda(1, "Material de escritorio", 25.00M);

        string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

        File.WriteAllText("models/vendas.json", serializado);

        Console.WriteLine(serializado);
    }
}
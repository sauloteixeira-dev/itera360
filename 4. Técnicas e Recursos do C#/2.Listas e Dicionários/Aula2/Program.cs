List<string> nomes = new List<string>();

nomes.Add("Saulo");     //0
nomes.Add("Pedro");     //1
nomes.Add("João");      //2
nomes.Add("Roberta");   //3

// foreach (var nome in nomes)
// {
//     Console.WriteLine(nome);
// }
// //remove pelo nome
// nomes.Remove("João");
// //remove pelo index
// nomes.RemoveAt(1);


// foreach (var nome in nomes)
// {
//     Console.WriteLine(nome);
// }

// bool encontrado = nomes.Contains("Saulo"); //se encontrar = true se não false;

// Console.WriteLine(encontrado);

Dictionary<string, string> configuracoes = new Dictionary<string, string>();

configuracoes.Add("Tema", "Escuro");
configuracoes.Add("Volume", "50%");
configuracoes.Add("Notificações", "Ativadas");


Console.WriteLine(configuracoes["Tema"]); //Escuro
Console.WriteLine(configuracoes.Count); //3


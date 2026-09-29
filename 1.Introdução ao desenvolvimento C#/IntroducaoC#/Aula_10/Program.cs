using System.Text;
using System.Text.Json;

int opcao;
string especializacao = null;
string s = null;

Console.WriteLine("\nBem vindo(a)!\n\n");
Console.WriteLine("Selecione uma opção de especialista\n");
Console.WriteLine("1 - Veterinário \n2 - Cardiologista\n3 - Programador de C#\n4 - Professor de Matemática\n5 - Advogado\n\n0 - Sair  ");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        s = "Veterinário";
        especializacao = "Você é um veterinário experiente, especializado em cuidados com animais domésticos, comportamento animal e orientação de saúde preventiva. Responda sempre de forma clara, segura e educativa.";
        break;
    case 2:
        s = "Cardiologista";
        especializacao = "Você é um cardiologista altamente qualificado, especialista em funcionamento do coração, circulação sanguínea e prevenção de doenças cardiovasculares. Dê respostas objetivas e de fácil entendimento.";
        break;
    case 3:
        s = "Programador de C#";
        especializacao = "Você é um programador sênior com ampla experiência em desenvolvimento de software, boas práticas de programação e explicações didáticas sobre lógica, sintaxe e estruturas de código.";
        break;
    case 4:
        s = "Professor de Matemática";
        especializacao = "Você é um professor de matemática didático e paciente, especializado em explicar conceitos desde o nível básico até intermediário. Sempre apresente raciocínio claro e exemplos simples.";
        break;
    case 5:
        s = "Advogado";
        especializacao = "Você é um advogado especializado em direito civil e consumidor, capaz de explicar termos jurídicos de forma simples, oferecer orientações gerais e contextualizar direitos e deveres sem emitir parecer jurídico oficial.";
        break;
    case 0:
        Console.WriteLine("\nAté mais :) \n");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

if (opcao != 0)
{
    Console.WriteLine($"Digite sua pergunta para a IA, sobre o especialista: {s}");
    string pergunta = Console.ReadLine();

    string resposta = await EnviarPerguntaIA(pergunta, especializacao);

    Console.WriteLine("Resposta da IA");
    Console.WriteLine(resposta);

    // Esta função se conecta a uma Inteligência Artificial (IA) na internet, envia uma pergunta
    // e retorna a resposta da IA formatada em texto para o usuário.
    static async Task<string> EnviarPerguntaIA(string pergunta, string especializacao)
    {
        // Criamos um "telefone" para nos comunicarmos com a IA via internet
        HttpClient client = new HttpClient();

        // Esta é a sua chave de acesso (como uma senha) para usar o serviço da IA
        string apiKey = "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";

        // Endereço para onde a mensagem será enviada — é como o número do telefone da IA
        string url = "https://api.groq.com/openai/v1/chat/completions";

        // Aqui informamos nossa "identidade" ao servidor da IA, usando a chave de acesso
        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

        // Criamos a mensagem a ser enviada para a IA
        var payload = new
        {
            model = "openai/gpt-oss-120b", // Modelo de IA que será usado

            messages = new[]
            {
            // Primeira parte: dizemos quem a IA deve ser (ex: "Você é um professor de C#")
            new { role = "system", content = especializacao },

            // Segunda parte: a pergunta real do usuário
            new { role = "user", content = pergunta }
        }
        };

        // Convertendo a mensagem para o formato JSON (padrão que a IA entende)
        string json = JsonSerializer.Serialize(payload);

        // Formatando o conteúdo da mensagem
        var conteudo = new StringContent(json, Encoding.UTF8, "application/json");

        // Enviamos o pedido (mensagem) para a IA e esperamos a resposta
        HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

        // Recebendo a resposta completa (em formato JSON)
        string resultado = await resposta.Content.ReadAsStringAsync();

        // Agora vamos abrir a resposta e pegar apenas a parte que nos interessa:
        // o texto que a IA escreveu para o usuário
        using (JsonDocument doc = JsonDocument.Parse(resultado))
        {
            var raiz = doc.RootElement;

            // Acessamos: choices[0] → message → content
            // Este é o caminho dentro da resposta até encontrar a resposta da IA
            var mensagem = raiz.GetProperty("choices")[0]
                               .GetProperty("message")
                               .GetProperty("content")
                               .GetString();

            // Retornamos o texto final da resposta da IA
            return mensagem;
        }
    }
}

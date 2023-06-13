//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

/*//Criando a lista de valores simples
List<string> listaDasBandas = new List<string> { "U2","The Beatles","Calypso"};*/

//criando o dicionário para receber os valores
Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

//Exibir logo
void ExibirLogo()
{
    //feito no https://fsymbols.com/pt/geradores/
    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

//Exibir o menu
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: MediaDeUmaBanda();
            break;
        case -1: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

//Titulo das opções
void ExibirTituloDaOpcao(string titulo)
{
    Console.Clear();
    int quantidadeDeLetras = titulo.Length;
    string asteristico = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico + "\n");
}

//Qualquer tecla para voltar ao menu anterior
void TeclaVoltar()
{
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

//Opção1
void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

//Opção 2
void MostrarBandasRegistradas()
{

    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    /*for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    TeclaVoltar();
}

//Opção 3
void AvaliarUmaBanda()
{
    ExibirTituloDaOpcao("Avaliar banda");

    //digite qual banda deseja avaliar
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //se a banda existir no dicionario >> atribuir uma nota
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registra com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    //senão, volta ao menu principal    
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        TeclaVoltar();
    }
}

//Opção 4
void MediaDeUmaBanda()
{
    ExibirTituloDaOpcao("Média de nota");

    //Perguntar qual é o nome da banda
    Console.Write("Digite o nome da banda que deseja saber a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    //consultar se a banda está inserida no dicionario da aplicação
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        if (bandasRegistradas[nomeDaBanda].Count == 0)
        {
            //verifica se a bada possui notas registradas    
            Console.WriteLine($"\nA banda {nomeDaBanda} não possui nenhuma nota registrada!");
            TeclaVoltar();
        }
        else
        {
            //Realizar o cálculo da média e exibir o resultado
            int nota = 0;
            int registros = bandasRegistradas[nomeDaBanda].Count;
            for (int i = 0; i < registros; i++)
            {
                nota += bandasRegistradas[nomeDaBanda][i];
            }

            Double media = nota / registros;

            Console.Write($"A banda {nomeDaBanda} obteve {registros} avaliações. \nA noma média é de {media}");


            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    } 
    else  
    {
        //senão, volta ao menu principal    
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        TeclaVoltar();
    }
    




}

ExibirOpcoesDoMenu();
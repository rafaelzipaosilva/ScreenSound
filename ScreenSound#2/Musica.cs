class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    
    //manipulando a prop get através de uma Função Lambda (Arrow Function)
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}" +
                            $"\nArtista: {Artista.Nome}" +
                            $"\nDuração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano. \n");
        }
        else
        {
            Console.WriteLine("Adquirir o plano Plus+ \n");
        }
    }
}
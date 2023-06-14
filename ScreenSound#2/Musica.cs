class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    public bool LeDisponivel()
    {
        return disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome} \nArtista: {artista} \nDuração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano. \n");
        } else
        {
            Console.WriteLine("Adquirir o plano Plus+ \n");
        }
    }
}
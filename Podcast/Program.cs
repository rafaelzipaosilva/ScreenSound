Episodio ep1 = new(2, "Técnicas de facilicitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flávia");

Podcast podcast = new("Podcast Especial", "Zipão");
podcast.AdiconarEpisodio(ep1);
podcast.AdiconarEpisodio(ep2);
podcast.ExibirDetalhes();
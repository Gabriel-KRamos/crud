class Database
{
    List<Filme> filmes = new List<Filme>();
    Tela tela = new Tela();


    public void addFilmes()
    {
        Console.Clear();
        tela.montarMoldura(1,1,79,4);
        tela.centralizar(2, 20, 79, "Adicionar de Filmes\n\n\n\n");

        Console.WriteLine("Qual o nome do filme?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual o genero do filme?");
        string genero = Console.ReadLine();
        Console.WriteLine("Qual a data de lançamento do filme?");
        string dataLancamento = Console.ReadLine();

        Filme filme = new Filme(nome, genero, dataLancamento);
        filmes.Add(filme);
    }


    public Database()
    {

        this.filmes.Add(new Filme("Manseira vs Batman: A origem", "Ação", "01/01/2023"));
        this.filmes.Add(new Filme("Batman e Superman casos de amor", "+18", "25/12/2022"));
        this.filmes.Add(new Filme("Incrível história de uma lenda chamada: Manseira", "Liver", "24/09/2023"));
    }

    public void getAllFilmes()
    {
        Console.Clear();
        tela.montarMoldura(1,1,79,3);
        tela.centralizar(2, 20, 79, "Lista de Filmes\n\n\n\n");


        int id = 0;

        foreach (Filme filme in filmes)
        {
            id++;
            Console.WriteLine($"Id: {id}");
            Console.WriteLine("Nome: " + filme._nome);
            Console.WriteLine("Genero: " + filme._genero);
            Console.WriteLine("Data de Lancamento: " + filme._dataLancamento);
            if (filme._alugado)
            {
                Console.WriteLine("Está Alugado");
            }
            else
            {
                Console.WriteLine("Está Disponível");
            }
            Console.WriteLine("--------------------------------------------");
        }

        Console.ReadKey(true);

    }

    public void deleteFilmes()
    {
        Console.Clear();
        tela.montarMoldura(1,1,79,3);
        tela.centralizar(2, 20, 79, "Excluir Filmes\n\n\n\n");


        Console.WriteLine("Deseja mesmo excluir um filme (S/N)");
        string sofia = Console.ReadLine();
        if (sofia == "S" || sofia == "s")
        {
            Console.WriteLine("Qual o ID do filme que deseja excluir?");
            string resp = Console.ReadLine();
            if (resp != "" && resp != " ")
            {

                int id = int.Parse(resp);

                if (id > filmes.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Coloque um ID valido");
                    System.Threading.Thread.Sleep(1500);
                    deleteFilmes();
                }
                else
                {
                    Console.WriteLine("Deseja mesmo excluir o filme: " + filmes[id - 1]._nome + " (S/N)");
                    string choice = Console.ReadLine();
                    if (choice == "S" || choice == "s")
                    {
                        filmes.RemoveAt(id - 1);
                    }
                    else if (choice == "N" || choice == "n")
                    {
                        Console.Clear();
                        deleteFilmes();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Coloque uma resposta valida");
                        System.Threading.Thread.Sleep(1500);
                        deleteFilmes();
                    }
                }
            }


            else
            {
                Console.Clear();
                deleteFilmes();
            }
        }

    }

    public void updateFilmes()
    {
        Console.Clear();
        tela.montarMoldura(1,1,79,3);
        tela.centralizar(2, 20, 79, "Alugar Filmes\n\n\n\n");

        Console.WriteLine("Qual o ID do filme que deseja Alugar?");
        string resp = Console.ReadLine();
        if (resp != "" && resp != " ")
        {

            int id = int.Parse(resp);

            if (id > filmes.Count)
            {
                Console.Clear();
                Console.WriteLine("Coloque um ID valido");
                System.Threading.Thread.Sleep(1500);
                updateFilmes();
            }
            else
            {
                Console.WriteLine("Deseja mesmo alugar o filme: " + filmes[id - 1]._nome + " (S/N)");
                string choice = Console.ReadLine();
                if (choice == "S" || choice == "s")
                {
                    filmes[id - 1]._alugado = true;
                }
                else if (choice == "N" || choice == "n")
                {
                    Console.Clear();
                    updateFilmes();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Coloque uma resposta valida");
                    System.Threading.Thread.Sleep(1500);
                    updateFilmes();
                }
            }
        }
    }

    public void updateFilmesState()
    {
        Console.Clear();
        tela.montarMoldura(1,1,79,3);
        tela.centralizar(2, 20, 79, "Devolver Filmes\n\n\n\n");

        Console.WriteLine("Qual o ID do filme que deseja devolver?");
        string resp = Console.ReadLine();
        if (resp != "" && resp != " ")
        {

            int id = int.Parse(resp);

            if (id > filmes.Count)
            {
                Console.Clear();
                Console.WriteLine("Coloque um ID valido");
                System.Threading.Thread.Sleep(1500);
                updateFilmesState();
            }
            else
            {
                Console.WriteLine("Deseja mesmo devolver o filme: " + filmes[id - 1]._nome + " (S/N)");
                string choice = Console.ReadLine();
                if (choice == "S" || choice == "s")
                {
                    filmes[id - 1]._alugado = false;
                }
                else if (choice == "N" || choice == "n")
                {
                    Console.Clear();
                    updateFilmesState();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Coloque uma resposta valida");
                    System.Threading.Thread.Sleep(1500);
                    updateFilmesState();
                }
            }
        }
    }


}


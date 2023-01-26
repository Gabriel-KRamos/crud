bool rodar = true;
string prompt = " Locadora Ramos\n Use as setas para navegar";
string[] options = {
    "Lista de filmes","Adicionar filme","Excluir filme","Alugar filme","Devolver filme","Sair"
    };
Navegar navegar = new Navegar(options, prompt);
Database database = new Database();


while (rodar)
{

    int selectedIndex = navegar.run();

    switch (selectedIndex)
    {
        case 0:
            database.getAllFilmes();
            break;

        case 1:
            database.addFilmes();
            break;

        case 2:
            database.deleteFilmes();
            break;
        case 3:
            database.updateFilmes();
            break;
        case 4:
            database.updateFilmesState();
            break;
        case 5:
            rodar = false;
            break;

    }
}
Console.Clear();

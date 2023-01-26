class Navegar
{
    Tela tela = new Tela();
    
    private int _selectedIndex;
    private string[] _options;
    private string _prompt;

    public Navegar(string[] options, string prompt)
    {
        this._selectedIndex = 0;
        this._options = options;
        this._prompt = prompt;
    }

    private void displayOptions()
    {
        Console.Clear();
        tela.montarMoldura(1,1,79,2);
        tela.centralizar(1,1,79,"Ramos Movies");
        Console.WriteLine("");
        Console.WriteLine("");
    
        for (int i = 0; i < _options.Length; i++)
        {
            string currentOption = _options[i];

            string prefix;

            if (i == _selectedIndex)
            {
                prefix = "->";
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                prefix = " ";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine($"{prefix}{currentOption}");

        }
        Console.ResetColor();

    }

    public int run()
    {
        ConsoleKey keyPressed;

        do
        {
            Console.Clear();
            displayOptions();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                _selectedIndex--;
                if (_selectedIndex == -1)
                {
                    _selectedIndex = _options.Length - 1;
                }
            }

            else if (keyPressed == ConsoleKey.DownArrow)
            {
                _selectedIndex++;
                if (_selectedIndex == _options.Length)
                {
                    _selectedIndex = 0;
                }
            }
        } while (keyPressed != ConsoleKey.Enter);

        return _selectedIndex;
    }
}
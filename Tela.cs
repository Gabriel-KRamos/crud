class Tela
{




    public void montarMoldura(int ci, int li, int cf, int lf)
    {
        int col, lin;

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("-");
            Console.SetCursorPosition(col, lf);
            Console.Write("_");
        }

        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("|");
            Console.SetCursorPosition(cf, lin);
            Console.Write("|");
        }

        Console.SetCursorPosition(ci, li); Console.Write("+");
        Console.SetCursorPosition(ci, lf); Console.Write("+");
        Console.SetCursorPosition(cf, li); Console.Write("+");
        Console.SetCursorPosition(cf, lf); Console.Write("+");
    }

    public void centralizar(int lin, int ci, int cf, string msg)
    {
        int col;
        col = ci + (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(col, lin);
        Console.Write(msg);
    }




}
class Filme
{
    public string _nome { get; set; }
    public string _genero { get; set; }
    public string _dataLancamento { get; set; }
    public bool _alugado { get; set; }

    public Filme(string nome, string genero, string dataLancamento)
    {
        this._nome = nome;
        this._genero = genero;
        this._dataLancamento = dataLancamento;

    }

}
using System;

public class Pessoa
{
    private string nome;
    private int nota;

    // Construtor
    public Pessoa(string nome, int nota)
    {
        this.nome = nome;
        this.nota = nota;
    }

    // Propriedade Nome
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    // Propriedade Nota
    public int Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    // Método ToString() sobrecarregado
    public override string ToString()
    {
        return $"Nome: {nome}, Nota: {nota}";
    }
}

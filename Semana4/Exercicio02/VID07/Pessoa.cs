using System;

class Pessoa{

    public Pessoa() // Construtor é um metodo da calsse com memso nome da calsse que exwecuta instataneamente quando se instancia o objeto
    {
        Console.WriteLine("Construtor executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
}
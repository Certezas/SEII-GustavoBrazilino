using System;

class Pessoa
{
    private string nome = "José Miguel";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // usado para diferenciar o atributo(jose miguel) do parametro(gustavo). This chama o parametro. 
    }

}
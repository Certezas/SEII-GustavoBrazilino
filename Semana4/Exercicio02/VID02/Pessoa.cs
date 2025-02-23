using System;

class Pessoa
{

    // Métodos diferentes com nomes iguais, pode desde que os parametros de cada um seja diferentes
    public void apresentar()
    {
        Console.WriteLine("Olá!!");
    }
    
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
    
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos");
    }

}
using System;

class Exemplo
{
    public static string nome = "Gustavo"; // static -> garante acesso ao atributo sem necessidade de instanciar um objeto

    public static void soma(int n1, int n2) // static -> garante acesso ao metodo soma sem necessidade de instanciar um objeto
    {
        Console.WriteLine(n1+n2);
    }

}
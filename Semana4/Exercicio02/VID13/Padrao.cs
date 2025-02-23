using System;

abstract class Padrao // classe abstrata é um "padrao para o projeto" possuindo metodos obrigatorios ou opcionais
{
    // Obrigatorio
    public abstract void taxaEmprestimo(double valor);

    // Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor * taxa));
    }

}
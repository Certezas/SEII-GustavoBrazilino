using System;

class Atendente : Imposto
{

    
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$"+(salario * 0.12)); // para os atendentes o calculo do imposto é feito de modo diferente, apesar de "herdar" o metodo
    }
    
}
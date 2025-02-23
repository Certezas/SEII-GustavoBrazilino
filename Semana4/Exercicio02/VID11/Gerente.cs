using System;

class Gerente : Imposto
{
    
    // Método
    public override void valeAlimentacao(double salario) // tem q ter esse override
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$"+(salario * 0.15));
    }

}
using System;

class Colaborador : Pessoa // colaborador herda metodos e atributos de pessoa, desde que sejam do tipo public ou protected
{

    private double salario;

   
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

 
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }

}
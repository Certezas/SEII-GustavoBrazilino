﻿using System;

namespace _VID13
{
    class Program
    {
        // Classes abstratas nao podem ser instanciadas
        static void Main(string[] args)
        {
            
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);

            // nao deu nenhum problema em "calculoPoupanca" pq ele nao é obrigatorio, caso o "taxaEmprestimo" nao tivesse sendo utilizado por alguma das classes que o herdam, daria BO
        }
    }
}
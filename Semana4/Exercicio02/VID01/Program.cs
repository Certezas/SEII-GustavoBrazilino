﻿using System;

namespace _VID01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa obj = new Pessoa(); //pode utilizar Pessoa.Pessoa
            obj.nome = "Gustavo";
            obj.idade = 23;
            obj.mensagem();

        }
    }
}
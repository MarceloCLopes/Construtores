﻿namespace Construtores.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            Console.WriteLine("Construtor classe aluno!");
        }
    }
}

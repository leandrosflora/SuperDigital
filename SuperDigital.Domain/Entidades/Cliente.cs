using System;

namespace SuperDigital.Domain.Entidades
{
    public class Cliente
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public Conta Conta { get; set; }
    }
}
using System;

namespace SuperDigital.Domain.Entidades
{
    public class Cliente : Pessoa
    {
       
        public Conta Conta { get; set; }
    }
}
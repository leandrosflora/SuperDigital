using SuperDigital.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.Entidades
{
    public abstract class Pessoa
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        private DateTime _dateNascimento;

        public DateTime DataNascimento
        {
            get
            {
                return this._dateNascimento;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new DataInvalidaException();
                }
                else
                {
                    this._dateNascimento = value;
                }
            }
        }
    }
}

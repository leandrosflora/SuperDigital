using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Moq
{
    public class RepositorioBaseMoq<T> where T : class
    {
        public Mock<T> Mock { get; private set; }

        public RepositorioBaseMoq()
        {
            this.Mock = new Mock<T>();
        }
    }
}

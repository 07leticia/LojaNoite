using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class ProdutoInformatica
    {
        internal class VendaInformation
        {
            private int _nome;
            public int Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            private string _preco;
            public string Preco
            {
                get { return _preco; }
                set { _preco = value; }
            }
            private string _estoque;
            public string Estoque
            {
                get { return _estoque; }
                set { _estoque = value; }
            }
            private int _codigo;
            public int Codigo
            {
                get { return _codigo; }
                set { _codigo = value; }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class VendaInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private string _quantidade;
        public string Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private string _faturamento;
        public string Faturamento
        {
            get { return _faturamento; }
            set { _faturamento = value; }
        }
        private string _codigocliente;
        public string Codigocliente
        {
            get { return _codigocliente; }
            set { _codigocliente = value; }
        }
        private string _codigoproduto;
        public string Codigoproduto
        {
            get { return _codigoproduto; }
            set { _codigoproduto = value; }
        }
    }

} 

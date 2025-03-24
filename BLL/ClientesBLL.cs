using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using Microsoft.Data;
using Microsoft. Data. SqlClient;

namespace BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            // o nome do cliente e obrigatorio
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente e obrigatorio");
            }
            // E-mail sempre em minusculo
            cliente.Email = cliente.Email.ToLower();
            // se tudo ok, chama a rotina de inserçao
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);
        }
        public void Alterar(ClienteInformation cliente) 
        {
            // o nome do cliente e obrigatorio
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente e obrigatorio");
            }
            // E-mail sempre em minusculo
            cliente.Email = cliente.Email.ToLower();
            // se tudo ok, chama a rotina de inserçao
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        } 
        public void Excluir(int codigo)
        {
             if(codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de exclui-lo");
            }
        }

        
         
    }
}

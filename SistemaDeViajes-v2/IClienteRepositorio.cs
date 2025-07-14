using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public interface IClienteRepositorio
    {
        
            List<CLSCliente> GetAllClientes();
            void AddCliente(CLSCliente cliente);
            
            void DeleteCliente(int idcliente);
        
    }
}

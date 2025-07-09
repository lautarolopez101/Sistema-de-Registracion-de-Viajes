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
            // Puedes añadir otros métodos si los necesitas en el futuro, por ejemplo:
            // CLSCliente GetClienteByDNI(int dni);
            // void UpdateCliente(CLSCliente cliente);
            // void DeleteCliente(int id);
        
    }
}

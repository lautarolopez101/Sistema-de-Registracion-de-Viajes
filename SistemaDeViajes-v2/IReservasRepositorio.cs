using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public interface IReservasRepositorio
    {
        List<CLSReserva> GetAllReservas();
        void AddReserva(CLSReserva reserva);
        // Puedes añadir otros métodos si los necesitas en el futuro, por ejemplo:
        // List<CLSReserva> GetReservasByClienteId(int clienteId);
        // void UpdateReserva(CLSReserva reserva);
        // void DeleteReserva(int id);
    }
}

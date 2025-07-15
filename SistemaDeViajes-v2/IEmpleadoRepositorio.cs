using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public interface IEmpleadoRepositorio
    {

        List<CLSEmpleado> GetAllEmpleados();
        // Puedes añadir otros métodos si los necesitas, como AddEmpleado, etc.
    }
}

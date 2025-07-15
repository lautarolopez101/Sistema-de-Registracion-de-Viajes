using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class ArchivoClienteRepositorio : IClienteRepositorio
    {

        private readonly string _filePath = "clientes.txt";

        public List<CLSCliente> GetAllClientes()
        {
            List<CLSCliente> listaclientes = new List<CLSCliente>();

            listaclientes.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {

                    sr.ReadLine(); 

                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        try
                        {
                            // Llama al método privado del repositorio para parsear la línea
                            CLSCliente cliente = CreaClienteDesdeLinea(linea);
                            listaclientes.Add(cliente);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"Advertencia (ArchivoClienteRepositorio): Error de formato al leer línea: '{linea}'. Detalles: {ex.Message}. Saltando línea.");
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"Advertencia (ArchivoClienteRepositorio): Línea de cliente incompleta: '{linea}'. Detalles: {ex.Message}. Saltando línea.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar clientes desde el archivo: {ex.Message}", ex);
            }
            return listaclientes;
        }
        public void AddCliente(CLSCliente cliente)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(_filePath))
                {
                    sw.WriteLine(cliente.ToFileLine());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el cliente en el archivo: {ex.Message}", ex);
            }
        }

        public void DeleteCliente(int idCliente)
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException($"El archivo de clientes '{_filePath}' no se encontró para eliminar.");
            }

            List<CLSCliente> todosLosClientes = new List<CLSCliente>();
            string header = null; // Para guardar la cabecera si existe

            // Paso 1: Leer todos los clientes del archivo
            using (StreamReader sr = new StreamReader(_filePath))
            {
                // Leer la primera línea para ver si es una cabecera y la guarda
                header = sr.ReadLine();

                // Leer el resto de las líneas
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    try
                    {
                        todosLosClientes.Add(CreaClienteDesdeLinea(linea));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Advertencia: Error al parsear línea de cliente al eliminar: '{linea}'. Detalles: {ex.Message}. Saltando línea.");
                    }
                }
            }

            // Paso 2: Filtrar la lista para excluir al cliente que se va a eliminar
            List<CLSCliente> clientesActualizados = todosLosClientes
                                                        .Where(c => c.ID != idCliente) // Filtra por el ID
                                                        .ToList();

            // Verificar si el cliente realmente fue encontrado y eliminado
            if (clientesActualizados.Count == todosLosClientes.Count)
            {
                // Si las listas tienen el mismo tamaño, significa que el cliente con ese ID no se encontró
                throw new InvalidOperationException($"No se encontró ningún cliente con el ID '{idCliente}' para eliminar.");
            }

            // Paso 3: Reescribir todo el archivo con la lista actualizada (sin el cliente eliminado)
            using (StreamWriter sw = new StreamWriter(_filePath, false)) // 'false' para sobrescribir el archivo
            {
                // Si tenías una cabecera, la escribe denuevo 
                if (header != null)
                {
                    sw.WriteLine(header);
                }

                foreach (CLSCliente cliente in clientesActualizados)
                {
                    sw.WriteLine(cliente.ToFileLine());
                }
            }
        }

        public void ModificarCliente(CLSCliente clienteModificado)
        {
            if (clienteModificado == null)
            {
                throw new ArgumentNullException(nameof(clienteModificado), "El cliente a modificar no puede ser nulo.");
            }

            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException($"El archivo de clientes '{_filePath}' no se encontró para modificar.");
            }

            List<CLSCliente> todosLosClientes = new List<CLSCliente>();
            string header = null;

            // Paso 1: Leer todos los clientes del archivo
            using (StreamReader sr = new StreamReader(_filePath))
            {
                // Manejo de cabecera (puedes simplificarlo si siempre hay cabecera como discutimos)
                header = sr.ReadLine();

                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    try
                    {
                        todosLosClientes.Add(CreaClienteDesdeLinea(linea));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Advertencia: Error al parsear línea de cliente al modificar: '{linea}'. Detalles: {ex.Message}. Saltando línea.");
                    }
                }
            }

            // Paso 2: Encontrar el cliente a modificar y reemplazarlo
            bool clienteEncontrado = false;
            for (int i = 0; i < todosLosClientes.Count; i++)
            {
                if (todosLosClientes[i].ID == clienteModificado.ID)
                {
                    todosLosClientes[i] = clienteModificado; // Reemplazar el cliente existente con el modificado
                    clienteEncontrado = true;
                    break; // Salir del bucle una vez que el cliente es encontrado y modificado
                }
            }

            if (!clienteEncontrado)
            {
                throw new InvalidOperationException($"No se encontró ningún cliente con el ID '{clienteModificado.ID}' para modificar.");
            }

            // Paso 3: Reescribir todo el archivo con la lista actualizada
            using (StreamWriter sw = new StreamWriter(_filePath, false)) // 'false' para sobrescribir
            {
                if (header != null)
                {
                    sw.WriteLine(header);
                }
                foreach (CLSCliente cliente in todosLosClientes)
                {
                    sw.WriteLine(cliente.ToFileLine());
                }
            }
        }

        // Método privado auxiliar para crear un CLSCliente desde una línea de texto
        private CLSCliente CreaClienteDesdeLinea(string linea)
        {
            string[] vec = linea.Split(';');
            const int ExpectedFields = 7; // Nombre;Apellido;Mail;Telefono;Password;DNI;ID

            if (vec.Length < ExpectedFields)
            {
                throw new FormatException($"Línea de cliente incompleta o incorrecta (se esperaban {ExpectedFields} campos, se encontraron {vec.Length}): '{linea}'.");
            }

            int telefonoLeido, dniLeido, idLeido;
            bool telefonoOk = int.TryParse(vec[3].Trim(), out telefonoLeido);
            bool dniOk = int.TryParse(vec[5].Trim(), out dniLeido);
            bool idOk = int.TryParse(vec[6].Trim(), out idLeido);

            if (!telefonoOk || !dniOk || !idOk)
            {
                throw new FormatException($"Error al convertir datos numéricos de cliente en la línea: '{linea}'. Asegúrese de que Teléfono, DNI e ID sean números válidos.");
            }

            return new CLSCliente(
                vec[0].Trim(),      // Nombre
                vec[1].Trim(),      // Apellido
                vec[2].Trim(),      // Mail
                telefonoLeido,      // Telefono
                vec[4].Trim(),      // Password
                dniLeido,           // DNI
                idLeido             // ID
            );
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    // EventArgs personalizado para cuando la membresía supera la cuota neta
    public class MembresiaExcedeCuotaEventArgs : EventArgs
    {
        public decimal CuotaMensual { get; }
        public decimal ImporteMembresia { get; }

        public MembresiaExcedeCuotaEventArgs(decimal cuotaMensual, decimal importeMembresia)
        {
            CuotaMensual = cuotaMensual;
            ImporteMembresia = importeMembresia;
        }
    }

    public class GimnasioManager
    {
        // Listas en memoria (no persistente)
        public List<Cliente> Clientes { get; } = new List<Cliente>();
        public List<Membresia> Membresias { get; } = new List<Membresia>();

        // Evento que se dispara si la membresía excede la cuota neta
        public event EventHandler<MembresiaExcedeCuotaEventArgs> MembresiaExcedeCuota;

        // Agregar cliente (validaciones: nro socio, dni únicos)
        public void AgregarCliente(Cliente cliente)
        {
            if (Clientes.Any(c => c.NumeroDeSocio == cliente.NumeroDeSocio))
                throw new InvalidOperationException("Número de socio ya existe.");

            if (Clientes.Any(c => c.DNI == cliente.DNI))
                throw new InvalidOperationException("DNI ya existe.");

            Clientes.Add(cliente);
        }

        // Modificar cliente por nro de socio (mantiene unicidad de DNI)
        public void ModificarCliente(int nroSocio, Cliente datosActualizados)
        {
            var existente = Clientes.FirstOrDefault(c => c.NumeroDeSocio == nroSocio);
            if (existente == null) throw new InvalidOperationException("Cliente no encontrado.");

            if (Clientes.Any(c => c.DNI == datosActualizados.DNI && c.NumeroDeSocio != nroSocio))
                throw new InvalidOperationException("DNI ya existe en otro cliente.");

            // Actualizar propiedades relevantes (no tocar la referencia de objetos en listas)
            existente.Nombre = datosActualizados.Nombre;
            existente.Apellido = datosActualizados.Apellido;
            existente.DNI = datosActualizados.DNI;
            existente.Cuota = datosActualizados.Cuota;
            // Tipo de cliente: para cambiarlo, reemplazamos la instancia manteniendo la membresía si existiera
            if (existente.GetType() != datosActualizados.GetType())
            {
                var memb = existente.Membresia;
                datosActualizados.Membresia = memb;
                Clientes.Remove(existente);
                Clientes.Add(datosActualizados);
            }
        }

        public void EliminarCliente(int nroSocio)
        {
            var c = Clientes.FirstOrDefault(x => x.NumeroDeSocio == nroSocio);
            if (c == null) throw new InvalidOperationException("Cliente no encontrado.");
            // Si la membresía está asignada, la quitamos (la membresía sigue en el repositorio separada)
            c.Membresia = null;
            Clientes.Remove(c);
        }

        // Crear y asignar membresía: valida exclusividad de código y que no esté asignada a otro cliente
        public void CrearYAsignarMembresiaACliente(string codigo, DateTime fecha, decimal importe, int nroSocio)
        {
            if (Membresias.Any(memb => memb.Codigo == codigo))
                throw new InvalidOperationException("Código de membresía ya existe.");

            var cliente = Clientes.FirstOrDefault(c => c.NumeroDeSocio == nroSocio);
            if (cliente == null) throw new InvalidOperationException("Cliente no encontrado.");

            // Validar membresia con la regla de fecha y formato (llamamos al método estático)
            if (!Membresia.ValidarCodigo(codigo, fecha, out string error))
                throw new InvalidOperationException("Código inválido: " + error);

            // Calcular cuota neta = cuota - descuento por tipo
            decimal cuotaNeta = cliente.Cuota - cliente.ImporteDescuentoPorTipo();

            // Si importe > cuotaNeta -> disparar evento y NO asignar (según enunciado: se debe desencadenar evento)
            if (importe > cuotaNeta)
            {
                MembresiaExcedeCuota?.Invoke(this, new MembresiaExcedeCuotaEventArgs(cliente.Cuota, importe));
                return;
            }

            // Crear membresia y asignar
            var m = new Membresia { Codigo = codigo, FechaOtorgamiento = fecha.Date, Importe = importe };
            Membresias.Add(m);
            cliente.Membresia = m;
        }

        // Quitar membresía de un cliente (no elimina la membresía del repositorio necesariamente)
        public void QuitarMembresiaDeCliente(int nroSocio)
        {
            var cliente = Clientes.FirstOrDefault(c => c.NumeroDeSocio == nroSocio);
            if (cliente == null) throw new InvalidOperationException("Cliente no encontrado.");
            if (cliente.Membresia != null)
            {
                Membresias.Remove(cliente.Membresia);
                cliente.Membresia = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Membresia
    {
        public string Codigo { get; set; } // 15 caracteres: LLNN_dd/MM/yyyy (ej: AB12_01/03/2024)
        public DateTime FechaOtorgamiento { get; set; }
        public decimal Importe { get; set; }

        // Valida el formato y que la fecha dentro del código coincida con la fecha pasada
        public static bool ValidarCodigo(string codigo, DateTime fecha, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(codigo))
            {
                error = "Código vacío";
                return false;
            }

            if (codigo.Length != 15)
            {
                error = "El código debe tener exactamente 15 caracteres.";
                return false;
            }

            string letras = codigo.Substring(0, 2);
            string numeros = codigo.Substring(2, 2);
            string guion = codigo.Substring(4, 1);
            string fechaStr = codigo.Substring(5, 10); // dd/MM/yyyy

            if (!letras.All(char.IsLetter))
            {
                error = "Los primeros dos caracteres deben ser letras.";
                return false;
            }

            if (!numeros.All(char.IsDigit))
            {
                error = "Los caracteres 3 y 4 deben ser números.";
                return false;
            }

            if (guion != "_")
            {
                error = "El carácter 5 debe ser '_'.";
                return false;
            }

            if (!DateTime.TryParseExact(fechaStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaCodigo))
            {
                error = "La fecha dentro del código no tiene formato dd/MM/yyyy.";
                return false;
            }

            if (fechaCodigo.Date != fecha.Date)
            {
                error = "La fecha dentro del código debe coincidir con la fecha seleccionada.";
                return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco
{
    //[Serializable]
    public class RegistroSerializable
    {
        private int cuenta;
        private string primerNombre;
        private string apellidoPaterno;
        private decimal saldo;

        // el constructor sin parámetros, establece los miembros a los
        // valores predeterminados
        public RegistroSerializable() : this(0, "", "", 0.0M)
        {

        } // Fin del constructor

        // el constructor sobrecargado, establece los miembros a los
        // valores de los parámetros
        public RegistroSerializable(int valorCuenta, string valorPrimerNombre,
            string valorApellidoPaterno, decimal valorSaldo)
        {
            Cuenta = valorCuenta;
            PrimerNombre = valorPrimerNombre;
            ApellidoPaterno = valorApellidoPaterno;
            Saldo = valorSaldo;
        } // Fin del constructor

        // propiedades que obtienen y establecen las variables de clase
        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
    } // Fin de clase RegistroSerializable
}

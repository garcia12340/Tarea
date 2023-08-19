using BibliotecaBanco;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Consulta
{
    public partial class ConsultaCredito : Form
    {
        private FileStream entrada; // flujo para leer de un archivo
        private StreamReader archivoReader; // lee datos de un archivo de texto

        // nombre del archivo que almacena los saldos con crédito, débito o en cero
        private String nombreArchivo;

        // constructor sin parámetros
        public ConsultaCredito()
        {
            InitializeComponent();
        }// fin del constructor

        // se invoca cuando el usuario hace clic en el botón Abrir archivo
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // crea un cuadro de diálogo que permite al usuario abrir un archivo
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult result = selectorArchivo.ShowDialog();
            // sale del manejador de eventos si el usuario hace clic en Cancelar
            if (result == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName; // obtiene el nombre de archivo del usuario

            // muestra error si el usuario especificó un archivo inválido
            if (nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // crea objeto FileStream para obtener acceso de lectura al archivo
                entrada = new FileStream(nombreArchivo,
                    FileMode.Open, FileAccess.Read);

                // establece el archivo del que se van a leer los archivos
                archivoReader = new StreamReader(entrada);

                // habilita todos los botones de la GUI, excepto Abrir archivo
                btnAbrir.Enabled = false;
                btnCredito.Enabled = true;
                btnDebito.Enabled = true;
                btnSaldoCero.Enabled = true;
            }// fin de else
        }// fin del método abrirButton_Click

        // se invoca cuando el usuario hace clic en el botón de saldos con crédito,
        // saldos con débito o saldos en cero
        private void obtenerSaldos_Click(object sender, System.EventArgs e)
        {
            // convierte el emisor explícitamente a un objeto de tipo Button
            Button emisorButton = (Button)sender;

            // obtiene el texto del botón en el que se hizo clic, y que almacena el tipo de la cuenta
            string tipoCuenta = emisorButton.Text;

            // lee y muestra la información del archivo
            try
            {
                // regresa al principio del archivo
                entrada.Seek(0, SeekOrigin.Begin);

                richTextBox1.Text = "Las cuentas son:\r\n";
                //mostrarTextBox.Text = "Las cuentas son:\r\n";

                // recorre el archivo hasta llegar a su fin
                while (true)
                {
                    string[] camposEntrada; // almacena piezas de datos individuales
                    RegistroSerializable registro; // almacena cada Registro a medida que se lee el archivo
                    decimal saldo; // almacena el saldo de cada Registro

                    // obtiene el siguiente Registro disponible en el archivo
                    string registroEntrada = archivoReader.ReadLine();

                    // cuando está al final del archivo, sale del método
                    if (registroEntrada == null)
                        return;

                    camposEntrada = registroEntrada.Split(','); // analiza la entrada

                    // crea el Registro a partir de entrada
                    registro = new RegistroSerializable(
                        Convert.ToInt32(camposEntrada[0]), camposEntrada[1],
                        camposEntrada[2], Convert.ToDecimal(camposEntrada[3]));

                    // almacena el último campo del registro en saldo
                    saldo = registro.Saldo;

                    // determina si va a mostrar el saldo o no
                    if (DebeMostrar(saldo, tipoCuenta))
                    {
                        // muestra el registro
                        string salida = registro.Cuenta + "\t" +
                            registro.PrimerNombre + "\t" + registro.ApellidoPaterno + "\t";

                        // muestra el saldo con el formato monetario correcto
                        salida += String.Format("{0:F}", saldo) + "\r\n";

                        richTextBox1.Text += salida;
                        //mostrarTextBox.Text += salida; // copia la salida a la pantalla
                    }//fin de if
                }//fin de while
            }//fin del try
            // maneja la excepción cuando no puede leerse el archivo
            catch (IOException)
            {
                 MessageBox.Show( "No se puede leer el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
            }//fin de catch
        }// fin del método obtenerSaldos_Click

        // determina si se va a mostrar el registro dado
        private bool DebeMostrar(decimal saldo, string tipoCuenta)
        {
            if (saldo > 0)
            {
                // muestra los saldos con crédito
                if (tipoCuenta == "Saldos con crédito")
                    return true;
            }//fin de if
            else if(saldo < 0)
            {
                // mostrar los saldos con débito
                if (tipoCuenta == "Saldos con débito")
                    return true;
            } // fin de else if
            else// saldo == 0
            {
                // muestra los saldos en cero
                if (tipoCuenta == "Saldos en cero")
                    return true;
            } // fin de else 
            return false;
        }// fin del método DebeMostrar

        // se invoca cuando el usuario hace clic en el botón Terminar
        private void terminarButton_Click(object sender, EventArgs e)
        {
            // determina si existe el archivo o no
            if (entrada != null)
            {
                // cierra el archivo y el objeto StreamReader
                try
                {
                    entrada.Close();
                    archivoReader.Close();
                }// fin de try
                // maneja la excepción si el objeto FileStream no existe
                catch (IOException)
                {
                    // notifica al usuario del error al cerrar el archivo
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }// fin de catch
            } // fin de if

            Application.Exit();
        }// fin del método terminarButton_Click
    }// fin de la clase ConsultaCreditoForm
}

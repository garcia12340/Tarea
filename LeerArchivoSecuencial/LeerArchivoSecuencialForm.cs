using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBanco;

namespace LeerArchivoSecuencial
{
    public partial class LeerArchivoSecuencialForm : BancoUIForm
    {
        // objeto para deserializar el Registro en formato binario
        private BinaryFormatter lector = new BinaryFormatter();
        private FileStream entrada; // flujo para leer de un archivo

        // constructor sin parámetros
        public LeerArchivoSecuencialForm()
        {
            InitializeComponent();
        } // fin del constructor

        // se invoca cuando el usuario hace clic en el botón Abrir
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            // crea un cuadro de diálogo que permite al usuario abrir un archivo
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo; // nombre del archivo que contiene los datos

            // sale del manejador de eventos si el usuario hace clic en Cancelar
            if (resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName; // obtiene el nombre del archivo especificado
            LimpiarControlesTextBox();

            // muestra error si el usuario especificó un archibo inválido
            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // crea objeto FileStream para obtener acceso de lectura al archivo
                entrada = new FileStream(nombreArchivo, FileMode.Open,
                    FileAccess.Read);

                btnAbrir.Enabled = false; // deshabilita el botón abrir archivo
                btnSiguiente.Enabled = true; // habilita el botón Siguiente registro
            } // fin del else
        } // fin del método BtnAbrir_Click

        // se invoca cuando el usuario hace clic en el botón Siguiente
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            //deserializa el Registro y almacena los datos en controles TextBox
            try
            {
                // obtiene el siguiente RegistroSerializable disponible en el archivo
                RegistroSerializable registro = (RegistroSerializable)lector.Deserialize(entrada);

                // almacena los valores el Registro en un arreglo string temporal
                string[] valores = new string[] {
                    registro.Cuenta.ToString(),
                    registro.PrimerNombre.ToString(),
                    registro.ApellidoPaterno.ToString(),
                    registro.Saldo.ToString()
                };

                //copia los valores del arreglo string a los controles TextBox
                EstablecerValoresControlesTextBox(valores);
            } // fin de try
            // maneja la excepción cuando no hay registros en el archivo
            catch (SerializationException)
            {
                entrada.Close(); // cierra objeto FileStream si no hay registros en el archivo
                btnAbrir.Enabled = true; // habilita el botón abrir archivo
                btnSiguiente.Enabled = false; // deshabilita el botón Siguiente registro

                LimpiarControlesTextBox();

                // notifica al usuario si no hay registros en el archivo
                MessageBox.Show("No hay más registros en el archivo", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // fin de catch
        } // fin del método BtnSiguiente_Click
    } // fin de la clase LeerArchivoSecuencialForm
}

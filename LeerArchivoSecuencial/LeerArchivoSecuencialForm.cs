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
        private FileStream entrada; // flujo para leer de un archivo
        private StreamReader archivoReader; // lee datos de un archivo de texto

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

                // establece el archivo del que se van a leer los datos
                archivoReader = new StreamReader(entrada);

                btnAbrir.Enabled = false; // deshabilita el botón abrir archivo
                btnSiguiente.Enabled = true; // habilita el botón Siguiente registro
            } // fin del else
        } // fin del método BtnAbrir_Click

        // se invoca cuando el usuario hace clic en el botón Siguiente
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                // obtiene el siguiente Registro disponible en el archivo
                string registroEntrada = archivoReader.ReadLine();
                string[] camposEntrada; // almacena piezas individuales de datos

                if (registroEntrada != null)
                {
                    camposEntrada = registroEntrada.Split(',');
                    
                    RegistroSerializable registro = new RegistroSerializable(
                        Convert.ToInt32(camposEntrada[0]), camposEntrada[1],
                        camposEntrada[2], Convert.ToDecimal(camposEntrada[3]));

                    // copia los valores del arreglo string a los valores de los controles TextBox
                    EstablecerValoresControlesTextBox(camposEntrada);
                }//fin de if
                else
                {
                    archivoReader.Close(); // cierra StreamReader
                    entrada.Close(); // cierra FileStream si no hay registros en el archivo
                    btnAbrir.Enabled = true; // habilita el botón Abrir archivo
                    btnSiguiente.Enabled = false; // deshabilita el botón Siguiente registro

                    LimpiarControlesTextBox();

                    // notifica al usuario si no hay registros en el archivo
                    MessageBox.Show("No hay más registros en el archivo", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }// fin de else
            } // fin de try
            catch (IOException)
            {
                // notifica al usuario si no hay registros en el archivo
                MessageBox.Show("Error al leer del archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // fin de catch
        } // fin del método BtnSiguiente_Click

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ConsultaCreditoForm x = new ConsultaCreditoForm();
        //    x.ShowDialog();
        //}
    } // fin de la clase LeerArchivoSecuencialForm
}

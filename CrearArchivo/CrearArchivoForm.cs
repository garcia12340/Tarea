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

namespace CrearArchivo
{
    public partial class CrearArchivoForm : BancoUIForm
    {
        // objeto para serializar Registros en formato binario
        private BinaryFormatter aplicadorFormato = new BinaryFormatter();
        private FileStream salida; // mantiene la conexión con el archivo

        // constructor sin parámetros
        public CrearArchivoForm()
        {
            InitializeComponent();
        } // fin del constructor

        // manejador de eventos para el botón Guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // crea un cuadro de diálogo que permite al usuario guardar el
            // archivo
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            // nombre del archivo en el que se van a guardar los datos
            string nombreArchivo;

            // permite al usuario crear el archivo
            selectorArchivo.CheckFileExists = false;

            // sale del manejador de eventos si el usuario hace clic en
            // "Cancelar"
            if (resultado == DialogResult.Cancel)
                return;

            // obtiene el nombre del archivo especificado
            nombreArchivo = selectorArchivo.FileName;

            // muestra error si el usuario especificó un archivo inválido
            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // guarda el archivo mediante el objeto FileStream,
                // si el usuario especificó un archivo válido
                try
                {
                    // abre el archivo con acceso de escritura
                    salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate,
                        FileAccess.Write);

                    // deshabilita el botón Guardar y habilita el botón Introducir
                    btnGuardar.Enabled = false;
                    btnIntroducir.Enabled = true;
                } // fin de try
                // maneja la excepción si hay problema al abrir el archivo
                catch (IOException)
                {
                    // notifica al usuario si el archivo no existe
                    MessageBox.Show("Error al abrir el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fin de catch
            } // fin de else

        } // fin del método BtnGuardar_Click

        // manejador para el evento clic de BtnSalir_Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //determina si el archivo existe o no
            if(salida != null)
            {
                // cierra el archivo
                try
                {
                    salida.Close();
                } // fin de try
                // notifica al usuario del error al cerrar el archivo
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fin de catch
            } // fin de if 
            Application.Exit();
        } // fin del método BtnSalir_Click

        // manejador para el evento de BtnIntroducir_Click
        private void BtnIntroducir_Click(object sender, EventArgs e)
        {
            // almacena el arreglo string de valores de los controles TextBox 
            // a serializar
            string[] valores = ObtenerValoresControlesTexBox();

            // Registro que contiene los valores de los controles TextBox
            // a serializar
            RegistroSerializable registro = new RegistroSerializable();

            // determina si el campo del control TextBox de la cuenta está vacío
            if(valores[(int)IndicesTextBox.CUENTA] != "")
            {
                // almacena los valores de los controles TextBox en Registro
                // y lo serializa
                try
                {
                    // obtiene el valor del número de cuenta del control TextBox
                    int numeroCuenta = Int32.Parse(
                        valores[(int)IndicesTextBox.CUENTA]);

                    // determina si numeroCuenta es válido
                    if(numeroCuenta > 0)
                    {
                        // almacena los campos de los controles TextBox en Registro
                        registro.Cuenta = numeroCuenta;
                        registro.PrimerNombre = valores[(int)IndicesTextBox.NOMBRE];
                        registro.ApellidoPaterno = valores[(int)IndicesTextBox.APELLIDO];
                        registro.Saldo = Decimal.Parse(valores[(int)IndicesTextBox.SALDO]);

                        // escribe el registro al objeto FileStream (serializa el objeto)
                        aplicadorFormato.Serialize(salida, registro);
                    } // fin de if
                    else
                    {
                        // notifica al usuario si el número de cuenta es inválido
                        MessageBox.Show("Número de cuenta inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // fin del else
                } // fin de try
                // notifica al usuario si ocurre un error en la serialización
                catch (SerializationException)
                {
                    MessageBox.Show("Error al escribir en archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fin de catch
                // notifica al usuario si ocurre un error en relación con el formato 
                // de los parámetros
                catch (FormatException)
                {
                    MessageBox.Show("Formato inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // fin de catch
            } // fin de if

            LimpiarControlesTextBox(); // limpia los valores de los controles TextBox
        } // fin del método BtnIntroducir_Click
    } // fin de la clase CrearArchivoForm
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaBanco
{
    public partial class BancoUIForm : Form
    {
        // número de controles TextBox en el formulario
        protected int CuentaTextBox = 4;

        // las constantes de la enumeración especifican los índices de
        // los controles TexBox
        public enum IndicesTextBox
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO
        } // fin de enum

        // constructor sin parámetros
        public BancoUIForm()
        {
            InitializeComponent();
        } // fin del constructor

        // limpia todos los controles TextBox
        public void LimpiarControlesTextBox()
        {
            // itera a través de cada Control en el formulario
            for(int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i]; // obtiene el control

                // determina si el control es TextBox
                if(miControl is TextBox)
                {
                    // limpia la propiedad Text (establece cadena vacía)
                    miControl.Text = "";
                } // fin de if
            } // fin de for
        } // fin del método LimpiarControlesTextBox

        // establece los valores de los controles TextBox con el arreglo
        // string valores
        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            // determina si el arreglo string tiene la longitud correcta
            if(valores.Length != CuentaTextBox)
            {
                // lanza excepción si no tiene la longitud correcta
                throw (new ArgumentException("Debe haber " +
                    (CuentaTextBox + 1) + " objetos string en el arreglo"));
            } // fin de if
            // establece el arreglo valores si el arreglo tiene la longitud
            // correcta
            else
            {
                //establece el arreglo valores con los valores de los controles TextBox
                txtCuenta.Text = valores[(int)IndicesTextBox.CUENTA];
                txtPrimerNombre.Text = valores[(int)IndicesTextBox.NOMBRE];
                txtApellidoPaterno.Text = valores[(int)IndicesTextBox.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTextBox.SALDO];
            } // fin del else
        } // fin del método EstablecerValoresControlesTextBox

        // devuelve los valores de los controles TextBox como un arreglo string
        public string[] ObtenerValoresControlesTexBox()
        {
            string[] valores = new string[CuentaTextBox];

            // copia los campos de los controles TextBox al arreglo string
            valores[(int)IndicesTextBox.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTextBox.NOMBRE] = txtPrimerNombre.Text;
            valores[(int)IndicesTextBox.APELLIDO] = txtApellidoPaterno.Text;
            valores[(int)IndicesTextBox.SALDO] = txtSaldo.Text;

            return valores;
        } // fin del método ObtenerValoresControlesTexBox
    } // fin de la clase BancoUIForm
}

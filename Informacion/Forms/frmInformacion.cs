#region Formulario
#region Usos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class frmInformacion : Form
    {
        #region Variables Globales
        int Masculino = 0;
        int Femenino = 0;
        int i;
        int x = 0;
        #endregion

        //Finalizado
        #region Inisializando Formulario Informacion
        public frmInformacion()
        {
            InitializeComponent();
        }
        #endregion

        //Falta
        #region Tool Strip Boton Registrar Click
        private void TsbRegistrar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            int Edad = int.Parse(txtEdad.Text);
            string Sexo = "";

            if (rbMasculino.Checked == true) Sexo = "Masculino";
            if (rbFemenino.Checked == true) Sexo = "Femenino";

            if (Sexo == "")
            {
                MessageBox.Show("Debe Seleccionar su Sexo..!!", "Informacion");
                return;
            }

            switch (Sexo)
            {
                case "Masculino": Masculino = Masculino+1;
                    break;
                case "Femenino": Femenino = Femenino+1;
                    break;
            }

            ListViewItem Fila = new ListViewItem(Nombre);
            Fila.SubItems.Add(Edad.ToString());
            Fila.SubItems.Add(Sexo);

            TsbCancelar_Click(sender, e);
        }
        #endregion

        //Falta
        #region Tool Strip Boton Calcular Click
        private void TsbCalcular_Click(object sender, EventArgs e)
        {
            
            for (i = 0; i < x ; i++)
            {

            }

        }
        #endregion

        //Finalizado
        #region Tool Strip Boton Cancelar Click
        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtNombre.Focus();
        }
        #endregion

        //Finalizado
        #region Tool Strip Boton Salir Click
        private void TsbSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Informacion",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }
        #endregion

        #region Codigo por Agregar
        //Edad Promedio:
        //int EdadPromedio;
        //int Edades = 0;
        //Edades + Edad = Edades;
        //Edades/x = EdadPromedio;

        //Nombre del Profesor Más Joven:
        //string ProfesorMasJoven = "";
        //
        //Nombre del Profesor Más Viejo:
        //string ProfesorMasViejo = "";
        //
        //Numero de Profesoras que Tienen una Edad Mayor al Promedio:
        //int ProfesorasMayorP = 0;
        //
        //Numero de Profesores que Tienen una Edad Menor al Promedio:
        //int ProfesoresMenorP = 0;
        //
        //
        //
        //MessageBox.Show("La Edad Promedio de los Profesores es de: "+EdadPromedio+" Años", 
        //"El Profesor Más Joven es: "+ProfesorMasJoven, 
        //"El Profesor con Mayor Edad es: "+ProfesorMasViejo,
        //"El Número de Profesoras Mayor al Promedio es: "+ProfesorasMayorP,
        //"El Número de Profesores Menor al Promedio es: "+ProfesoresMenorP, MessageBoxButtons.Ok, MessageBoxIcon.---);
        #endregion
    }
}
#endregion
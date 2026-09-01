using System.Diagnostics.Eventing.Reader;

namespace actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //================================
            //1.-Validar el nombre
            //================================
            if (string.IsNullOrWhiteSpace(textnombre.Text))
            {
                MessageBox.Show(
                    "Por favor, escribe tu nombre.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textnombre.Focus();
            }
            //===============================
            // 2.-Obtener las actividades seleccionadas.
            //===============================
            List<string> actividades = new List<string>();

            if (btndeportes.Checked)
            {
                actividades.Add("Deportes");
            }
            if (btnmusica.Checked)
            {
                actividades.Add("Musica");
            }
            if (btnarte.Checked)
            {
                actividades.Add("Arte");
            }
            if (btnprogra.Checked)
            {
                actividades.Add("Programacion");
            }
            if (btnlectura.Checked)
            {
                actividades.Add("Lectura");
            }
            //=================================
            // 3.-Comprobar que se seleccione al menos una actividad
            //=================================
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una actividad",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //=================================
            // 4.-Obtener la modalidad seleccionada
            //=================================
            string modalidad = "";
            if (btnpresencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (btnhibrida.Checked)
            {
                modalidad = "Hibrida";
            }
            else if (btnenlinea.Checked)
            {
                modalidad = "En linea";
            }
            //=================================
            // 5.-validar que se haya seleccionado una modalidad
            //=================================
            else if (string.IsNullOrWhiteSpace(modalidad))
            {
                MessageBox.Show("selecciona una modalidad",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //=================================
            // 6.-Mostrar los datos en el texto
            //=================================
            string resumen =
                "RESUMEN DE PREFERENCIAS\r\n" +
                "--------------------------\r\n" +
                "Nombre: " + textnombre.Text + "\r\n" +
                "Actividad: " + string.Join(",", actividades) + "\r\n" +
                "Modalidades: " + modalidad;
            textresumen.Text = resumen;
        }

        private void btnpresencial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //limpiar nombre
            textnombre.Clear();
            //desmarcar check box
            btndeportes.Checked = false;
            btnmusica.Checked = false;
            btnarte.Checked = false;
            btnprogra.Checked = false;
            btnlectura.Checked = false;
            //desmarcar radio button
            btnpresencial.Checked = false;
            btnhibrida.Checked = false;
            btnenlinea.Checked = false;
            //limpiar resumen
            textresumen.Clear();
            //poner el foco en el nombre
            textnombre.Focus();
        }
    }
}

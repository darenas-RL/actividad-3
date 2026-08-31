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
            if(string.IsNullOrWhiteSpace(textnombre.Text))
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
            //===============================
            // 3.-Comprobar que se seleccione al menos una actividad
            //===============================
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una actividad",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);     
            }
        }
    }
}

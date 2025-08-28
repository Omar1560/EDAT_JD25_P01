namespace UI.NumerosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            (string nombres, string Genero)[] personas = { ("Omar","Masculino"), ("David", "Masculino"), 
                ("Oscar", "Masculino"), ("Marco", "Masculino" ),("Helena","Femenino"),("Ana","Femenino"), 
                ("Michelle","Femenino"), ("Melissa","Femenino") };
            Masculino.Checked = false;
            Femenino.Checked = false;
            int numero = rnd.Next(1, 101);
            int dia = rnd.Next(1, 32);
            int mes = rnd.Next(1, 13);
            int año = rnd.Next(1970, 2008);
            int grupo = rnd.Next(1, 6);
            int sueldo = rnd.Next(278,10001);
            int seguro = rnd.Next(0, 1);
            if (seguro == 0) { Seguro.Checked = false; }
            else { Seguro.Checked = true; }
            int indice = rnd.Next(personas.Length);
            var genero = personas[indice];
            if (genero.Genero == "Masculino")
            { Masculino.Checked = true; }
            else { Femenino.Checked = true; }
            Numero.Text = numero.ToString();
            Dia.Text = dia.ToString();
            Mes.Text = mes.ToString();
            Año.Text = año.ToString();
            Nombre.Text = genero.nombres;
            Grupo.Text = grupo.ToString();
            Sueldo.Text = "$" + sueldo.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

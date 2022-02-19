namespace EjercicioNumero2
{
    public partial class Arreglo : Form
    {
        public Arreglo()
        {
            InitializeComponent();
        }
        //arreglos
        string[] arregloNombres = new string[10];
        int[] arregloEdad = new int[10];
        int i = 0;//variable para la posición

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            if (i < arregloEdad.Length && i < arregloNombres.Length)//condición de límite de los arreglos
            {
                arregloEdad[i] = Convert.ToInt32(EdadTextBox.Text);//convertir en entero la caja de texto

                arregloNombres[i] = Convert.ToString(NombreTextBox.Text);

                comboBox1.Items.Add(NombreTextBox.Text + "/ "+EdadTextBox.Text);//agregar los datos ingresados al comboBox concatenado
                NombreTextBox.Text = "";//quitar valores de las cajas de texto
                EdadTextBox.Text = "";
                AvisoIngreso.Text = "Ahora puede agregar un nuevo estudiante...";
                i++;//aumenta en uno

                if (i == arregloEdad.Length && i == arregloNombres.Length)//condición cuando se alcance el límite de los arrreglos
                {
                    MessageBox.Show("La lista de estudiantes está completa!(10)");
                    AvisoIngreso.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("No se permite agregar más estudiantes. "+i+" máximo");//de no cumplir, avisará
                AvisoIngreso.Text = " ";
                NombreTextBox.Text = "";
                EdadTextBox.Text = "";
            }


        }


    }
}
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
        int i = 0;//variable para la posici�n

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            if (i < arregloEdad.Length && i < arregloNombres.Length)//condici�n de l�mite de los arreglos
            {
                arregloEdad[i] = Convert.ToInt32(EdadTextBox.Text);//convertir en entero la caja de texto

                arregloNombres[i] = Convert.ToString(NombreTextBox.Text);

                comboBox1.Items.Add(NombreTextBox.Text + "/ "+EdadTextBox.Text);//agregar los datos ingresados al comboBox concatenado
                NombreTextBox.Text = "";//quitar valores de las cajas de texto
                EdadTextBox.Text = "";
                AvisoIngreso.Text = "Ahora puede agregar un nuevo estudiante...";
                i++;//aumenta en uno

                if (i == arregloEdad.Length && i == arregloNombres.Length)//condici�n cuando se alcance el l�mite de los arrreglos
                {
                    MessageBox.Show("La lista de estudiantes est� completa!(10)");
                    AvisoIngreso.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("No se permite agregar m�s estudiantes. "+i+" m�ximo");//de no cumplir, avisar�
                AvisoIngreso.Text = " ";
                NombreTextBox.Text = "";
                EdadTextBox.Text = "";
            }


        }


    }
}
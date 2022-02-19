namespace EjercicioNumero2
{
    partial class Arreglo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvisoIngreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(259, 191);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.NombreTextBox.TabIndex = 0;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(583, 333);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(133, 34);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.Text = "Agregar estudiante";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(259, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(259, 279);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(100, 23);
            this.EdadTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(166, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datos del estudiante";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(506, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Nombre / Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(507, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estudiantes agregados";
            // 
            // AvisoIngreso
            // 
            this.AvisoIngreso.AutoSize = true;
            this.AvisoIngreso.Location = new System.Drawing.Point(217, 355);
            this.AvisoIngreso.Name = "AvisoIngreso";
            this.AvisoIngreso.Size = new System.Drawing.Size(0, 15);
            this.AvisoIngreso.TabIndex = 10;
            // 
            // Arreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvisoIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "Arreglo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NombreTextBox;
        private Button AgregarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EdadTextBox;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Label AvisoIngreso;
    }
}
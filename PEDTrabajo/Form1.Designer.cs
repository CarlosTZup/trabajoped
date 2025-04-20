namespace PEDTrabajo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            NombreAlarma = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            panel4 = new Panel();
            LabelTime = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(105, 221);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 0;
            button1.Text = "Ver Alarmas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(799, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 498);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(122, 442);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(105, 265);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 3;
            button2.Text = "Configurar Hora";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(NombreAlarma);
            panel2.Location = new Point(27, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 128);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSalmon;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(78, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 76);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 4);
            label3.Name = "label3";
            label3.Size = new Size(116, 62);
            label3.TabIndex = 0;
            label3.Text = "16:30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Hora";
            // 
            // NombreAlarma
            // 
            NombreAlarma.AutoSize = true;
            NombreAlarma.Location = new Point(95, 9);
            NombreAlarma.Name = "NombreAlarma";
            NombreAlarma.Size = new Size(112, 20);
            NombreAlarma.TabIndex = 0;
            NombreAlarma.Text = "NombreAlarma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 11);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Siguiente Alarma";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(254, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 12);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(LabelTime);
            panel4.Location = new Point(44, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(693, 314);
            panel4.TabIndex = 4;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Font = new Font("Consolas", 48F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTime.Location = new Point(96, 99);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(260, 94);
            LabelTime.TabIndex = 0;
            LabelTime.Text = "16:20";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1143, 523);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label NombreAlarma;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Label LabelTime;
    }
}
namespace PEDTrabajo
{
    partial class Alarma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            idbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            tiempobox = new TextBox();
            nombrebox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            checkedListBox1 = new CheckedListBox();
            label5 = new Label();
            LabelClock = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 204);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Hora";
            // 
            // button4
            // 
            button4.Location = new Point(272, 408);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 24;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(105, 408);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 23;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(272, 349);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 22;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(494, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(546, 356);
            dataGridView1.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(102, 349);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 20;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // idbox
            // 
            idbox.Location = new Point(102, 97);
            idbox.Name = "idbox";
            idbox.Size = new Size(125, 27);
            idbox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 74);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 18;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 65);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 17;
            label2.Text = "Dias que se repite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 140);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 16;
            label4.Text = "Nombre";
            // 
            // tiempobox
            // 
            tiempobox.Location = new Point(102, 227);
            tiempobox.Name = "tiempobox";
            tiempobox.Size = new Size(125, 27);
            tiempobox.TabIndex = 15;
            // 
            // nombrebox
            // 
            nombrebox.Location = new Point(102, 163);
            nombrebox.Name = "nombrebox";
            nombrebox.Size = new Size(125, 27);
            nombrebox.TabIndex = 14;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            checkedListBox1.Location = new Point(272, 97);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 158);
            checkedListBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(717, 9);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 26;
            label5.Text = "Fecha";
            // 
            // LabelClock
            // 
            LabelClock.AutoSize = true;
            LabelClock.BackColor = SystemColors.ControlLightLight;
            LabelClock.Font = new Font("Consolas", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LabelClock.Location = new Point(675, 32);
            LabelClock.Name = "LabelClock";
            LabelClock.Size = new Size(142, 51);
            LabelClock.TabIndex = 27;
            LabelClock.Text = "16:20";
            // 
            // Alarma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 494);
            Controls.Add(LabelClock);
            Controls.Add(label5);
            Controls.Add(checkedListBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(idbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(tiempobox);
            Controls.Add(nombrebox);
            Controls.Add(label1);
            Name = "Alarma";
            Text = "alarma";
            FormClosed += AlarmaClosed;
            Load += Alarma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button5;
        private TextBox idbox;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox tiempobox;
        private TextBox nombrebox;
        private System.Windows.Forms.Timer timer1;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private Label LabelClock;
    }
}
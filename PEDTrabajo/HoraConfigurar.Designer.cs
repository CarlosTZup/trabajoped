namespace PEDTrabajo
{
    partial class HoraConfigurar
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
            label2 = new Label();
            label3 = new Label();
            HoramasButton = new Button();
            HoramenosButton = new Button();
            MinutomenosButton = new Button();
            MinutomasButton = new Button();
            SegundomenosButton = new Button();
            SegundomasButton = new Button();
            LabelTime = new Label();
            labelNewTime = new Label();
            AceptarButton = new Button();
            CancelarButton = new Button();
            Regresar = new Button();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 174);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 174);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Minuto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 174);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Segundo";
            // 
            // HoramasButton
            // 
            HoramasButton.Location = new Point(72, 114);
            HoramasButton.Name = "HoramasButton";
            HoramasButton.Size = new Size(94, 29);
            HoramasButton.TabIndex = 3;
            HoramasButton.Text = "MAS";
            HoramasButton.UseVisualStyleBackColor = true;
            HoramasButton.Click += HoramasButton_Click;
            // 
            // HoramenosButton
            // 
            HoramenosButton.Location = new Point(72, 224);
            HoramenosButton.Name = "HoramenosButton";
            HoramenosButton.Size = new Size(94, 29);
            HoramenosButton.TabIndex = 4;
            HoramenosButton.Text = "MENOS";
            HoramenosButton.UseVisualStyleBackColor = true;
            HoramenosButton.Click += HoramenosButton_Click;
            // 
            // MinutomenosButton
            // 
            MinutomenosButton.Location = new Point(231, 224);
            MinutomenosButton.Name = "MinutomenosButton";
            MinutomenosButton.Size = new Size(94, 29);
            MinutomenosButton.TabIndex = 6;
            MinutomenosButton.Text = "MENOS";
            MinutomenosButton.UseVisualStyleBackColor = true;
            MinutomenosButton.Click += MinutomenosButton_Click;
            // 
            // MinutomasButton
            // 
            MinutomasButton.Location = new Point(231, 114);
            MinutomasButton.Name = "MinutomasButton";
            MinutomasButton.Size = new Size(94, 29);
            MinutomasButton.TabIndex = 5;
            MinutomasButton.Text = "MAS";
            MinutomasButton.UseVisualStyleBackColor = true;
            MinutomasButton.Click += MinutomasButton_Click;
            // 
            // SegundomenosButton
            // 
            SegundomenosButton.Location = new Point(375, 224);
            SegundomenosButton.Name = "SegundomenosButton";
            SegundomenosButton.Size = new Size(94, 29);
            SegundomenosButton.TabIndex = 8;
            SegundomenosButton.Text = "MENOS";
            SegundomenosButton.UseVisualStyleBackColor = true;
            SegundomenosButton.Click += SegundomenosButton_Click;
            // 
            // SegundomasButton
            // 
            SegundomasButton.Location = new Point(375, 114);
            SegundomasButton.Name = "SegundomasButton";
            SegundomasButton.Size = new Size(94, 29);
            SegundomasButton.TabIndex = 7;
            SegundomasButton.Text = "MAS";
            SegundomasButton.UseVisualStyleBackColor = true;
            SegundomasButton.Click += SegundomasButton_Click;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Font = new Font("Consolas", 48F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTime.Location = new Point(578, 60);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(260, 94);
            LabelTime.TabIndex = 9;
            LabelTime.Text = "16:20";
            // 
            // labelNewTime
            // 
            labelNewTime.AutoSize = true;
            labelNewTime.Font = new Font("Consolas", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelNewTime.Location = new Point(578, 278);
            labelNewTime.Name = "labelNewTime";
            labelNewTime.Size = new Size(260, 94);
            labelNewTime.TabIndex = 10;
            labelNewTime.Text = "16:20";
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(589, 375);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(94, 29);
            AceptarButton.TabIndex = 11;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            AceptarButton.Click += AceptarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(725, 375);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(94, 29);
            CancelarButton.TabIndex = 12;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // Regresar
            // 
            Regresar.Location = new Point(232, 375);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(94, 29);
            Regresar.TabIndex = 13;
            Regresar.Text = "Regresar";
            Regresar.UseVisualStyleBackColor = true;
            Regresar.Click += Regresar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(517, 9);
            label4.Name = "label4";
            label4.Size = new Size(388, 55);
            label4.TabIndex = 14;
            label4.Text = "Tiempo Actual:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(517, 223);
            label5.Name = "label5";
            label5.Size = new Size(362, 55);
            label5.TabIndex = 15;
            label5.Text = "Tiempo Nuevo:";
            label5.Click += label5_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // HoraConfigurar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 459);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Regresar);
            Controls.Add(CancelarButton);
            Controls.Add(AceptarButton);
            Controls.Add(labelNewTime);
            Controls.Add(LabelTime);
            Controls.Add(SegundomenosButton);
            Controls.Add(SegundomasButton);
            Controls.Add(MinutomenosButton);
            Controls.Add(MinutomasButton);
            Controls.Add(HoramenosButton);
            Controls.Add(HoramasButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HoraConfigurar";
            Text = "HoraConfigurar";
            FormClosed += HoraClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button HoramasButton;
        private Button HoramenosButton;
        private Button MinutomenosButton;
        private Button MinutomasButton;
        private Button SegundomenosButton;
        private Button SegundomasButton;
        private Label LabelTime;
        private Label labelNewTime;
        private Button AceptarButton;
        private Button CancelarButton;
        private Button Regresar;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}
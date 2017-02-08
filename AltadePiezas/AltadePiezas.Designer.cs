namespace AltadePiezas
{
    partial class AltadePiezas
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCiclos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonSiAprobado = new System.Windows.Forms.RadioButton();
            this.radioButtonNoAprobado = new System.Windows.Forms.RadioButton();
            this.comboBoxDefecto = new System.Windows.Forms.ComboBox();
            this.textBoxSerie = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelDefecto = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSerieRango = new System.Windows.Forms.TextBox();
            this.radioButtonNoR = new System.Windows.Forms.RadioButton();
            this.radioButtonSiR = new System.Windows.Forms.RadioButton();
            this.labelRebraze = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxRebraze = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxRebraze.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(324, 140);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(15, 38);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de horneo:";
            // 
            // comboBoxCiclos
            // 
            this.comboBoxCiclos.Enabled = false;
            this.comboBoxCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCiclos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxCiclos.FormattingEnabled = true;
            this.comboBoxCiclos.Location = new System.Drawing.Point(430, 146);
            this.comboBoxCiclos.Name = "comboBoxCiclos";
            this.comboBoxCiclos.Size = new System.Drawing.Size(68, 33);
            this.comboBoxCiclos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciclo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Serie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aprobado:";
            // 
            // radioButtonSiAprobado
            // 
            this.radioButtonSiAprobado.AutoSize = true;
            this.radioButtonSiAprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSiAprobado.ForeColor = System.Drawing.Color.White;
            this.radioButtonSiAprobado.Location = new System.Drawing.Point(53, 8);
            this.radioButtonSiAprobado.Name = "radioButtonSiAprobado";
            this.radioButtonSiAprobado.Size = new System.Drawing.Size(53, 33);
            this.radioButtonSiAprobado.TabIndex = 7;
            this.radioButtonSiAprobado.TabStop = true;
            this.radioButtonSiAprobado.Text = "Si";
            this.radioButtonSiAprobado.UseVisualStyleBackColor = true;
            this.radioButtonSiAprobado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonNoAprobado
            // 
            this.radioButtonNoAprobado.AutoSize = true;
            this.radioButtonNoAprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoAprobado.ForeColor = System.Drawing.Color.White;
            this.radioButtonNoAprobado.Location = new System.Drawing.Point(233, 8);
            this.radioButtonNoAprobado.Name = "radioButtonNoAprobado";
            this.radioButtonNoAprobado.Size = new System.Drawing.Size(63, 33);
            this.radioButtonNoAprobado.TabIndex = 8;
            this.radioButtonNoAprobado.TabStop = true;
            this.radioButtonNoAprobado.Text = "No";
            this.radioButtonNoAprobado.UseVisualStyleBackColor = true;
            this.radioButtonNoAprobado.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBoxDefecto
            // 
            this.comboBoxDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDefecto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxDefecto.FormattingEnabled = true;
            this.comboBoxDefecto.Location = new System.Drawing.Point(173, 309);
            this.comboBoxDefecto.Name = "comboBoxDefecto";
            this.comboBoxDefecto.Size = new System.Drawing.Size(325, 33);
            this.comboBoxDefecto.TabIndex = 9;
            this.comboBoxDefecto.Visible = false;
            // 
            // textBoxSerie
            // 
            this.textBoxSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSerie.Location = new System.Drawing.Point(173, 206);
            this.textBoxSerie.Name = "textBoxSerie";
            this.textBoxSerie.Size = new System.Drawing.Size(133, 31);
            this.textBoxSerie.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(297, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(105, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 39);
            this.button3.TabIndex = 17;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelDefecto
            // 
            this.labelDefecto.AutoSize = true;
            this.labelDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefecto.ForeColor = System.Drawing.Color.White;
            this.labelDefecto.Location = new System.Drawing.Point(32, 310);
            this.labelDefecto.Name = "labelDefecto";
            this.labelDefecto.Size = new System.Drawing.Size(117, 31);
            this.labelDefecto.TabIndex = 18;
            this.labelDefecto.Text = "Defecto:";
            this.labelDefecto.Visible = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(168, 150);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(80, 25);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "--/--/----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = ">";
            // 
            // textBoxSerieRango
            // 
            this.textBoxSerieRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerieRango.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSerieRango.Location = new System.Drawing.Point(358, 206);
            this.textBoxSerieRango.Name = "textBoxSerieRango";
            this.textBoxSerieRango.Size = new System.Drawing.Size(140, 31);
            this.textBoxSerieRango.TabIndex = 21;
            this.textBoxSerieRango.Visible = false;
            // 
            // radioButtonNoR
            // 
            this.radioButtonNoR.AutoSize = true;
            this.radioButtonNoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoR.ForeColor = System.Drawing.Color.White;
            this.radioButtonNoR.Location = new System.Drawing.Point(233, 7);
            this.radioButtonNoR.Name = "radioButtonNoR";
            this.radioButtonNoR.Size = new System.Drawing.Size(63, 33);
            this.radioButtonNoR.TabIndex = 25;
            this.radioButtonNoR.TabStop = true;
            this.radioButtonNoR.Text = "No";
            this.radioButtonNoR.UseVisualStyleBackColor = true;
            this.radioButtonNoR.Visible = false;
            // 
            // radioButtonSiR
            // 
            this.radioButtonSiR.AutoSize = true;
            this.radioButtonSiR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSiR.ForeColor = System.Drawing.Color.White;
            this.radioButtonSiR.Location = new System.Drawing.Point(53, 7);
            this.radioButtonSiR.Name = "radioButtonSiR";
            this.radioButtonSiR.Size = new System.Drawing.Size(53, 33);
            this.radioButtonSiR.TabIndex = 24;
            this.radioButtonSiR.TabStop = true;
            this.radioButtonSiR.Text = "Si";
            this.radioButtonSiR.UseVisualStyleBackColor = true;
            this.radioButtonSiR.Visible = false;
            // 
            // labelRebraze
            // 
            this.labelRebraze.AutoSize = true;
            this.labelRebraze.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRebraze.ForeColor = System.Drawing.Color.White;
            this.labelRebraze.Location = new System.Drawing.Point(32, 357);
            this.labelRebraze.Name = "labelRebraze";
            this.labelRebraze.Size = new System.Drawing.Size(125, 31);
            this.labelRebraze.TabIndex = 23;
            this.labelRebraze.Text = "Rebraze:";
            this.labelRebraze.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "Alta de Piezas";
            // 
            // buttonMas
            // 
            this.buttonMas.BackColor = System.Drawing.Color.Red;
            this.buttonMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMas.Location = new System.Drawing.Point(316, 205);
            this.buttonMas.Name = "buttonMas";
            this.buttonMas.Size = new System.Drawing.Size(32, 33);
            this.buttonMas.TabIndex = 27;
            this.buttonMas.Text = "+";
            this.buttonMas.UseVisualStyleBackColor = false;
            this.buttonMas.Click += new System.EventHandler(this.buttonMas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AltadePiezas.Properties.Resources.joniwel11;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNoAprobado);
            this.groupBox1.Controls.Add(this.radioButtonSiAprobado);
            this.groupBox1.Location = new System.Drawing.Point(173, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 44);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxRebraze
            // 
            this.groupBoxRebraze.Controls.Add(this.radioButtonNoR);
            this.groupBoxRebraze.Controls.Add(this.radioButtonSiR);
            this.groupBoxRebraze.Location = new System.Drawing.Point(173, 350);
            this.groupBoxRebraze.Name = "groupBoxRebraze";
            this.groupBoxRebraze.Size = new System.Drawing.Size(325, 44);
            this.groupBoxRebraze.TabIndex = 30;
            this.groupBoxRebraze.TabStop = false;
            this.groupBoxRebraze.Visible = false;
            // 
            // AltadePiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(541, 467);
            this.Controls.Add(this.groupBoxRebraze);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRebraze);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSerieRango);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelDefecto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxSerie);
            this.Controls.Add(this.comboBoxDefecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCiclos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AltadePiezas";
            this.Text = "Alta de Piezas";
            this.Load += new System.EventHandler(this.AltadePiezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRebraze.ResumeLayout(false);
            this.groupBoxRebraze.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCiclos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonSiAprobado;
        private System.Windows.Forms.RadioButton radioButtonNoAprobado;
        private System.Windows.Forms.ComboBox comboBoxDefecto;
        private System.Windows.Forms.TextBox textBoxSerie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelDefecto;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSerieRango;
        private System.Windows.Forms.RadioButton radioButtonNoR;
        private System.Windows.Forms.RadioButton radioButtonSiR;
        private System.Windows.Forms.Label labelRebraze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxRebraze;
    }
}


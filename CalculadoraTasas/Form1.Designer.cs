namespace CalculadoraTasas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.lblMontoInicial = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rbtnMensual = new System.Windows.Forms.RadioButton();
            this.rbtnSemanal = new System.Windows.Forms.RadioButton();
            this.rbtnDiario = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSin = new System.Windows.Forms.RadioButton();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaysDifference = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnFinalizar = new System.Windows.Forms.RadioButton();
            this.rbtnExtraer = new System.Windows.Forms.RadioButton();
            this.rbtnAgregar = new System.Windows.Forms.RadioButton();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMontoInicial.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoInicial.Location = new System.Drawing.Point(280, 43);
            this.txtMontoInicial.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(186, 23);
            this.txtMontoInicial.TabIndex = 0;
            this.txtMontoInicial.TextChanged += new System.EventHandler(this.txtMontoInicial_TextChanged);
            // 
            // lblMontoInicial
            // 
            this.lblMontoInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMontoInicial.AutoSize = true;
            this.lblMontoInicial.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoInicial.Location = new System.Drawing.Point(167, 43);
            this.lblMontoInicial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMontoInicial.Name = "lblMontoInicial";
            this.lblMontoInicial.Size = new System.Drawing.Size(100, 16);
            this.lblMontoInicial.TabIndex = 1;
            this.lblMontoInicial.Text = "Monto Inicial";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(280, 75);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(186, 23);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(150, 75);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Inicio";
            // 
            // rbtnMensual
            // 
            this.rbtnMensual.AutoSize = true;
            this.rbtnMensual.Location = new System.Drawing.Point(4, 26);
            this.rbtnMensual.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rbtnMensual.Name = "rbtnMensual";
            this.rbtnMensual.Size = new System.Drawing.Size(85, 20);
            this.rbtnMensual.TabIndex = 4;
            this.rbtnMensual.TabStop = true;
            this.rbtnMensual.Text = "Mensual";
            this.rbtnMensual.UseVisualStyleBackColor = true;
            // 
            // rbtnSemanal
            // 
            this.rbtnSemanal.AutoSize = true;
            this.rbtnSemanal.Location = new System.Drawing.Point(112, 26);
            this.rbtnSemanal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rbtnSemanal.Name = "rbtnSemanal";
            this.rbtnSemanal.Size = new System.Drawing.Size(88, 20);
            this.rbtnSemanal.TabIndex = 5;
            this.rbtnSemanal.TabStop = true;
            this.rbtnSemanal.Text = "Semanal";
            this.rbtnSemanal.UseVisualStyleBackColor = true;
            // 
            // rbtnDiario
            // 
            this.rbtnDiario.AutoSize = true;
            this.rbtnDiario.Location = new System.Drawing.Point(222, 26);
            this.rbtnDiario.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rbtnDiario.Name = "rbtnDiario";
            this.rbtnDiario.Size = new System.Drawing.Size(67, 20);
            this.rbtnDiario.TabIndex = 6;
            this.rbtnDiario.TabStop = true;
            this.rbtnDiario.Text = "Diario";
            this.rbtnDiario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rbtnSin);
            this.groupBox1.Controls.Add(this.rbtnMensual);
            this.groupBox1.Controls.Add(this.rbtnDiario);
            this.groupBox1.Controls.Add(this.rbtnSemanal);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(109, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Size = new System.Drawing.Size(436, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasa:";
            // 
            // rbtnSin
            // 
            this.rbtnSin.AutoSize = true;
            this.rbtnSin.Enabled = false;
            this.rbtnSin.Location = new System.Drawing.Point(298, 26);
            this.rbtnSin.Name = "rbtnSin";
            this.rbtnSin.Size = new System.Drawing.Size(121, 20);
            this.rbtnSin.TabIndex = 7;
            this.rbtnSin.TabStop = true;
            this.rbtnSin.Text = "Sin Rendición";
            this.rbtnSin.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elija la moneda:";
            // 
            // lblDaysDifference
            // 
            this.lblDaysDifference.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDaysDifference.AutoSize = true;
            this.lblDaysDifference.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysDifference.Location = new System.Drawing.Point(276, 143);
            this.lblDaysDifference.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDaysDifference.Name = "lblDaysDifference";
            this.lblDaysDifference.Size = new System.Drawing.Size(22, 16);
            this.lblDaysDifference.TabIndex = 10;
            this.lblDaysDifference.Text = "...";
            // 
            // cbMoneda
            // 
            this.cbMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMoneda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Items.AddRange(new object[] {
            "Peso",
            "Dólar"});
            this.cbMoneda.Location = new System.Drawing.Point(279, 6);
            this.cbMoneda.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(187, 24);
            this.cbMoneda.TabIndex = 11;
            this.cbMoneda.SelectedIndexChanged += new System.EventHandler(this.cbMoneda_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcular.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(109, 236);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(191, 47);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtbResultado
            // 
            this.txtbResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbResultado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbResultado.Location = new System.Drawing.Point(315, 260);
            this.txtbResultado.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Size = new System.Drawing.Size(189, 23);
            this.txtbResultado.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(312, 236);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 16);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "RESULTADO:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(280, 106);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(187, 23);
            this.dateTimePickerEnd.TabIndex = 15;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha de cierre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.rbtnFinalizar);
            this.groupBox2.Controls.Add(this.rbtnExtraer);
            this.groupBox2.Controls.Add(this.rbtnAgregar);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(109, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 74);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "¿Querés agregar o extraer dinero? Selecciona la opción indicada y luego presiona " +
    "el botón \"Operar\"";
            // 
            // rbtnFinalizar
            // 
            this.rbtnFinalizar.AutoSize = true;
            this.rbtnFinalizar.Location = new System.Drawing.Point(267, 48);
            this.rbtnFinalizar.Name = "rbtnFinalizar";
            this.rbtnFinalizar.Size = new System.Drawing.Size(163, 20);
            this.rbtnFinalizar.TabIndex = 2;
            this.rbtnFinalizar.TabStop = true;
            this.rbtnFinalizar.Text = "Finalizar operación";
            this.rbtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // rbtnExtraer
            // 
            this.rbtnExtraer.AutoSize = true;
            this.rbtnExtraer.Location = new System.Drawing.Point(155, 48);
            this.rbtnExtraer.Name = "rbtnExtraer";
            this.rbtnExtraer.Size = new System.Drawing.Size(79, 20);
            this.rbtnExtraer.TabIndex = 1;
            this.rbtnExtraer.TabStop = true;
            this.rbtnExtraer.Text = "Extraer";
            this.rbtnExtraer.UseVisualStyleBackColor = true;
            // 
            // rbtnAgregar
            // 
            this.rbtnAgregar.AutoSize = true;
            this.rbtnAgregar.Location = new System.Drawing.Point(18, 46);
            this.rbtnAgregar.Name = "rbtnAgregar";
            this.rbtnAgregar.Size = new System.Drawing.Size(83, 20);
            this.rbtnAgregar.TabIndex = 0;
            this.rbtnAgregar.TabStop = true;
            this.rbtnAgregar.Text = "Agregar";
            this.rbtnAgregar.UseVisualStyleBackColor = true;
            // 
            // listViewResultados
            // 
            this.listViewResultados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listViewResultados.HideSelection = false;
            this.listViewResultados.Location = new System.Drawing.Point(109, 433);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(485, 131);
            this.listViewResultados.TabIndex = 18;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.View = System.Windows.Forms.View.List;
            // 
            // lblDetalles
            // 
            this.lblDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(106, 412);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(211, 18);
            this.lblDetalles.TabIndex = 19;
            this.lblDetalles.Text = "Detalles de la Operación:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.BackColor = System.Drawing.Color.Gold;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(212, 380);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(233, 29);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Operar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnSumar
            // 
            this.btnSumar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSumar.BackColor = System.Drawing.Color.IndianRed;
            this.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumar.Enabled = false;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumar.ForeColor = System.Drawing.Color.White;
            this.btnSumar.Location = new System.Drawing.Point(510, 224);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(84, 35);
            this.btnSumar.TabIndex = 21;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Visible = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestar.Location = new System.Drawing.Point(510, 260);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(84, 34);
            this.btnRestar.TabIndex = 22;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Visible = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = global::CalculadoraTasas.Properties.Resources._563256_1151726;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(712, 576);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.listViewResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.lblDaysDifference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.lblMontoInicial);
            this.Controls.Add(this.txtMontoInicial);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = " Liquidaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Label lblMontoInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rbtnMensual;
        private System.Windows.Forms.RadioButton rbtnSemanal;
        private System.Windows.Forms.RadioButton rbtnDiario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label lblDaysDifference;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtbResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnFinalizar;
        private System.Windows.Forms.RadioButton rbtnExtraer;
        private System.Windows.Forms.RadioButton rbtnAgregar;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.ListView listViewResultados;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.RadioButton rbtnSin;
        private System.Windows.Forms.Button btnRestar;
    }
}


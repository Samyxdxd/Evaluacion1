namespace AlmacenesPorAhi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo_SCortez = new System.Windows.Forms.Button();
            this.btnCrear_SCortez = new System.Windows.Forms.Button();
            this.rbVisaPlatinum = new System.Windows.Forms.RadioButton();
            this.rbVisaGold = new System.Windows.Forms.RadioButton();
            this.txtNumeroTarjeta_SCortez = new System.Windows.Forms.TextBox();
            this.txtNombreCliente_SCortez = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMovimientos = new System.Windows.Forms.GroupBox();
            this.btnEstado_SCortez = new System.Windows.Forms.Button();
            this.listEvento_SCortez = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPago_SCortez = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPago_SCortez = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMontoCargo_SCortez = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargo_SCortez = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbMovimientos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo_SCortez);
            this.groupBox1.Controls.Add(this.btnCrear_SCortez);
            this.groupBox1.Controls.Add(this.rbVisaPlatinum);
            this.groupBox1.Controls.Add(this.rbVisaGold);
            this.groupBox1.Controls.Add(this.txtNumeroTarjeta_SCortez);
            this.groupBox1.Controls.Add(this.txtNombreCliente_SCortez);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente ";
            // 
            // btnNuevo_SCortez
            // 
            this.btnNuevo_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_SCortez.Location = new System.Drawing.Point(532, 117);
            this.btnNuevo_SCortez.Name = "btnNuevo_SCortez";
            this.btnNuevo_SCortez.Size = new System.Drawing.Size(223, 42);
            this.btnNuevo_SCortez.TabIndex = 8;
            this.btnNuevo_SCortez.Text = "Nuevo Cliente";
            this.btnNuevo_SCortez.UseVisualStyleBackColor = true;
            this.btnNuevo_SCortez.Click += new System.EventHandler(this.btnNuevo_SCortez_Click);
            // 
            // btnCrear_SCortez
            // 
            this.btnCrear_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear_SCortez.Location = new System.Drawing.Point(532, 27);
            this.btnCrear_SCortez.Name = "btnCrear_SCortez";
            this.btnCrear_SCortez.Size = new System.Drawing.Size(223, 42);
            this.btnCrear_SCortez.TabIndex = 7;
            this.btnCrear_SCortez.Text = "Crear Cliente";
            this.btnCrear_SCortez.UseVisualStyleBackColor = true;
            this.btnCrear_SCortez.Click += new System.EventHandler(this.btnCrear_SCortez_Click);
            // 
            // rbVisaPlatinum
            // 
            this.rbVisaPlatinum.AutoSize = true;
            this.rbVisaPlatinum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisaPlatinum.Location = new System.Drawing.Point(342, 127);
            this.rbVisaPlatinum.Name = "rbVisaPlatinum";
            this.rbVisaPlatinum.Size = new System.Drawing.Size(122, 20);
            this.rbVisaPlatinum.TabIndex = 6;
            this.rbVisaPlatinum.TabStop = true;
            this.rbVisaPlatinum.Text = "VISA Platinum";
            this.rbVisaPlatinum.UseVisualStyleBackColor = true;
            // 
            // rbVisaGold
            // 
            this.rbVisaGold.AutoSize = true;
            this.rbVisaGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisaGold.Location = new System.Drawing.Point(187, 127);
            this.rbVisaGold.Name = "rbVisaGold";
            this.rbVisaGold.Size = new System.Drawing.Size(96, 20);
            this.rbVisaGold.TabIndex = 5;
            this.rbVisaGold.TabStop = true;
            this.rbVisaGold.Text = "VISA Gold";
            this.rbVisaGold.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTarjeta_SCortez
            // 
            this.txtNumeroTarjeta_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTarjeta_SCortez.Location = new System.Drawing.Point(187, 76);
            this.txtNumeroTarjeta_SCortez.Name = "txtNumeroTarjeta_SCortez";
            this.txtNumeroTarjeta_SCortez.Size = new System.Drawing.Size(278, 22);
            this.txtNumeroTarjeta_SCortez.TabIndex = 4;
            // 
            // txtNombreCliente_SCortez
            // 
            this.txtNombreCliente_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente_SCortez.Location = new System.Drawing.Point(187, 36);
            this.txtNombreCliente_SCortez.Name = "txtNombreCliente_SCortez";
            this.txtNombreCliente_SCortez.Size = new System.Drawing.Size(278, 22);
            this.txtNombreCliente_SCortez.TabIndex = 3;
            this.txtNombreCliente_SCortez.TextChanged += new System.EventHandler(this.txtNombreCliente_SCortez_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Tarjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Tarjeta Semcozud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // gbMovimientos
            // 
            this.gbMovimientos.Controls.Add(this.btnEstado_SCortez);
            this.gbMovimientos.Controls.Add(this.listEvento_SCortez);
            this.gbMovimientos.Controls.Add(this.groupBox4);
            this.gbMovimientos.Controls.Add(this.groupBox3);
            this.gbMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimientos.Location = new System.Drawing.Point(13, 217);
            this.gbMovimientos.Name = "gbMovimientos";
            this.gbMovimientos.Size = new System.Drawing.Size(775, 342);
            this.gbMovimientos.TabIndex = 1;
            this.gbMovimientos.TabStop = false;
            this.gbMovimientos.Text = "Movimientos Tarjeta";
            this.gbMovimientos.Visible = false;
            // 
            // btnEstado_SCortez
            // 
            this.btnEstado_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado_SCortez.Location = new System.Drawing.Point(331, 293);
            this.btnEstado_SCortez.Name = "btnEstado_SCortez";
            this.btnEstado_SCortez.Size = new System.Drawing.Size(438, 43);
            this.btnEstado_SCortez.TabIndex = 9;
            this.btnEstado_SCortez.Text = "Consultar estado de Cuenta de la Tarjeta";
            this.btnEstado_SCortez.UseVisualStyleBackColor = true;
            this.btnEstado_SCortez.Click += new System.EventHandler(this.btnEstado_SCortez_Click);
            // 
            // listEvento_SCortez
            // 
            this.listEvento_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEvento_SCortez.FormattingEnabled = true;
            this.listEvento_SCortez.ItemHeight = 16;
            this.listEvento_SCortez.Location = new System.Drawing.Point(331, 26);
            this.listEvento_SCortez.Name = "listEvento_SCortez";
            this.listEvento_SCortez.Size = new System.Drawing.Size(438, 244);
            this.listEvento_SCortez.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPago_SCortez);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnPago_SCortez);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 131);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagos de la Targeta";
            // 
            // txtPago_SCortez
            // 
            this.txtPago_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago_SCortez.Location = new System.Drawing.Point(124, 48);
            this.txtPago_SCortez.Name = "txtPago_SCortez";
            this.txtPago_SCortez.Size = new System.Drawing.Size(172, 22);
            this.txtPago_SCortez.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Monto $:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPago_SCortez
            // 
            this.btnPago_SCortez.Location = new System.Drawing.Point(157, 93);
            this.btnPago_SCortez.Name = "btnPago_SCortez";
            this.btnPago_SCortez.Size = new System.Drawing.Size(139, 25);
            this.btnPago_SCortez.TabIndex = 0;
            this.btnPago_SCortez.Text = "Registrar Pago";
            this.btnPago_SCortez.UseVisualStyleBackColor = true;
            this.btnPago_SCortez.Click += new System.EventHandler(this.btnPago_SCortez_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMontoCargo_SCortez);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnCargo_SCortez);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 131);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cargos a la Targeta";
            // 
            // txtMontoCargo_SCortez
            // 
            this.txtMontoCargo_SCortez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCargo_SCortez.Location = new System.Drawing.Point(124, 48);
            this.txtMontoCargo_SCortez.Name = "txtMontoCargo_SCortez";
            this.txtMontoCargo_SCortez.Size = new System.Drawing.Size(172, 22);
            this.txtMontoCargo_SCortez.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monto $:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCargo_SCortez
            // 
            this.btnCargo_SCortez.Location = new System.Drawing.Point(157, 93);
            this.btnCargo_SCortez.Name = "btnCargo_SCortez";
            this.btnCargo_SCortez.Size = new System.Drawing.Size(139, 25);
            this.btnCargo_SCortez.TabIndex = 0;
            this.btnCargo_SCortez.Text = "Registrar Compra";
            this.btnCargo_SCortez.UseVisualStyleBackColor = true;
            this.btnCargo_SCortez.Click += new System.EventHandler(this.btnCargo_SCortez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.gbMovimientos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Almacenes Por Ahí";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMovimientos.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroTarjeta_SCortez;
        private System.Windows.Forms.TextBox txtNombreCliente_SCortez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo_SCortez;
        private System.Windows.Forms.Button btnCrear_SCortez;
        private System.Windows.Forms.RadioButton rbVisaPlatinum;
        private System.Windows.Forms.RadioButton rbVisaGold;
        private System.Windows.Forms.GroupBox gbMovimientos;
        private System.Windows.Forms.Button btnEstado_SCortez;
        private System.Windows.Forms.ListBox listEvento_SCortez;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPago_SCortez;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPago_SCortez;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMontoCargo_SCortez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargo_SCortez;
    }
}


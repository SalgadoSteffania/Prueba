namespace DCPHONE
{
    partial class AgregarForm
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
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.gpboxDatosprod = new System.Windows.Forms.GroupBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEntradaInv = new System.Windows.Forms.DateTimePicker();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnGuardarUpdate = new System.Windows.Forms.Button();
            this.gpboxDatosprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(188, 319);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(184, 28);
            this.cmbUnidadMedida.TabIndex = 0;
            this.cmbUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.cmbModelos_SelectedIndexChanged);
            // 
            // gpboxDatosprod
            // 
            this.gpboxDatosprod.Controls.Add(this.lblUnidad);
            this.gpboxDatosprod.Controls.Add(this.cmbUnidadMedida);
            this.gpboxDatosprod.Controls.Add(this.label5);
            this.gpboxDatosprod.Controls.Add(this.label4);
            this.gpboxDatosprod.Controls.Add(this.label3);
            this.gpboxDatosprod.Controls.Add(this.label2);
            this.gpboxDatosprod.Controls.Add(this.label1);
            this.gpboxDatosprod.Controls.Add(this.dtpEntradaInv);
            this.gpboxDatosprod.Controls.Add(this.nudPrecio);
            this.gpboxDatosprod.Controls.Add(this.nudExistencia);
            this.gpboxDatosprod.Controls.Add(this.txtDescripcion);
            this.gpboxDatosprod.Controls.Add(this.txtnombre);
            this.gpboxDatosprod.Location = new System.Drawing.Point(16, 17);
            this.gpboxDatosprod.Name = "gpboxDatosprod";
            this.gpboxDatosprod.Size = new System.Drawing.Size(676, 377);
            this.gpboxDatosprod.TabIndex = 1;
            this.gpboxDatosprod.TabStop = false;
            this.gpboxDatosprod.Text = "Datos de Producto";
            this.gpboxDatosprod.Enter += new System.EventHandler(this.gpboxDatosprod_Enter);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(6, 319);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(167, 20);
            this.lblUnidad.TabIndex = 11;
            this.lblUnidad.Text = "Unidades de Medidas:";
            this.lblUnidad.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Caracteristicas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // dtpEntradaInv
            // 
            this.dtpEntradaInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntradaInv.Location = new System.Drawing.Point(188, 259);
            this.dtpEntradaInv.Name = "dtpEntradaInv";
            this.dtpEntradaInv.Size = new System.Drawing.Size(382, 26);
            this.dtpEntradaInv.TabIndex = 4;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(188, 226);
            this.nudPrecio.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(382, 26);
            this.nudPrecio.TabIndex = 3;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudExistencia
            // 
            this.nudExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudExistencia.Location = new System.Drawing.Point(188, 192);
            this.nudExistencia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(382, 26);
            this.nudExistencia.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(176, 79);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(394, 87);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Location = new System.Drawing.Point(178, 29);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(392, 26);
            this.txtnombre.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(21, 429);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(128, 35);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Guardar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // btnGuardarUpdate
            // 
            this.btnGuardarUpdate.Location = new System.Drawing.Point(21, 474);
            this.btnGuardarUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarUpdate.Name = "btnGuardarUpdate";
            this.btnGuardarUpdate.Size = new System.Drawing.Size(128, 35);
            this.btnGuardarUpdate.TabIndex = 3;
            this.btnGuardarUpdate.Text = "Guardar";
            this.btnGuardarUpdate.UseVisualStyleBackColor = true;
            this.btnGuardarUpdate.Click += new System.EventHandler(this.BtnGuardarUpdate_Click);
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 542);
            this.Controls.Add(this.btnGuardarUpdate);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.gpboxDatosprod);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpboxDatosprod.ResumeLayout(false);
            this.gpboxDatosprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.GroupBox gpboxDatosprod;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntradaInv;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudExistencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnGuardarUpdate;
    }
}


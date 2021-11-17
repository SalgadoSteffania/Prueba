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
            this.cmbModelos = new System.Windows.Forms.ComboBox();
            this.gpboxDatosprod = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // cmbModelos
            // 
            this.cmbModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelos.FormattingEnabled = true;
            this.cmbModelos.Location = new System.Drawing.Point(85, 209);
            this.cmbModelos.Name = "cmbModelos";
            this.cmbModelos.Size = new System.Drawing.Size(124, 21);
            this.cmbModelos.TabIndex = 0;
            this.cmbModelos.SelectedIndexChanged += new System.EventHandler(this.cmbModelos_SelectedIndexChanged);
            // 
            // gpboxDatosprod
            // 
            this.gpboxDatosprod.Controls.Add(this.label6);
            this.gpboxDatosprod.Controls.Add(this.cmbModelos);
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
            this.gpboxDatosprod.Location = new System.Drawing.Point(11, 11);
            this.gpboxDatosprod.Margin = new System.Windows.Forms.Padding(2);
            this.gpboxDatosprod.Name = "gpboxDatosprod";
            this.gpboxDatosprod.Padding = new System.Windows.Forms.Padding(2);
            this.gpboxDatosprod.Size = new System.Drawing.Size(391, 245);
            this.gpboxDatosprod.TabIndex = 1;
            this.gpboxDatosprod.TabStop = false;
            this.gpboxDatosprod.Text = "Datos de Producto";
            this.gpboxDatosprod.Enter += new System.EventHandler(this.gpboxDatosprod_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Modelo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Caracteristicas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // dtpEntradaInv
            // 
            this.dtpEntradaInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntradaInv.Location = new System.Drawing.Point(85, 170);
            this.dtpEntradaInv.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntradaInv.Name = "dtpEntradaInv";
            this.dtpEntradaInv.Size = new System.Drawing.Size(196, 20);
            this.dtpEntradaInv.TabIndex = 4;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(79, 146);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudPrecio.Size = new System.Drawing.Size(64, 20);
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
            this.nudExistencia.Location = new System.Drawing.Point(79, 124);
            this.nudExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.nudExistencia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(64, 20);
            this.nudExistencia.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(80, 50);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(271, 58);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Location = new System.Drawing.Point(79, 21);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(272, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(14, 279);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(85, 23);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Guardar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // btnGuardarUpdate
            // 
            this.btnGuardarUpdate.Location = new System.Drawing.Point(14, 308);
            this.btnGuardarUpdate.Name = "btnGuardarUpdate";
            this.btnGuardarUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnGuardarUpdate.TabIndex = 3;
            this.btnGuardarUpdate.Text = "Guardar";
            this.btnGuardarUpdate.UseVisualStyleBackColor = true;
            this.btnGuardarUpdate.Click += new System.EventHandler(this.BtnGuardarUpdate_Click);
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 352);
            this.Controls.Add(this.btnGuardarUpdate);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.gpboxDatosprod);
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

        private System.Windows.Forms.ComboBox cmbModelos;
        private System.Windows.Forms.GroupBox gpboxDatosprod;
        private System.Windows.Forms.Label label6;
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


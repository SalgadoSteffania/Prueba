namespace DCPHONE
{
    partial class MenuForm
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
            System.Windows.Forms.Button btnEliminar;
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DtgvMostrarProductos = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvMostrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(130, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(98, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(26, 375);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 32);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DtgvMostrarProductos
            // 
            this.DtgvMostrarProductos.AllowUserToAddRows = false;
            this.DtgvMostrarProductos.AllowUserToDeleteRows = false;
            this.DtgvMostrarProductos.AllowUserToResizeColumns = false;
            this.DtgvMostrarProductos.AllowUserToResizeRows = false;
            this.DtgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvMostrarProductos.Location = new System.Drawing.Point(26, 58);
            this.DtgvMostrarProductos.MultiSelect = false;
            this.DtgvMostrarProductos.Name = "DtgvMostrarProductos";
            this.DtgvMostrarProductos.ReadOnly = true;
            this.DtgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvMostrarProductos.Size = new System.Drawing.Size(691, 188);
            this.DtgvMostrarProductos.TabIndex = 1;
            this.DtgvMostrarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvMostrarProductos_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(234, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(this.DtgvMostrarProductos);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "MenuForm";
            this.Text = "MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvMostrarProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DtgvMostrarProductos;
        private System.Windows.Forms.Button btnUpdate;
    }
}
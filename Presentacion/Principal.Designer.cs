namespace Presentacion
{
    partial class Principal
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
            this.cmdguardar = new System.Windows.Forms.Button();
            this.txtsegurocod = new System.Windows.Forms.TextBox();
            this.txtsegurotip = new System.Windows.Forms.TextBox();
            this.txtseguroval = new System.Windows.Forms.TextBox();
            this.txtseguropor = new System.Windows.Forms.TextBox();
            this.txtseguroval_b = new System.Windows.Forms.TextBox();
            this.cboseguros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdguardar
            // 
            this.cmdguardar.Location = new System.Drawing.Point(61, 228);
            this.cmdguardar.Name = "cmdguardar";
            this.cmdguardar.Size = new System.Drawing.Size(100, 46);
            this.cmdguardar.TabIndex = 0;
            this.cmdguardar.Text = "Guardar seguro";
            this.cmdguardar.UseVisualStyleBackColor = true;
            this.cmdguardar.Click += new System.EventHandler(this.cmdguardar_Click);
            // 
            // txtsegurocod
            // 
            this.txtsegurocod.Location = new System.Drawing.Point(61, 79);
            this.txtsegurocod.Name = "txtsegurocod";
            this.txtsegurocod.Size = new System.Drawing.Size(100, 20);
            this.txtsegurocod.TabIndex = 1;
            // 
            // txtsegurotip
            // 
            this.txtsegurotip.Location = new System.Drawing.Point(61, 105);
            this.txtsegurotip.Name = "txtsegurotip";
            this.txtsegurotip.Size = new System.Drawing.Size(100, 20);
            this.txtsegurotip.TabIndex = 2;
            // 
            // txtseguroval
            // 
            this.txtseguroval.Location = new System.Drawing.Point(61, 131);
            this.txtseguroval.Name = "txtseguroval";
            this.txtseguroval.Size = new System.Drawing.Size(100, 20);
            this.txtseguroval.TabIndex = 3;
            // 
            // txtseguropor
            // 
            this.txtseguropor.Location = new System.Drawing.Point(61, 157);
            this.txtseguropor.Name = "txtseguropor";
            this.txtseguropor.Size = new System.Drawing.Size(100, 20);
            this.txtseguropor.TabIndex = 4;
            // 
            // txtseguroval_b
            // 
            this.txtseguroval_b.Location = new System.Drawing.Point(61, 183);
            this.txtseguroval_b.Name = "txtseguroval_b";
            this.txtseguroval_b.Size = new System.Drawing.Size(100, 20);
            this.txtseguroval_b.TabIndex = 5;
            // 
            // cboseguros
            // 
            this.cboseguros.FormattingEnabled = true;
            this.cboseguros.Location = new System.Drawing.Point(399, 78);
            this.cboseguros.Name = "cboseguros";
            this.cboseguros.Size = new System.Drawing.Size(121, 21);
            this.cboseguros.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboseguros);
            this.Controls.Add(this.txtseguroval_b);
            this.Controls.Add(this.txtseguropor);
            this.Controls.Add(this.txtseguroval);
            this.Controls.Add(this.txtsegurotip);
            this.Controls.Add(this.txtsegurocod);
            this.Controls.Add(this.cmdguardar);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdguardar;
        private System.Windows.Forms.TextBox txtsegurocod;
        private System.Windows.Forms.TextBox txtsegurotip;
        private System.Windows.Forms.TextBox txtseguroval;
        private System.Windows.Forms.TextBox txtseguropor;
        private System.Windows.Forms.TextBox txtseguroval_b;
        private System.Windows.Forms.ComboBox cboseguros;
    }
}


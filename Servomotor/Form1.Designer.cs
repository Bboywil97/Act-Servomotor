
namespace Servomotor
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbConection = new System.Windows.Forms.Label();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(322, 89);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(140, 41);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(322, 327);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(173, 69);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(375, 267);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(46, 17);
            this.lbTemp.TabIndex = 3;
            this.lbTemp.Text = "label2";
            // 
            // lbConection
            // 
            this.lbConection.AutoSize = true;
            this.lbConection.Location = new System.Drawing.Point(632, 171);
            this.lbConection.Name = "lbConection";
            this.lbConection.Size = new System.Drawing.Size(46, 17);
            this.lbConection.TabIndex = 4;
            this.lbConection.Text = "label1";
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(322, 186);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(135, 22);
            this.tbLimTemp.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.lbConection);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbConection;
        private System.Windows.Forms.TextBox tbLimTemp;
    }
}



namespace Programacion3._1901
{
    partial class FuncionesAsincronas
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
            this.button1 = new System.Windows.Forms.Button();
            this.Resultadolabel1 = new System.Windows.Forms.Label();
            this.ResultadoSumalabel = new System.Windows.Forms.Label();
            this.Sumarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultadolabel1
            // 
            this.Resultadolabel1.AutoSize = true;
            this.Resultadolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadolabel1.ForeColor = System.Drawing.Color.Red;
            this.Resultadolabel1.Location = new System.Drawing.Point(103, 149);
            this.Resultadolabel1.Name = "Resultadolabel1";
            this.Resultadolabel1.Size = new System.Drawing.Size(66, 24);
            this.Resultadolabel1.TabIndex = 1;
            this.Resultadolabel1.Text = "label1";
            // 
            // ResultadoSumalabel
            // 
            this.ResultadoSumalabel.AutoSize = true;
            this.ResultadoSumalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoSumalabel.ForeColor = System.Drawing.Color.Red;
            this.ResultadoSumalabel.Location = new System.Drawing.Point(452, 149);
            this.ResultadoSumalabel.Name = "ResultadoSumalabel";
            this.ResultadoSumalabel.Size = new System.Drawing.Size(66, 24);
            this.ResultadoSumalabel.TabIndex = 3;
            this.ResultadoSumalabel.Text = "label1";
            // 
            // Sumarbutton
            // 
            this.Sumarbutton.Location = new System.Drawing.Point(427, 12);
            this.Sumarbutton.Name = "Sumarbutton";
            this.Sumarbutton.Size = new System.Drawing.Size(121, 56);
            this.Sumarbutton.TabIndex = 2;
            this.Sumarbutton.Text = "Sumar";
            this.Sumarbutton.UseVisualStyleBackColor = true;
            this.Sumarbutton.Click += new System.EventHandler(this.Sumarbutton_Click);
            // 
            // FuncionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 346);
            this.Controls.Add(this.ResultadoSumalabel);
            this.Controls.Add(this.Sumarbutton);
            this.Controls.Add(this.Resultadolabel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FuncionesAsincronas";
            this.Text = "FuncionesAsincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Resultadolabel1;
        private System.Windows.Forms.Label ResultadoSumalabel;
        private System.Windows.Forms.Button Sumarbutton;
    }
}

namespace Programacion3._1901
{
    partial class Arreglos
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
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(54, 26);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(160, 56);
            this.Ejecutarbutton.TabIndex = 0;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 173);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(282, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(160, 173);
            this.listBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 418);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Ejecutarbutton);
            this.Name = "Arreglos";
            this.Text = "Arreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}
namespace WindowsFormsApplication1
{
    partial class Simplex
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
            this.textBoxNumberOfConstraints = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfVariables = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumberOfConstraints
            // 
            this.textBoxNumberOfConstraints.Location = new System.Drawing.Point(172, 60);
            this.textBoxNumberOfConstraints.MaxLength = 2;
            this.textBoxNumberOfConstraints.Name = "textBoxNumberOfConstraints";
            this.textBoxNumberOfConstraints.Size = new System.Drawing.Size(71, 20);
            this.textBoxNumberOfConstraints.TabIndex = 9;
            // 
            // textBoxNumberOfVariables
            // 
            this.textBoxNumberOfVariables.Location = new System.Drawing.Point(172, 25);
            this.textBoxNumberOfVariables.MaxLength = 2;
            this.textBoxNumberOfVariables.Name = "textBoxNumberOfVariables";
            this.textBoxNumberOfVariables.Size = new System.Drawing.Size(71, 20);
            this.textBoxNumberOfVariables.TabIndex = 8;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(32, 109);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ingresar";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de resticciones ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de variables";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Simplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumberOfConstraints);
            this.Controls.Add(this.textBoxNumberOfVariables);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Simplex";
            this.Text = "Metodo Simplex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberOfConstraints;
        private System.Windows.Forms.TextBox textBoxNumberOfVariables;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
namespace radiobutton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbsuma = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdiv = new System.Windows.Forms.RadioButton();
            this.rbmulti = new System.Windows.Forms.RadioButton();
            this.rbresta = new System.Windows.Forms.RadioButton();
            this.lblresultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(45, 41);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 23);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "0";
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(45, 94);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 23);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "0";
            this.txt2.HideSelectionChanged += new System.EventHandler(this.txt2_HideSelectionChanged);
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar primer numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar segundo numero";
            // 
            // rbsuma
            // 
            this.rbsuma.AutoSize = true;
            this.rbsuma.Location = new System.Drawing.Point(16, 33);
            this.rbsuma.Name = "rbsuma";
            this.rbsuma.Size = new System.Drawing.Size(55, 19);
            this.rbsuma.TabIndex = 4;
            this.rbsuma.TabStop = true;
            this.rbsuma.Text = "Suma";
            this.rbsuma.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdiv);
            this.groupBox1.Controls.Add(this.rbmulti);
            this.groupBox1.Controls.Add(this.rbresta);
            this.groupBox1.Controls.Add(this.rbsuma);
            this.groupBox1.Location = new System.Drawing.Point(45, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbdiv
            // 
            this.rbdiv.AutoSize = true;
            this.rbdiv.Location = new System.Drawing.Point(16, 108);
            this.rbdiv.Name = "rbdiv";
            this.rbdiv.Size = new System.Drawing.Size(67, 19);
            this.rbdiv.TabIndex = 6;
            this.rbdiv.TabStop = true;
            this.rbdiv.Text = "Division";
            this.rbdiv.UseVisualStyleBackColor = true;
            // 
            // rbmulti
            // 
            this.rbmulti.AutoSize = true;
            this.rbmulti.Location = new System.Drawing.Point(16, 83);
            this.rbmulti.Name = "rbmulti";
            this.rbmulti.Size = new System.Drawing.Size(101, 19);
            this.rbmulti.TabIndex = 6;
            this.rbmulti.TabStop = true;
            this.rbmulti.Text = "Multiplicacion";
            this.rbmulti.UseVisualStyleBackColor = true;
            // 
            // rbresta
            // 
            this.rbresta.AutoSize = true;
            this.rbresta.Location = new System.Drawing.Point(16, 58);
            this.rbresta.Name = "rbresta";
            this.rbresta.Size = new System.Drawing.Size(53, 19);
            this.rbresta.TabIndex = 5;
            this.rbresta.TabStop = true;
            this.rbresta.Text = "Resta";
            this.rbresta.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.Location = new System.Drawing.Point(225, 75);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 21);
            this.lblresultado.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private Label label1;
        private Label label2;
        private RadioButton rbsuma;
        private GroupBox groupBox1;
        private RadioButton rbdiv;
        private RadioButton rbmulti;
        private RadioButton rbresta;
        private Label lblresultado;
        private Button button1;
    }
}
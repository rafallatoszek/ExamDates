namespace Interface
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dalej = new System.Windows.Forms.Button();
            this.listaEgzamin = new System.Windows.Forms.NumericUpDown();
            this.listaStudent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEgzamin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proszę wybrać ilość egzaminów";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(59, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proszę wybrać liczbę studentów";
            // 
            // Dalej
            // 
            this.Dalej.Location = new System.Drawing.Point(199, 323);
            this.Dalej.Name = "Dalej";
            this.Dalej.Size = new System.Drawing.Size(75, 23);
            this.Dalej.TabIndex = 4;
            this.Dalej.Text = "Dalej";
            this.Dalej.UseVisualStyleBackColor = true;
            this.Dalej.Click += new System.EventHandler(this.Dalej_Click);
            // 
            // listaEgzamin
            // 
            this.listaEgzamin.Location = new System.Drawing.Point(175, 185);
            this.listaEgzamin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.listaEgzamin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listaEgzamin.Name = "listaEgzamin";
            this.listaEgzamin.Size = new System.Drawing.Size(120, 20);
            this.listaEgzamin.TabIndex = 5;
            this.listaEgzamin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listaEgzamin.ValueChanged += new System.EventHandler(this.listaEgzamin_ValueChanged);
            // 
            // listaStudent
            // 
            this.listaStudent.Location = new System.Drawing.Point(175, 264);
            this.listaStudent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listaStudent.Name = "listaStudent";
            this.listaStudent.Size = new System.Drawing.Size(120, 20);
            this.listaStudent.TabIndex = 6;
            this.listaStudent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listaStudent.ValueChanged += new System.EventHandler(this.listaStudent_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 72);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ustalenie terminów egzaminów";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(85, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "M-Kolorowanie Grafu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaStudent);
            this.Controls.Add(this.listaEgzamin);
            this.Controls.Add(this.Dalej);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEgzamin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dalej;
        private System.Windows.Forms.NumericUpDown listaEgzamin;
        private System.Windows.Forms.NumericUpDown listaStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
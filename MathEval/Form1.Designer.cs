
namespace MathEval
{
    partial class MathEval
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
            this.MathEval_titlu = new System.Windows.Forms.Label();
            this.generator = new System.Windows.Forms.Label();
            this.descriere = new System.Windows.Forms.Label();
            this.succes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MathEval_titlu
            // 
            this.MathEval_titlu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathEval_titlu.Location = new System.Drawing.Point(381, 49);
            this.MathEval_titlu.Name = "MathEval_titlu";
            this.MathEval_titlu.Size = new System.Drawing.Size(243, 63);
            this.MathEval_titlu.TabIndex = 0;
            this.MathEval_titlu.Text = "MathEval";
            // 
            // generator
            // 
            this.generator.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generator.Location = new System.Drawing.Point(274, 112);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(509, 57);
            this.generator.TabIndex = 1;
            this.generator.Text = "-generator teste de matematică-";
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // descriere
            // 
            this.descriere.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriere.Location = new System.Drawing.Point(133, 186);
            this.descriere.Name = "descriere";
            this.descriere.Size = new System.Drawing.Size(706, 81);
            this.descriere.TabIndex = 2;
            this.descriere.Text = "      Vei avea la dispoziție 60 de minute să rezolvi un test asemănător Evaluării" +
    " Naționale pentru clasa a VIII-a. Testul va începe când vei apăsa butonul de mai" +
    " jos.";
            // 
            // succes
            // 
            this.succes.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.succes.Location = new System.Drawing.Point(354, 304);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(245, 95);
            this.succes.TabIndex = 3;
            this.succes.Text = "SUCCES!";
            this.succes.UseVisualStyleBackColor = true;
            this.succes.Click += new System.EventHandler(this.succes_Click_1);
            // 
            // MathEval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.descriere);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.MathEval_titlu);
            this.Name = "MathEval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathEval";
            this.Load += new System.EventHandler(this.MathEval_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MathEval_titlu;
        private System.Windows.Forms.Label generator;
        private System.Windows.Forms.Label descriere;
        private System.Windows.Forms.Button succes;
    }
}


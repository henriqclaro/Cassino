namespace Cassino
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnGirar = new System.Windows.Forms.Button();
            this.tmrGiro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 39);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(180, 50);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 39);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "0";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(96, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(36, 39);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "0";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGirar
            // 
            this.btnGirar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirar.Location = new System.Drawing.Point(19, 129);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(197, 51);
            this.btnGirar.TabIndex = 3;
            this.btnGirar.Text = "Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // tmrGiro
            // 
            this.tmrGiro.Tick += new System.EventHandler(this.tmrGiro_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 216);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cassassino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.Timer tmrGiro;
    }
}


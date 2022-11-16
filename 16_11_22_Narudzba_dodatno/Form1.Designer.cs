namespace _16_11_22_Narudzba_dodatno
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
            this.btnInputSave = new System.Windows.Forms.Button();
            this.lblReturn1 = new System.Windows.Forms.Label();
            this.txtBrNar = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.lblBrNar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblKol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInputSave
            // 
            this.btnInputSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInputSave.Location = new System.Drawing.Point(129, 119);
            this.btnInputSave.Name = "btnInputSave";
            this.btnInputSave.Size = new System.Drawing.Size(100, 26);
            this.btnInputSave.TabIndex = 9;
            this.btnInputSave.Text = "Spremi unos";
            this.btnInputSave.UseVisualStyleBackColor = true;
            this.btnInputSave.Click += new System.EventHandler(this.btnInputSave_Click_1);
            // 
            // lblReturn1
            // 
            this.lblReturn1.AutoSize = true;
            this.lblReturn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblReturn1.Location = new System.Drawing.Point(36, 166);
            this.lblReturn1.Name = "lblReturn1";
            this.lblReturn1.Size = new System.Drawing.Size(0, 15);
            this.lblReturn1.TabIndex = 8;
            // 
            // txtBrNar
            // 
            this.txtBrNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBrNar.Location = new System.Drawing.Point(129, 41);
            this.txtBrNar.Name = "txtBrNar";
            this.txtBrNar.Size = new System.Drawing.Size(100, 21);
            this.txtBrNar.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtName.Location = new System.Drawing.Point(129, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 11;
            // 
            // txtKol
            // 
            this.txtKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKol.Location = new System.Drawing.Point(129, 92);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(100, 21);
            this.txtKol.TabIndex = 12;
            // 
            // lblBrNar
            // 
            this.lblBrNar.AutoSize = true;
            this.lblBrNar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBrNar.Location = new System.Drawing.Point(36, 41);
            this.lblBrNar.Name = "lblBrNar";
            this.lblBrNar.Size = new System.Drawing.Size(87, 15);
            this.lblBrNar.TabIndex = 13;
            this.lblBrNar.Text = "Broj narudžbe:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(36, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 15);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Ime kupca";
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKol.Location = new System.Drawing.Point(36, 95);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(51, 15);
            this.lblKol.TabIndex = 15;
            this.lblKol.Text = "Količina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKol);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBrNar);
            this.Controls.Add(this.txtKol);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBrNar);
            this.Controls.Add(this.btnInputSave);
            this.Controls.Add(this.lblReturn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputSave;
        private System.Windows.Forms.Label lblReturn1;
        private System.Windows.Forms.TextBox txtBrNar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKol;
        private System.Windows.Forms.Label lblBrNar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKol;
    }
}


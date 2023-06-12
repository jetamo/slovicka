
namespace slovicka
{
    partial class Pridat
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
            this.b_pridat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_anglicky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cesky = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_pridat
            // 
            this.b_pridat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pridat.Location = new System.Drawing.Point(230, 171);
            this.b_pridat.Name = "b_pridat";
            this.b_pridat.Size = new System.Drawing.Size(139, 33);
            this.b_pridat.TabIndex = 9;
            this.b_pridat.Text = "Přidat";
            this.b_pridat.UseVisualStyleBackColor = true;
            this.b_pridat.Click += new System.EventHandler(this.b_pridat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Anglicky";
            // 
            // tb_anglicky
            // 
            this.tb_anglicky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_anglicky.Location = new System.Drawing.Point(23, 115);
            this.tb_anglicky.Name = "tb_anglicky";
            this.tb_anglicky.Size = new System.Drawing.Size(346, 26);
            this.tb_anglicky.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Česky";
            // 
            // tb_cesky
            // 
            this.tb_cesky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cesky.Location = new System.Drawing.Point(22, 46);
            this.tb_cesky.Name = "tb_cesky";
            this.tb_cesky.Size = new System.Drawing.Size(347, 26);
            this.tb_cesky.TabIndex = 5;
            // 
            // Pridat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 222);
            this.Controls.Add(this.b_pridat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_anglicky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cesky);
            this.Name = "Pridat";
            this.Text = "Pridat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_pridat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_anglicky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cesky;
    }
}
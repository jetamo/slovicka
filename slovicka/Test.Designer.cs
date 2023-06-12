
namespace slovicka
{
    partial class Test
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
            this.slovickoEN = new System.Windows.Forms.Label();
            this.SlovickoCZ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slovickoEN
            // 
            this.slovickoEN.AutoSize = true;
            this.slovickoEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slovickoEN.Location = new System.Drawing.Point(33, 26);
            this.slovickoEN.Name = "slovickoEN";
            this.slovickoEN.Size = new System.Drawing.Size(64, 20);
            this.slovickoEN.TabIndex = 0;
            this.slovickoEN.Text = "slovicko";
            // 
            // SlovickoCZ
            // 
            this.SlovickoCZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlovickoCZ.Location = new System.Drawing.Point(27, 110);
            this.SlovickoCZ.Name = "SlovickoCZ";
            this.SlovickoCZ.Size = new System.Drawing.Size(236, 26);
            this.SlovickoCZ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Další";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SlovickoCZ);
            this.Controls.Add(this.slovickoEN);
            this.Name = "Test";
            this.Text = "Test";
            this.Shown += new System.EventHandler(this.Test_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slovickoEN;
        private System.Windows.Forms.TextBox SlovickoCZ;
        private System.Windows.Forms.Button button1;
    }
}
namespace hopverk
{
    partial class Magn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_Stadfesta = new System.Windows.Forms.Button();
            this.bt_hætta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bt_Stadfesta
            // 
            this.bt_Stadfesta.Location = new System.Drawing.Point(12, 82);
            this.bt_Stadfesta.Name = "bt_Stadfesta";
            this.bt_Stadfesta.Size = new System.Drawing.Size(94, 23);
            this.bt_Stadfesta.TabIndex = 2;
            this.bt_Stadfesta.Text = "Stadfesta";
            this.bt_Stadfesta.UseVisualStyleBackColor = true;
            // 
            // bt_hætta
            // 
            this.bt_hætta.Location = new System.Drawing.Point(112, 82);
            this.bt_hætta.Name = "bt_hætta";
            this.bt_hætta.Size = new System.Drawing.Size(86, 23);
            this.bt_hætta.TabIndex = 4;
            this.bt_hætta.Text = "hætta";
            this.bt_hætta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hvesu marga viltu það er ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "\" til af þessa voru\"";
            // 
            // Magn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_hætta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Stadfesta);
            this.Controls.Add(this.textBox1);
            this.Name = "Magn";
            this.Text = "Magn";
            this.Load += new System.EventHandler(this.Magn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_Stadfesta;
        private System.Windows.Forms.Button bt_hætta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
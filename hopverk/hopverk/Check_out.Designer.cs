namespace hopverk
{
    partial class Check_out
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
            this.li_korfa = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btStadfesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // li_korfa
            // 
            this.li_korfa.FullRowSelect = true;
            this.li_korfa.GridLines = true;
            this.li_korfa.Location = new System.Drawing.Point(16, 15);
            this.li_korfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.li_korfa.Name = "li_korfa";
            this.li_korfa.Size = new System.Drawing.Size(577, 229);
            this.li_korfa.TabIndex = 15;
            this.li_korfa.UseCompatibleStateImageBehavior = false;
            this.li_korfa.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Heildar kostnaður: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 17;
            // 
            // btStadfesta
            // 
            this.btStadfesta.Location = new System.Drawing.Point(216, 335);
            this.btStadfesta.Name = "btStadfesta";
            this.btStadfesta.Size = new System.Drawing.Size(133, 40);
            this.btStadfesta.TabIndex = 18;
            this.btStadfesta.Text = "Staðfesta";
            this.btStadfesta.UseVisualStyleBackColor = true;
            // 
            // Check_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 437);
            this.Controls.Add(this.btStadfesta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.li_korfa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Check_out";
            this.Text = "Check_out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView li_korfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btStadfesta;
    }
}
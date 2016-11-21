namespace hopverk
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
            this.korfu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.li_korfa = new System.Windows.Forms.ListView();
            this.li_lager = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // korfu
            // 
            this.korfu.Location = new System.Drawing.Point(484, 89);
            this.korfu.Name = "korfu";
            this.korfu.Size = new System.Drawing.Size(75, 23);
            this.korfu.TabIndex = 1;
            this.korfu.Text = "bæta i korfu";
            this.korfu.UseVisualStyleBackColor = true;
            this.korfu.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(756, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Check out";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // li_korfa
            // 
            this.li_korfa.FullRowSelect = true;
            this.li_korfa.GridLines = true;
            this.li_korfa.Location = new System.Drawing.Point(583, 34);
            this.li_korfa.Name = "li_korfa";
            this.li_korfa.Size = new System.Drawing.Size(434, 187);
            this.li_korfa.TabIndex = 14;
            this.li_korfa.UseCompatibleStateImageBehavior = false;
            this.li_korfa.View = System.Windows.Forms.View.Details;
            // 
            // li_lager
            // 
            this.li_lager.FullRowSelect = true;
            this.li_lager.GridLines = true;
            this.li_lager.Location = new System.Drawing.Point(24, 34);
            this.li_lager.Name = "li_lager";
            this.li_lager.Size = new System.Drawing.Size(434, 187);
            this.li_lager.TabIndex = 15;
            this.li_lager.UseCompatibleStateImageBehavior = false;
            this.li_lager.View = System.Windows.Forms.View.Details;
            this.li_lager.SelectedIndexChanged += new System.EventHandler(this.li_lager_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 659);
            this.Controls.Add(this.li_lager);
            this.Controls.Add(this.li_korfa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.korfu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button korfu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView li_korfa;
        private System.Windows.Forms.ListView li_lager;
    }
}


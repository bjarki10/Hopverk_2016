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
            this.bt_korfu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_Check_out = new System.Windows.Forms.Button();
            this.li_korfa = new System.Windows.Forms.ListView();
            this.li_lager = new System.Windows.Forms.ListView();
            this.bt_eda = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt_korfu
            // 
            this.bt_korfu.Location = new System.Drawing.Point(645, 110);
            this.bt_korfu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_korfu.Name = "bt_korfu";
            this.bt_korfu.Size = new System.Drawing.Size(100, 28);
            this.bt_korfu.TabIndex = 1;
            this.bt_korfu.Text = "bæta i korfu";
            this.bt_korfu.UseVisualStyleBackColor = true;
            this.bt_korfu.Click += new System.EventHandler(this.bt_korfu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 278);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_Check_out
            // 
            this.bt_Check_out.Location = new System.Drawing.Point(1008, 279);
            this.bt_Check_out.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Check_out.Name = "bt_Check_out";
            this.bt_Check_out.Size = new System.Drawing.Size(100, 28);
            this.bt_Check_out.TabIndex = 6;
            this.bt_Check_out.Text = "Check out";
            this.bt_Check_out.UseVisualStyleBackColor = true;
            this.bt_Check_out.Click += new System.EventHandler(this.bt_Check_out_Click);
            // 
            // li_korfa
            // 
            this.li_korfa.FullRowSelect = true;
            this.li_korfa.GridLines = true;
            this.li_korfa.Location = new System.Drawing.Point(777, 42);
            this.li_korfa.Margin = new System.Windows.Forms.Padding(4);
            this.li_korfa.Name = "li_korfa";
            this.li_korfa.Size = new System.Drawing.Size(577, 229);
            this.li_korfa.TabIndex = 14;
            this.li_korfa.UseCompatibleStateImageBehavior = false;
            this.li_korfa.View = System.Windows.Forms.View.Details;
            this.li_korfa.SelectedIndexChanged += new System.EventHandler(this.li_korfa_SelectedIndexChanged);
            // 
            // li_lager
            // 
            this.li_lager.FullRowSelect = true;
            this.li_lager.GridLines = true;
            this.li_lager.Location = new System.Drawing.Point(32, 42);
            this.li_lager.Margin = new System.Windows.Forms.Padding(4);
            this.li_lager.Name = "li_lager";
            this.li_lager.Size = new System.Drawing.Size(577, 229);
            this.li_lager.TabIndex = 15;
            this.li_lager.UseCompatibleStateImageBehavior = false;
            this.li_lager.View = System.Windows.Forms.View.Details;
            this.li_lager.SelectedIndexChanged += new System.EventHandler(this.li_lager_SelectedIndexChanged);
            this.li_lager.DoubleClick += new System.EventHandler(this.bt_korfu_Click);
            // 
            // bt_eda
            // 
            this.bt_eda.Location = new System.Drawing.Point(645, 188);
            this.bt_eda.Margin = new System.Windows.Forms.Padding(4);
            this.bt_eda.Name = "bt_eda";
            this.bt_eda.Size = new System.Drawing.Size(100, 28);
            this.bt_eda.TabIndex = 16;
            this.bt_eda.Text = "Eða ur korfu";
            this.bt_eda.UseVisualStyleBackColor = true;
            this.bt_eda.Click += new System.EventHandler(this.bt_eda_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(194, 401);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 811);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bt_eda);
            this.Controls.Add(this.li_lager);
            this.Controls.Add(this.li_korfa);
            this.Controls.Add(this.bt_Check_out);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_korfu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_korfu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_Check_out;
        private System.Windows.Forms.ListView li_korfa;
        private System.Windows.Forms.ListView li_lager;
        private System.Windows.Forms.Button bt_eda;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


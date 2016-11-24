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
            this.SuspendLayout();
            // 
            // li_korfa
            // 
            this.li_korfa.FullRowSelect = true;
            this.li_korfa.GridLines = true;
            this.li_korfa.Location = new System.Drawing.Point(12, 12);
            this.li_korfa.Name = "li_korfa";
            this.li_korfa.Size = new System.Drawing.Size(434, 187);
            this.li_korfa.TabIndex = 15;
            this.li_korfa.UseCompatibleStateImageBehavior = false;
            this.li_korfa.View = System.Windows.Forms.View.Details;
            // 
            // Check_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 294);
            this.Controls.Add(this.li_korfa);
            this.Name = "Check_out";
            this.Text = "Check_out";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView li_korfa;
    }
}
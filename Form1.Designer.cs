namespace letsgopingpong
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
            this.Igrac = new System.Windows.Forms.Label();
            this.igrpoeni = new System.Windows.Forms.Label();
            this.botpoeni = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Igrac
            // 
            this.Igrac.AutoSize = true;
            this.Igrac.Location = new System.Drawing.Point(12, 434);
            this.Igrac.Name = "Igrac";
            this.Igrac.Size = new System.Drawing.Size(31, 13);
            this.Igrac.TabIndex = 0;
            this.Igrac.Text = "Igrac";
            // 
            // igrpoeni
            // 
            this.igrpoeni.AutoSize = true;
            this.igrpoeni.Location = new System.Drawing.Point(53, 434);
            this.igrpoeni.Name = "igrpoeni";
            this.igrpoeni.Size = new System.Drawing.Size(13, 13);
            this.igrpoeni.TabIndex = 0;
            this.igrpoeni.Text = "0";
            // 
            // botpoeni
            // 
            this.botpoeni.AutoSize = true;
            this.botpoeni.Location = new System.Drawing.Point(487, 434);
            this.botpoeni.Name = "botpoeni";
            this.botpoeni.Size = new System.Drawing.Size(13, 13);
            this.botpoeni.TabIndex = 0;
            this.botpoeni.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 456);
            this.Controls.Add(this.botpoeni);
            this.Controls.Add(this.igrpoeni);
            this.Controls.Add(this.Igrac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Igrac;
        private System.Windows.Forms.Label igrpoeni;
        private System.Windows.Forms.Label botpoeni;
        private System.Windows.Forms.Timer timer1;
    }
}
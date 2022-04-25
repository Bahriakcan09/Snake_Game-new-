namespace Snake_Game
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scorLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 520);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 130;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scorLabel
            // 
            this.scorLabel.AutoSize = true;
            this.scorLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scorLabel.Location = new System.Drawing.Point(200, 32);
            this.scorLabel.Name = "scorLabel";
            this.scorLabel.Size = new System.Drawing.Size(82, 18);
            this.scorLabel.TabIndex = 1;
            this.scorLabel.Text = "SCOR : 0";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highScoreLabel.Location = new System.Drawing.Point(469, 32);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(131, 18);
            this.highScoreLabel.TabIndex = 2;
            this.highScoreLabel.Text = "HIGH SCOR : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.scorLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorLabel;
        private System.Windows.Forms.Label highScoreLabel;
    }
}


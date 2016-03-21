namespace ShotTest1
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
            this.PuckPos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PuckVel = new System.Windows.Forms.Label();
            this.Slope = new System.Windows.Forms.Label();
            this.Shots = new System.Windows.Forms.Label();
            this.Shot2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PuckPos
            // 
            this.PuckPos.AutoSize = true;
            this.PuckPos.Location = new System.Drawing.Point(12, 9);
            this.PuckPos.Name = "PuckPos";
            this.PuckPos.Size = new System.Drawing.Size(35, 13);
            this.PuckPos.TabIndex = 0;
            this.PuckPos.Text = "label1";
            this.PuckPos.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PuckVel
            // 
            this.PuckVel.AutoSize = true;
            this.PuckVel.Location = new System.Drawing.Point(12, 33);
            this.PuckVel.Name = "PuckVel";
            this.PuckVel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PuckVel.Size = new System.Drawing.Size(35, 13);
            this.PuckVel.TabIndex = 1;
            this.PuckVel.Text = "label1";
            // 
            // Slope
            // 
            this.Slope.AutoSize = true;
            this.Slope.Location = new System.Drawing.Point(12, 56);
            this.Slope.Name = "Slope";
            this.Slope.Size = new System.Drawing.Size(35, 13);
            this.Slope.TabIndex = 2;
            this.Slope.Text = "label1";
            // 
            // Shots
            // 
            this.Shots.AutoSize = true;
            this.Shots.Location = new System.Drawing.Point(15, 110);
            this.Shots.Name = "Shots";
            this.Shots.Size = new System.Drawing.Size(35, 13);
            this.Shots.TabIndex = 3;
            this.Shots.Text = "label1";
            // 
            // Shot2
            // 
            this.Shot2.AutoSize = true;
            this.Shot2.Location = new System.Drawing.Point(15, 132);
            this.Shot2.Name = "Shot2";
            this.Shot2.Size = new System.Drawing.Size(35, 13);
            this.Shot2.TabIndex = 4;
            this.Shot2.Text = "label1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Shot2);
            this.Controls.Add(this.Shots);
            this.Controls.Add(this.Slope);
            this.Controls.Add(this.PuckVel);
            this.Controls.Add(this.PuckPos);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PuckPos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PuckVel;
        private System.Windows.Forms.Label Slope;
        private System.Windows.Forms.Label Shots;
        private System.Windows.Forms.Label Shot2;

    }
}


namespace Snake
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
            this.BottomBoundary = new System.Windows.Forms.PictureBox();
            this.RightBoundary = new System.Windows.Forms.PictureBox();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Timer(this.components);
            this.Background = new System.Windows.Forms.PictureBox();
            this.LeftBoundary = new System.Windows.Forms.PictureBox();
            this.test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBoundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBoundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBoundary)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomBoundary
            // 
            this.BottomBoundary.Image = global::Snake.Properties.Resources.brown;
            this.BottomBoundary.Location = new System.Drawing.Point(-32, 419);
            this.BottomBoundary.Name = "BottomBoundary";
            this.BottomBoundary.Size = new System.Drawing.Size(833, 34);
            this.BottomBoundary.TabIndex = 3;
            this.BottomBoundary.TabStop = false;
            // 
            // RightBoundary
            // 
            this.RightBoundary.Image = global::Snake.Properties.Resources.brown;
            this.RightBoundary.Location = new System.Drawing.Point(785, 0);
            this.RightBoundary.Name = "RightBoundary";
            this.RightBoundary.Size = new System.Drawing.Size(15, 504);
            this.RightBoundary.TabIndex = 141;
            this.RightBoundary.TabStop = false;
            // 
            // move
            // 
            this.move.Enabled = true;
            this.move.Interval = 200;
            this.move.Tick += new System.EventHandler(this.Move_Tick);
            // 
            // reset
            // 
            this.reset.Enabled = true;
            this.reset.Interval = 10;
            this.reset.Tick += new System.EventHandler(this.Reset_Tick);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Location = new System.Drawing.Point(0, 1);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(797, 446);
            this.Background.TabIndex = 142;
            this.Background.TabStop = false;
            // 
            // LeftBoundary
            // 
            this.LeftBoundary.Image = global::Snake.Properties.Resources.brown;
            this.LeftBoundary.Location = new System.Drawing.Point(0, -34);
            this.LeftBoundary.Name = "LeftBoundary";
            this.LeftBoundary.Size = new System.Drawing.Size(29, 504);
            this.LeftBoundary.TabIndex = 143;
            this.LeftBoundary.TabStop = false;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(543, 224);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(31, 17);
            this.test.TabIndex = 144;
            this.test.Text = "test";
            this.test.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.LeftBoundary);
            this.Controls.Add(this.RightBoundary);
            this.Controls.Add(this.BottomBoundary);
            this.Controls.Add(this.Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BottomBoundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBoundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBoundary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BottomBoundary;
        private System.Windows.Forms.PictureBox RightBoundary;
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.Timer reset;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox LeftBoundary;
        private System.Windows.Forms.Label test;
    }
}


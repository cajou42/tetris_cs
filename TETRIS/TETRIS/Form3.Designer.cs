
namespace TETRIS
{
    partial class Form3
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
            this.tuto = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.changeMusic = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tuto
            // 
            this.tuto.Location = new System.Drawing.Point(47, 212);
            this.tuto.Name = "tuto";
            this.tuto.Size = new System.Drawing.Size(75, 32);
            this.tuto.TabIndex = 0;
            this.tuto.Text = "tuto";
            this.tuto.UseVisualStyleBackColor = true;
            this.tuto.Click += new System.EventHandler(this.tuto_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(682, 396);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // changeMusic
            // 
            this.changeMusic.Location = new System.Drawing.Point(235, 212);
            this.changeMusic.Name = "changeMusic";
            this.changeMusic.Size = new System.Drawing.Size(173, 32);
            this.changeMusic.TabIndex = 2;
            this.changeMusic.Text = "change the music";
            this.changeMusic.UseVisualStyleBackColor = true;
            this.changeMusic.Click += new System.EventHandler(this.changeMusic_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(232, 260);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(46, 17);
            this.info.TabIndex = 3;
            this.info.Text = "label1";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(473, 212);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.changeMusic);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tuto);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tuto;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button changeMusic;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}
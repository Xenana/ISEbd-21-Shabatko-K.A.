﻿namespace WindowsFormsApplication4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.max_speed = new System.Windows.Forms.TextBox();
            this.max_count_pass = new System.Windows.Forms.TextBox();
            this.weightt = new System.Windows.Forms.TextBox();
            this.strips = new System.Windows.Forms.CheckBox();
            this.engines = new System.Windows.Forms.CheckBox();
            this.plane = new System.Windows.Forms.Button();
            this.light_plane = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.button_color1 = new System.Windows.Forms.Button();
            this.button_color2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 293);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Speed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Count Passangers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color";
            // 
            // max_speed
            // 
            this.max_speed.Location = new System.Drawing.Point(139, 353);
            this.max_speed.Name = "max_speed";
            this.max_speed.Size = new System.Drawing.Size(65, 20);
            this.max_speed.TabIndex = 6;
            this.max_speed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // max_count_pass
            // 
            this.max_count_pass.Location = new System.Drawing.Point(139, 386);
            this.max_count_pass.Name = "max_count_pass";
            this.max_count_pass.Size = new System.Drawing.Size(65, 20);
            this.max_count_pass.TabIndex = 7;
            // 
            // weightt
            // 
            this.weightt.Location = new System.Drawing.Point(274, 354);
            this.weightt.Name = "weightt";
            this.weightt.Size = new System.Drawing.Size(65, 20);
            this.weightt.TabIndex = 8;
            // 
            // strips
            // 
            this.strips.AutoSize = true;
            this.strips.Location = new System.Drawing.Point(377, 391);
            this.strips.Name = "strips";
            this.strips.Size = new System.Drawing.Size(52, 17);
            this.strips.TabIndex = 11;
            this.strips.Text = "Strips";
            this.strips.UseVisualStyleBackColor = true;
            // 
            // engines
            // 
            this.engines.AutoSize = true;
            this.engines.Location = new System.Drawing.Point(377, 357);
            this.engines.Name = "engines";
            this.engines.Size = new System.Drawing.Size(64, 17);
            this.engines.TabIndex = 12;
            this.engines.Text = "Engines";
            this.engines.UseVisualStyleBackColor = true;
            // 
            // plane
            // 
            this.plane.Location = new System.Drawing.Point(264, 440);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(75, 37);
            this.plane.TabIndex = 13;
            this.plane.Text = "Задать самолет";
            this.plane.UseVisualStyleBackColor = true;
            this.plane.Click += new System.EventHandler(this.plane_Click_1);
            // 
            // light_plane
            // 
            this.light_plane.Location = new System.Drawing.Point(450, 440);
            this.light_plane.Name = "light_plane";
            this.light_plane.Size = new System.Drawing.Size(96, 37);
            this.light_plane.TabIndex = 14;
            this.light_plane.Text = "Задать легкий самолет";
            this.light_plane.UseVisualStyleBackColor = true;
            this.light_plane.Click += new System.EventHandler(this.light_plane_Click_1);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(620, 369);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 36);
            this.button_move.TabIndex = 15;
            this.button_move.Text = "Движение";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // button_color1
            // 
            this.button_color1.Location = new System.Drawing.Point(274, 386);
            this.button_color1.Name = "button_color1";
            this.button_color1.Size = new System.Drawing.Size(65, 28);
            this.button_color1.TabIndex = 16;
            this.button_color1.Text = "Color";
            this.button_color1.UseVisualStyleBackColor = true;
            this.button_color1.Click += new System.EventHandler(this.button_color1_Click_1);
            // 
            // button_color2
            // 
            this.button_color2.Location = new System.Drawing.Point(481, 386);
            this.button_color2.Name = "button_color2";
            this.button_color2.Size = new System.Drawing.Size(65, 28);
            this.button_color2.TabIndex = 17;
            this.button_color2.Text = "Color";
            this.button_color2.UseVisualStyleBackColor = true;
            this.button_color2.Click += new System.EventHandler(this.button_color2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 489);
            this.Controls.Add(this.button_color2);
            this.Controls.Add(this.button_color1);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.light_plane);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.engines);
            this.Controls.Add(this.strips);
            this.Controls.Add(this.weightt);
            this.Controls.Add(this.max_count_pass);
            this.Controls.Add(this.max_speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox max_speed;
        private System.Windows.Forms.TextBox max_count_pass;
        private System.Windows.Forms.TextBox weightt;
        private System.Windows.Forms.CheckBox strips;
        private System.Windows.Forms.CheckBox engines;
        private System.Windows.Forms.Button plane;
        private System.Windows.Forms.Button light_plane;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Button button_color1;
        private System.Windows.Forms.Button button_color2;
    }
}


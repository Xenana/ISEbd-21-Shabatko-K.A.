namespace WindowsFormsApplication4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLightPlane = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.BaseColor = new System.Windows.Forms.Label();
            this.DopColor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelPlane.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLightPlane);
            this.groupBox1.Controls.Add(this.labelPlane);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelLightPlane
            // 
            this.labelLightPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLightPlane.Location = new System.Drawing.Point(16, 70);
            this.labelLightPlane.Name = "labelLightPlane";
            this.labelLightPlane.Size = new System.Drawing.Size(81, 30);
            this.labelLightPlane.TabIndex = 1;
            this.labelLightPlane.Text = "Легкий самолет";
            this.labelLightPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelLightPlane_DragEnter);
            this.labelLightPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLightPlane_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(16, 24);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(81, 33);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Самолет";
            this.labelPlane.Click += new System.EventHandler(this.labelPlane_Click);
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(18, 159);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(76, 24);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(61, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 24);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // BaseColor
            // 
            this.BaseColor.AllowDrop = true;
            this.BaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseColor.Location = new System.Drawing.Point(65, 127);
            this.BaseColor.Name = "BaseColor";
            this.BaseColor.Size = new System.Drawing.Size(86, 38);
            this.BaseColor.TabIndex = 5;
            this.BaseColor.Text = "Основной цвет";
            this.BaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.BaseColor_DragDrop);
            this.BaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.BaseColor_DragEnter);
            // 
            // DopColor
            // 
            this.DopColor.AllowDrop = true;
            this.DopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DopColor.Location = new System.Drawing.Point(65, 176);
            this.DopColor.Name = "DopColor";
            this.DopColor.Size = new System.Drawing.Size(86, 38);
            this.DopColor.TabIndex = 6;
            this.DopColor.Text = "Доп. цвет";
            this.DopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.DopColor_DragDrop);
            this.DopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.BaseColor_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(20, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 109);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelOrange);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(407, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 217);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(68, 164);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(38, 38);
            this.panelOrange.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(68, 115);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 38);
            this.panelYellow.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(68, 71);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 38);
            this.panelBlue.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(68, 20);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(38, 38);
            this.panelWhite.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(7, 164);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(38, 38);
            this.panelGray.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(7, 115);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 38);
            this.panelRed.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(7, 71);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 38);
            this.panelGreen.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(7, 20);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 38);
            this.panelBlack.TabIndex = 0;
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.DopColor);
            this.panelPlane.Controls.Add(this.BaseColor);
            this.panelPlane.Controls.Add(this.pictureBox2);
            this.panelPlane.Location = new System.Drawing.Point(166, 3);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(223, 230);
            this.panelPlane.TabIndex = 9;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 249);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLightPlane;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.Label BaseColor;
        private System.Windows.Forms.Label DopColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
    }
}
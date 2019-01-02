namespace WindowsFormsBus
{
    partial class FormBusConfig
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
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBu = new System.Windows.Forms.Label();
            this.labelBus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(123, 25);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(46, 41);
            this.panelBlack.TabIndex = 2;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(61, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 40);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelPink.Location = new System.Drawing.Point(123, 201);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(46, 41);
            this.panelPink.TabIndex = 1;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(123, 139);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(46, 41);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(27, 201);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(46, 41);
            this.panelPurple.TabIndex = 1;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(27, 139);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(46, 41);
            this.panelLime.TabIndex = 3;
            this.panelLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(27, 83);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(46, 41);
            this.panelRed.TabIndex = 1;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(27, 25);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(46, 41);
            this.panelWhite.TabIndex = 0;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(62, 211);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 38);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(31, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дополнительный цвет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(31, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Основной цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBus.Location = new System.Drawing.Point(18, 17);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(195, 95);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBu);
            this.groupBox1.Controls.Add(this.labelBus);
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelBu
            // 
            this.labelBu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBu.Location = new System.Drawing.Point(20, 83);
            this.labelBu.Name = "labelBu";
            this.labelBu.Size = new System.Drawing.Size(158, 46);
            this.labelBu.TabIndex = 1;
            this.labelBu.Text = "Автобус с гармошкой";
            this.labelBu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBu_MouseDown);
            // 
            // labelBus
            // 
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(20, 18);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(158, 48);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Обычный автобус";
            this.labelBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelPink);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelPurple);
            this.groupBox2.Controls.Add(this.panelLime);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Location = new System.Drawing.Point(532, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 249);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(123, 83);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(46, 41);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxBus);
            this.panel1.Location = new System.Drawing.Point(242, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 289);
            this.panel1.TabIndex = 7;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBus_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBus_DragEnter);
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 334);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBu;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panel1;
    }
}
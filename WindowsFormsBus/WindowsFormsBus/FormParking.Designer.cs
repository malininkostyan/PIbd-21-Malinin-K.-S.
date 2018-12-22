namespace WindowsFormsBus
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeBus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.buttonSetBus = new System.Windows.Forms.Button();
            this.buttonSetStandartBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1140, 598);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // pictureBoxTakeBus
            // 
            this.pictureBoxTakeBus.Location = new System.Drawing.Point(1103, 497);
            this.pictureBoxTakeBus.Name = "pictureBoxTakeBus";
            this.pictureBoxTakeBus.Size = new System.Drawing.Size(205, 99);
            this.pictureBoxTakeBus.TabIndex = 7;
            this.pictureBoxTakeBus.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1175, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(1273, 378);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(35, 22);
            this.maskedTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1168, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Забрать автобус";
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(1178, 418);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(108, 34);
            this.buttonTakeBus.TabIndex = 8;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click);
            // 
            // buttonSetBus
            // 
            this.buttonSetBus.Location = new System.Drawing.Point(1157, 204);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(167, 79);
            this.buttonSetBus.TabIndex = 12;
            this.buttonSetBus.Text = "Припарковать автобус с гармошкой";
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click_1);
            // 
            // buttonSetStandartBus
            // 
            this.buttonSetStandartBus.Location = new System.Drawing.Point(1157, 101);
            this.buttonSetStandartBus.Name = "buttonSetStandartBus";
            this.buttonSetStandartBus.Size = new System.Drawing.Size(167, 79);
            this.buttonSetStandartBus.TabIndex = 13;
            this.buttonSetStandartBus.Text = "Припарковать автобус";
            this.buttonSetStandartBus.UseVisualStyleBackColor = true;
            this.buttonSetStandartBus.Click += new System.EventHandler(this.buttonSetStandartBus_Click_1);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 608);
            this.Controls.Add(this.buttonSetBus);
            this.Controls.Add(this.buttonSetStandartBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeBus);
            this.Controls.Add(this.pictureBoxTakeBus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxTakeBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.Button buttonSetBus;
        private System.Windows.Forms.Button buttonSetStandartBus;
    }
}
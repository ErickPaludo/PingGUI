namespace ServerOnOrOff
{
    partial class PinHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinHome));
            pictureOnOff = new PictureBox();
            label1 = new Label();
            labelIp = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureOnOff).BeginInit();
            SuspendLayout();
            // 
            // pictureOnOff
            // 
            pictureOnOff.BackColor = Color.Transparent;
            pictureOnOff.Image = (Image)resources.GetObject("pictureOnOff.Image");
            pictureOnOff.Location = new Point(12, 61);
            pictureOnOff.Name = "pictureOnOff";
            pictureOnOff.Size = new Size(90, 90);
            pictureOnOff.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOnOff.TabIndex = 0;
            pictureOnOff.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(108, 73);
            label1.Name = "label1";
            label1.Size = new Size(218, 65);
            label1.TabIndex = 1;
            label1.Text = "IP server:";
            // 
            // labelIp
            // 
            labelIp.AutoSize = true;
            labelIp.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIp.ForeColor = SystemColors.ButtonHighlight;
            labelIp.Location = new Point(309, 85);
            labelIp.Name = "labelIp";
            labelIp.Size = new Size(42, 50);
            labelIp.TabIndex = 2;
            labelIp.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(520, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 25);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Configuracao;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(560, 225);
            Controls.Add(button1);
            Controls.Add(labelIp);
            Controls.Add(label1);
            Controls.Add(pictureOnOff);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureOnOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureOnOff;
        private Label label1;
        private Label labelIp;
        private Button button1;
    }
}

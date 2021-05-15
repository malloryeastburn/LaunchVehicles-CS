
namespace LaunchVehicles
{
    partial class frmMain
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnLV2 = new System.Windows.Forms.Button();
            this.btnLV1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.imgLV = new System.Windows.Forms.PictureBox();
            this.imgSpaceX = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpaceX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLeft.Controls.Add(this.btnLV2);
            this.pnlLeft.Controls.Add(this.imgSpaceX);
            this.pnlLeft.Controls.Add(this.btnLV1);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(6);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(268, 461);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnLV2
            // 
            this.btnLV2.FlatAppearance.BorderSize = 0;
            this.btnLV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV2.Location = new System.Drawing.Point(0, 230);
            this.btnLV2.Margin = new System.Windows.Forms.Padding(6);
            this.btnLV2.Name = "btnLV2";
            this.btnLV2.Size = new System.Drawing.Size(268, 42);
            this.btnLV2.TabIndex = 2;
            this.btnLV2.Text = "Falcon &9";
            this.btnLV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLV2.UseVisualStyleBackColor = true;
            this.btnLV2.MouseEnter += new System.EventHandler(this.btnLV2_MouseEnter);
            this.btnLV2.MouseLeave += new System.EventHandler(this.btnLV2_MouseLeave);
            // 
            // btnLV1
            // 
            this.btnLV1.FlatAppearance.BorderSize = 0;
            this.btnLV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV1.Location = new System.Drawing.Point(0, 191);
            this.btnLV1.Margin = new System.Windows.Forms.Padding(6);
            this.btnLV1.Name = "btnLV1";
            this.btnLV1.Size = new System.Drawing.Size(268, 42);
            this.btnLV1.TabIndex = 1;
            this.btnLV1.Text = "&Falcon Heavy";
            this.btnLV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLV1.UseVisualStyleBackColor = true;
            this.btnLV1.MouseEnter += new System.EventHandler(this.btnLV1_MouseEnter);
            this.btnLV1.MouseLeave += new System.EventHandler(this.btnLV1_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(0, 419);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlRight.Controls.Add(this.imgLV);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(266, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(568, 461);
            this.pnlRight.TabIndex = 2;
            // 
            // imgLV
            // 
            this.imgLV.Location = new System.Drawing.Point(139, 41);
            this.imgLV.Name = "imgLV";
            this.imgLV.Size = new System.Drawing.Size(322, 231);
            this.imgLV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLV.TabIndex = 2;
            this.imgLV.TabStop = false;
            // 
            // imgSpaceX
            // 
            this.imgSpaceX.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgSpaceX.Image = global::LaunchVehicles.Properties.Resources.SpaceX_Wallpapers;
            this.imgSpaceX.Location = new System.Drawing.Point(0, 0);
            this.imgSpaceX.Name = "imgSpaceX";
            this.imgSpaceX.Size = new System.Drawing.Size(268, 156);
            this.imgSpaceX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSpaceX.TabIndex = 3;
            this.imgSpaceX.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceX  - Launch Vehicles";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpaceX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLV1;
        private System.Windows.Forms.PictureBox imgLV;
        private System.Windows.Forms.Button btnLV2;
        private System.Windows.Forms.PictureBox imgSpaceX;
    }
}


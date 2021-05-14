
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
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnLV2 = new System.Windows.Forms.Button();
            this.btnLV1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.imgLV = new System.Windows.Forms.PictureBox();
            this.pnlTopRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.BackColor = System.Drawing.Color.Silver;
            this.pnlTopRight.Controls.Add(this.pnlTopLeft);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopRight.Location = new System.Drawing.Point(0, 0);
            this.pnlTopRight.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(834, 37);
            this.pnlTopRight.TabIndex = 0;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(177, 37);
            this.pnlTopLeft.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLeft.Controls.Add(this.btnLV2);
            this.pnlLeft.Controls.Add(this.btnLV1);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 37);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(6);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(177, 424);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnLV2
            // 
            this.btnLV2.FlatAppearance.BorderSize = 0;
            this.btnLV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV2.Location = new System.Drawing.Point(0, 230);
            this.btnLV2.Margin = new System.Windows.Forms.Padding(6);
            this.btnLV2.Name = "btnLV2";
            this.btnLV2.Size = new System.Drawing.Size(177, 42);
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
            this.btnLV1.Size = new System.Drawing.Size(177, 42);
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
            this.btnExit.Location = new System.Drawing.Point(0, 382);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 42);
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
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(177, 37);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(657, 424);
            this.pnlRight.TabIndex = 2;
            // 
            // imgLV
            // 
            this.imgLV.Image = global::LaunchVehicles.Properties.Resources.SpaceX_Wallpapers;
            this.imgLV.Location = new System.Drawing.Point(149, 69);
            this.imgLV.Name = "imgLV";
            this.imgLV.Size = new System.Drawing.Size(376, 269);
            this.imgLV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLV.TabIndex = 2;
            this.imgLV.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTopRight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceX  - Launch Vehicles";
            this.pnlTopRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLV1;
        private System.Windows.Forms.PictureBox imgLV;
        private System.Windows.Forms.Button btnLV2;
    }
}


namespace Dictionary1
{
    partial class Main
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblang = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.moving = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnRes = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.mask = new System.Windows.Forms.Panel();
            this.alert = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.nghia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tuLoai = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.read = new System.Windows.Forms.PictureBox();
            this.phienAm = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnViDu = new System.Windows.Forms.Panel();
            this.vd1 = new System.Windows.Forms.Label();
            this.vd2 = new System.Windows.Forms.Label();
            this.vd3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnRes.SuspendLayout();
            this.mask.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.read)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnViDu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(104)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.lblang);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.moving.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblang
            // 
            this.lblang.AutoSize = true;
            this.moving.SetDecoration(this.lblang, BunifuAnimatorNS.DecorationType.None);
            this.lblang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblang.Location = new System.Drawing.Point(39, 16);
            this.lblang.Name = "lblang";
            this.lblang.Size = new System.Drawing.Size(17, 13);
            this.lblang.TabIndex = 3;
            this.lblang.Text = "vi";
            // 
            // pictureBox3
            // 
            this.moving.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Dictionary1.Properties.Resources._switch;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.moving.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Dictionary1.Properties.Resources.cross;
            this.pictureBox1.Location = new System.Drawing.Point(401, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.moving.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUN DICTIONARY";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(104)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.moving.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 19);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.moving.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::Dictionary1.Properties.Resources.settings_work_tool;
            this.pictureBox4.Location = new System.Drawing.Point(401, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // moving
            // 
            this.moving.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.moving.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.moving.DefaultAnimation = animation2;
            this.moving.MaxAnimationTime = 1000;
            // 
            // pnRes
            // 
            this.pnRes.AutoScroll = true;
            this.pnRes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnRes.BackgroundImage")));
            this.pnRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnRes.Controls.Add(this.mask);
            this.pnRes.Controls.Add(this.separator);
            this.pnRes.Controls.Add(this.pnViDu);
            this.pnRes.Controls.Add(this.pn1);
            this.moving.SetDecoration(this.pnRes, BunifuAnimatorNS.DecorationType.None);
            this.pnRes.GradientBottomLeft = System.Drawing.Color.White;
            this.pnRes.GradientBottomRight = System.Drawing.Color.White;
            this.pnRes.GradientTopLeft = System.Drawing.Color.White;
            this.pnRes.GradientTopRight = System.Drawing.Color.White;
            this.pnRes.Location = new System.Drawing.Point(12, 113);
            this.pnRes.Name = "pnRes";
            this.pnRes.Quality = 10;
            this.pnRes.Size = new System.Drawing.Size(414, 327);
            this.pnRes.TabIndex = 2;
            // 
            // mask
            // 
            this.mask.Controls.Add(this.alert);
            this.moving.SetDecoration(this.mask, BunifuAnimatorNS.DecorationType.None);
            this.mask.Location = new System.Drawing.Point(7, 0);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(398, 100);
            this.mask.TabIndex = 3;
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.moving.SetDecoration(this.alert, BunifuAnimatorNS.DecorationType.None);
            this.alert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(133, 5);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(139, 20);
            this.alert.TabIndex = 3;
            this.alert.Text = "⚠ Không tìm thấy!";
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.moving.SetDecoration(this.separator, BunifuAnimatorNS.DecorationType.None);
            this.separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separator.LineThickness = 1;
            this.separator.Location = new System.Drawing.Point(-2, 108);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(411, 10);
            this.separator.TabIndex = 3;
            this.separator.Transparency = 255;
            this.separator.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.moving.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "▶ Ví dụ";
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.nghia);
            this.pn1.Controls.Add(this.tuLoai);
            this.pn1.Controls.Add(this.read);
            this.pn1.Controls.Add(this.phienAm);
            this.moving.SetDecoration(this.pn1, BunifuAnimatorNS.DecorationType.None);
            this.pn1.Location = new System.Drawing.Point(4, 3);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(407, 104);
            this.pn1.TabIndex = 2;
            // 
            // nghia
            // 
            this.nghia.AutoSize = true;
            this.moving.SetDecoration(this.nghia, BunifuAnimatorNS.DecorationType.None);
            this.nghia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nghia.Location = new System.Drawing.Point(19, 63);
            this.nghia.MaximumSize = new System.Drawing.Size(400, 60);
            this.nghia.Name = "nghia";
            this.nghia.Size = new System.Drawing.Size(145, 20);
            this.nghia.TabIndex = 2;
            this.nghia.Text = "bunifuCustomLabel1";
            // 
            // tuLoai
            // 
            this.tuLoai.AutoSize = true;
            this.moving.SetDecoration(this.tuLoai, BunifuAnimatorNS.DecorationType.None);
            this.tuLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuLoai.ForeColor = System.Drawing.Color.DimGray;
            this.tuLoai.Location = new System.Drawing.Point(3, 38);
            this.tuLoai.Name = "tuLoai";
            this.tuLoai.Size = new System.Drawing.Size(126, 17);
            this.tuLoai.TabIndex = 2;
            this.tuLoai.Text = "bunifuCustomLabel1";
            // 
            // read
            // 
            this.moving.SetDecoration(this.read, BunifuAnimatorNS.DecorationType.None);
            this.read.Image = global::Dictionary1.Properties.Resources.speaker;
            this.read.Location = new System.Drawing.Point(6, 3);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(21, 25);
            this.read.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.read.TabIndex = 1;
            this.read.TabStop = false;
            this.read.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // phienAm
            // 
            this.phienAm.AutoSize = true;
            this.moving.SetDecoration(this.phienAm, BunifuAnimatorNS.DecorationType.None);
            this.phienAm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phienAm.Location = new System.Drawing.Point(30, 7);
            this.phienAm.Name = "phienAm";
            this.phienAm.Size = new System.Drawing.Size(64, 17);
            this.phienAm.TabIndex = 0;
            this.phienAm.Text = "phienAm";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.searchBox);
            this.moving.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 48);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(414, 59);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.moving.SetDecoration(this.searchBox, BunifuAnimatorNS.DecorationType.None);
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.HintForeColor = System.Drawing.Color.Empty;
            this.searchBox.HintText = "";
            this.searchBox.isPassword = false;
            this.searchBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(128)))), ((int)(((byte)(145)))));
            this.searchBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchBox.LineThickness = 4;
            this.searchBox.Location = new System.Drawing.Point(3, 14);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(407, 35);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // pnViDu
            // 
            this.pnViDu.Controls.Add(this.vd3);
            this.pnViDu.Controls.Add(this.vd2);
            this.pnViDu.Controls.Add(this.vd1);
            this.pnViDu.Controls.Add(this.label2);
            this.moving.SetDecoration(this.pnViDu, BunifuAnimatorNS.DecorationType.None);
            this.pnViDu.Location = new System.Drawing.Point(4, 113);
            this.pnViDu.Name = "pnViDu";
            this.pnViDu.Size = new System.Drawing.Size(407, 211);
            this.pnViDu.TabIndex = 4;
            // 
            // vd1
            // 
            this.vd1.AutoSize = true;
            this.moving.SetDecoration(this.vd1, BunifuAnimatorNS.DecorationType.None);
            this.vd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vd1.Location = new System.Drawing.Point(30, 69);
            this.vd1.Name = "vd1";
            this.vd1.Size = new System.Drawing.Size(55, 18);
            this.vd1.TabIndex = 1;
            this.vd1.Text = "▶ Ví dụ";
            // 
            // vd2
            // 
            this.vd2.AutoSize = true;
            this.moving.SetDecoration(this.vd2, BunifuAnimatorNS.DecorationType.None);
            this.vd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vd2.Location = new System.Drawing.Point(30, 120);
            this.vd2.Name = "vd2";
            this.vd2.Size = new System.Drawing.Size(55, 18);
            this.vd2.TabIndex = 1;
            this.vd2.Text = "▶ Ví dụ";
            // 
            // vd3
            // 
            this.vd3.AutoSize = true;
            this.moving.SetDecoration(this.vd3, BunifuAnimatorNS.DecorationType.None);
            this.vd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vd3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vd3.Location = new System.Drawing.Point(30, 166);
            this.vd3.Name = "vd3";
            this.vd3.Size = new System.Drawing.Size(55, 18);
            this.vd3.TabIndex = 1;
            this.vd3.Text = "▶ Ví dụ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnRes);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.moving.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnRes.ResumeLayout(false);
            this.mask.ResumeLayout(false);
            this.mask.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.read)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnViDu.ResumeLayout(false);
            this.pnViDu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnRes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblang;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pn1;
        private BunifuAnimatorNS.BunifuTransition moving;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator separator;
        private Bunifu.Framework.UI.BunifuCustomLabel nghia;
        private Bunifu.Framework.UI.BunifuCustomLabel tuLoai;
        private System.Windows.Forms.PictureBox read;
        private System.Windows.Forms.Label phienAm;
        private System.Windows.Forms.Panel mask;
        private Bunifu.Framework.UI.BunifuCustomLabel alert;
        private System.Windows.Forms.Panel pnViDu;
        private System.Windows.Forms.Label vd3;
        private System.Windows.Forms.Label vd2;
        private System.Windows.Forms.Label vd1;
    }
}


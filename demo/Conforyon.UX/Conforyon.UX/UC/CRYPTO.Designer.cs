
namespace Conforyon.UX.UC
{
    partial class CRYPTO
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TACB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TBCB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.CVTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CRTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CSS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.HFN = new ReaLTaiizor.Controls.FoxNotification();
            this.HFTD = new ReaLTaiizor.Controls.MaterialDivider();
            this.HFBD = new ReaLTaiizor.Controls.MaterialDivider();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.CTB = new ReaLTaiizor.Controls.MaterialButton();
            this.TTB = new ReaLTaiizor.Controls.MaterialButton();
            this.CRCB = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TACB
            // 
            this.TACB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TACB.AutoResize = false;
            this.TACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TACB.Depth = 0;
            this.TACB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TACB.DropDownHeight = 60;
            this.TACB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TACB.DropDownWidth = 121;
            this.TACB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TACB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TACB.FormattingEnabled = true;
            this.TACB.Hint = "Type A";
            this.TACB.IntegralHeight = false;
            this.TACB.ItemHeight = 29;
            this.TACB.Items.AddRange(new object[] {
            "TEXT",
            "BASE"});
            this.TACB.Location = new System.Drawing.Point(3, 4);
            this.TACB.MaxDropDownItems = 2;
            this.TACB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TACB.Name = "TACB";
            this.TACB.Size = new System.Drawing.Size(121, 35);
            this.TACB.StartIndex = 0;
            this.TACB.TabIndex = 0;
            this.TACB.UseTallSize = false;
            this.TACB.SelectedIndexChanged += new System.EventHandler(this.TCB_SelectedIndexChanged);
            // 
            // TBCB
            // 
            this.TBCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBCB.AutoResize = false;
            this.TBCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBCB.Depth = 0;
            this.TBCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TBCB.DropDownHeight = 205;
            this.TBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TBCB.DropDownWidth = 121;
            this.TBCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TBCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBCB.FormattingEnabled = true;
            this.TBCB.Hint = "Type B";
            this.TBCB.IntegralHeight = false;
            this.TBCB.ItemHeight = 29;
            this.TBCB.Items.AddRange(new object[] {
            "BASE",
            "TEXT",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.TBCB.Location = new System.Drawing.Point(182, 4);
            this.TBCB.MaxDropDownItems = 7;
            this.TBCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TBCB.Name = "TBCB";
            this.TBCB.Size = new System.Drawing.Size(121, 35);
            this.TBCB.StartIndex = 0;
            this.TBCB.TabIndex = 2;
            this.TBCB.UseTallSize = false;
            this.TBCB.SelectedIndexChanged += new System.EventHandler(this.TCB_SelectedIndexChanged);
            // 
            // CVTB
            // 
            this.CVTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CVTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CVTB.Depth = 0;
            this.CVTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CVTB.Hint = "Crypto Value";
            this.CVTB.Location = new System.Drawing.Point(3, 45);
            this.CVTB.MaxLength = 5000;
            this.CVTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CVTB.Multiline = false;
            this.CVTB.Name = "CVTB";
            this.CVTB.Size = new System.Drawing.Size(300, 50);
            this.CVTB.TabIndex = 3;
            this.CVTB.Text = "Taiizor";
            // 
            // CRTB
            // 
            this.CRTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CRTB.Depth = 0;
            this.CRTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CRTB.Hint = "Crypto Result";
            this.CRTB.Location = new System.Drawing.Point(3, 101);
            this.CRTB.MaxLength = 5000;
            this.CRTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CRTB.Multiline = false;
            this.CRTB.Name = "CRTB";
            this.CRTB.ReadOnly = true;
            this.CRTB.Size = new System.Drawing.Size(249, 50);
            this.CRTB.TabIndex = 4;
            this.CRTB.Text = "VGFpaXpvcg==";
            // 
            // CSS
            // 
            this.CSS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CSS.AutoSize = true;
            this.CSS.Depth = 0;
            this.CSS.Location = new System.Drawing.Point(77, 205);
            this.CSS.Margin = new System.Windows.Forms.Padding(0);
            this.CSS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CSS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CSS.Name = "CSS";
            this.CSS.Ripple = true;
            this.CSS.Size = new System.Drawing.Size(152, 37);
            this.CSS.TabIndex = 8;
            this.CSS.Text = "Core Settings";
            this.CSS.UseAccentColor = true;
            this.CSS.UseVisualStyleBackColor = true;
            this.CSS.CheckedChanged += new System.EventHandler(this.CSS_CheckedChanged);
            // 
            // HFN
            // 
            this.HFN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HFN.BlueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.HFN.BlueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))));
            this.HFN.BlueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(184)))));
            this.HFN.Cursor = System.Windows.Forms.Cursors.Default;
            this.HFN.EnabledCalc = true;
            this.HFN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HFN.GreenBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(214)))));
            this.HFN.GreenBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(182)))));
            this.HFN.GreenTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.HFN.Location = new System.Drawing.Point(3, 253);
            this.HFN.Name = "HFN";
            this.HFN.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HFN.RedBarColor = System.Drawing.Color.Orange;
            this.HFN.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.HFN.Size = new System.Drawing.Size(300, 40);
            this.HFN.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.HFN.TabIndex = 10;
            this.HFN.Text = "The converter does not have a core formula!";
            this.HFN.YellowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.HFN.YellowBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.HFN.YellowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
            // 
            // HFTD
            // 
            this.HFTD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HFTD.BackColor = System.Drawing.Color.Orange;
            this.HFTD.Depth = 0;
            this.HFTD.Location = new System.Drawing.Point(3, 253);
            this.HFTD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.HFTD.Name = "HFTD";
            this.HFTD.Size = new System.Drawing.Size(75, 1);
            this.HFTD.TabIndex = 9;
            this.HFTD.Text = "HFTD";
            // 
            // HFBD
            // 
            this.HFBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HFBD.BackColor = System.Drawing.Color.Orange;
            this.HFBD.Depth = 0;
            this.HFBD.Location = new System.Drawing.Point(3, 292);
            this.HFBD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.HFBD.Name = "HFBD";
            this.HFBD.Size = new System.Drawing.Size(175, 1);
            this.HFBD.TabIndex = 11;
            this.HFBD.Text = "HFBD";
            // 
            // CYB
            // 
            this.CYB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CYB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CYB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CYB.Depth = 0;
            this.CYB.DrawShadows = false;
            this.CYB.HighEmphasis = true;
            this.CYB.Icon = global::Conforyon.UX.Properties.Resources.Copy;
            this.CYB.Location = new System.Drawing.Point(259, 160);
            this.CYB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CYB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CYB.Name = "CYB";
            this.CYB.Size = new System.Drawing.Size(44, 36);
            this.CYB.TabIndex = 7;
            this.CYB.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.CYB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CYB.UseAccentColor = false;
            this.CYB.UseVisualStyleBackColor = true;
            this.CYB.Click += new System.EventHandler(this.CYB_Click);
            // 
            // CTB
            // 
            this.CTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CTB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTB.Depth = 0;
            this.CTB.DrawShadows = false;
            this.CTB.HighEmphasis = true;
            this.CTB.Icon = global::Conforyon.UX.Properties.Resources.Merge;
            this.CTB.Location = new System.Drawing.Point(3, 160);
            this.CTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CTB.Name = "CTB";
            this.CTB.Size = new System.Drawing.Size(116, 36);
            this.CTB.TabIndex = 6;
            this.CTB.Text = "CONVERT";
            this.CTB.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.CTB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CTB.UseAccentColor = false;
            this.CTB.UseVisualStyleBackColor = true;
            this.CTB.Click += new System.EventHandler(this.CTB_Click);
            // 
            // TTB
            // 
            this.TTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TTB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TTB.Depth = 0;
            this.TTB.DrawShadows = false;
            this.TTB.HighEmphasis = true;
            this.TTB.Icon = global::Conforyon.UX.Properties.Resources.Transfer;
            this.TTB.Location = new System.Drawing.Point(131, 3);
            this.TTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TTB.Name = "TTB";
            this.TTB.Size = new System.Drawing.Size(44, 36);
            this.TTB.TabIndex = 1;
            this.TTB.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.TTB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TTB.UseAccentColor = false;
            this.TTB.UseVisualStyleBackColor = true;
            this.TTB.Click += new System.EventHandler(this.TTB_Click);
            // 
            // CRCB
            // 
            this.CRCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CRCB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CRCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CRCB.Depth = 0;
            this.CRCB.DrawShadows = false;
            this.CRCB.Enabled = false;
            this.CRCB.HighEmphasis = true;
            this.CRCB.Icon = global::Conforyon.UX.Properties.Resources.Lowercase;
            this.CRCB.Location = new System.Drawing.Point(259, 108);
            this.CRCB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CRCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CRCB.Name = "CRCB";
            this.CRCB.Size = new System.Drawing.Size(44, 36);
            this.CRCB.TabIndex = 5;
            this.CRCB.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.CRCB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CRCB.UseAccentColor = false;
            this.CRCB.UseVisualStyleBackColor = true;
            this.CRCB.Click += new System.EventHandler(this.FRCB_Click);
            // 
            // CRYPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.CRCB);
            this.Controls.Add(this.CYB);
            this.Controls.Add(this.HFBD);
            this.Controls.Add(this.HFTD);
            this.Controls.Add(this.HFN);
            this.Controls.Add(this.CSS);
            this.Controls.Add(this.CTB);
            this.Controls.Add(this.CRTB);
            this.Controls.Add(this.CVTB);
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.TBCB);
            this.Controls.Add(this.TACB);
            this.Name = "CRYPTO";
            this.Size = new System.Drawing.Size(306, 296);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox TACB;
        private ReaLTaiizor.Controls.MaterialComboBox TBCB;
        private ReaLTaiizor.Controls.MaterialButton TTB;
        private ReaLTaiizor.Controls.MaterialTextBox CVTB;
        private ReaLTaiizor.Controls.MaterialTextBox CRTB;
        private ReaLTaiizor.Controls.MaterialButton CTB;
        private ReaLTaiizor.Controls.MaterialSwitch CSS;
        private ReaLTaiizor.Controls.FoxNotification HFN;
        private ReaLTaiizor.Controls.MaterialDivider HFTD;
        private ReaLTaiizor.Controls.MaterialDivider HFBD;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialButton CRCB;
    }
}
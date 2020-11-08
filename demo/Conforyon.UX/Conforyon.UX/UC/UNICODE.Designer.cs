
namespace Conforyon.UX.UC
{
    partial class UNICODE
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
            this.UVTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.URTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CSS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.HFN = new ReaLTaiizor.Controls.FoxNotification();
            this.HFTD = new ReaLTaiizor.Controls.MaterialDivider();
            this.HFBD = new ReaLTaiizor.Controls.MaterialDivider();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.CTB = new ReaLTaiizor.Controls.MaterialButton();
            this.TTB = new ReaLTaiizor.Controls.MaterialButton();
            this.BTTB = new ReaLTaiizor.Controls.MaterialTextBox();
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
            "CHAR",
            "ASCII"});
            this.TACB.Location = new System.Drawing.Point(3, 4);
            this.TACB.MaxDropDownItems = 2;
            this.TACB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TACB.Name = "TACB";
            this.TACB.Size = new System.Drawing.Size(121, 35);
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
            this.TBCB.DropDownHeight = 60;
            this.TBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TBCB.DropDownWidth = 121;
            this.TBCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TBCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBCB.FormattingEnabled = true;
            this.TBCB.Hint = "Type B";
            this.TBCB.IntegralHeight = false;
            this.TBCB.ItemHeight = 29;
            this.TBCB.Items.AddRange(new object[] {
            "ASCII",
            "CHAR"});
            this.TBCB.Location = new System.Drawing.Point(182, 4);
            this.TBCB.MaxDropDownItems = 2;
            this.TBCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TBCB.Name = "TBCB";
            this.TBCB.Size = new System.Drawing.Size(121, 35);
            this.TBCB.TabIndex = 2;
            this.TBCB.UseTallSize = false;
            this.TBCB.SelectedIndexChanged += new System.EventHandler(this.TCB_SelectedIndexChanged);
            // 
            // UVTB
            // 
            this.UVTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UVTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UVTB.Depth = 0;
            this.UVTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UVTB.Hint = "Unicode Value";
            this.UVTB.Location = new System.Drawing.Point(3, 45);
            this.UVTB.MaxLength = 5000;
            this.UVTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.UVTB.Multiline = false;
            this.UVTB.Name = "UVTB";
            this.UVTB.Size = new System.Drawing.Size(300, 50);
            this.UVTB.TabIndex = 3;
            this.UVTB.Text = "Taiizor";
            // 
            // URTB
            // 
            this.URTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.URTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URTB.Depth = 0;
            this.URTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.URTB.Hint = "Unicode Result";
            this.URTB.Location = new System.Drawing.Point(71, 101);
            this.URTB.MaxLength = 5000;
            this.URTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.URTB.Multiline = false;
            this.URTB.Name = "URTB";
            this.URTB.ReadOnly = true;
            this.URTB.Size = new System.Drawing.Size(232, 50);
            this.URTB.TabIndex = 5;
            this.URTB.Text = "84,97,105,105,122,111,114";
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
            this.TTB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TTB.UseAccentColor = false;
            this.TTB.UseVisualStyleBackColor = true;
            this.TTB.Click += new System.EventHandler(this.TTB_Click);
            // 
            // BTTB
            // 
            this.BTTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BTTB.Depth = 0;
            this.BTTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTTB.Hint = "Split";
            this.BTTB.Location = new System.Drawing.Point(3, 101);
            this.BTTB.MaxLength = 1;
            this.BTTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.BTTB.Multiline = false;
            this.BTTB.Name = "BTTB";
            this.BTTB.Size = new System.Drawing.Size(62, 50);
            this.BTTB.TabIndex = 4;
            this.BTTB.Text = ",";
            this.BTTB.TextChanged += new System.EventHandler(this.BTTB_TextChanged);
            this.BTTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTTB_KeyPress);
            // 
            // UNICODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.BTTB);
            this.Controls.Add(this.CYB);
            this.Controls.Add(this.HFBD);
            this.Controls.Add(this.HFTD);
            this.Controls.Add(this.HFN);
            this.Controls.Add(this.CSS);
            this.Controls.Add(this.CTB);
            this.Controls.Add(this.URTB);
            this.Controls.Add(this.UVTB);
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.TBCB);
            this.Controls.Add(this.TACB);
            this.Name = "UNICODE";
            this.Size = new System.Drawing.Size(306, 296);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox TACB;
        private ReaLTaiizor.Controls.MaterialComboBox TBCB;
        private ReaLTaiizor.Controls.MaterialButton TTB;
        private ReaLTaiizor.Controls.MaterialTextBox UVTB;
        private ReaLTaiizor.Controls.MaterialButton CTB;
        private ReaLTaiizor.Controls.MaterialSwitch CSS;
        private ReaLTaiizor.Controls.FoxNotification HFN;
        private ReaLTaiizor.Controls.MaterialDivider HFTD;
        private ReaLTaiizor.Controls.MaterialDivider HFBD;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialTextBox BTTB;
        private ReaLTaiizor.Controls.MaterialTextBox URTB;
    }
}
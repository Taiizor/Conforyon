
namespace Conforyon.UX.UC
{
    partial class COLOR
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
            this.CRTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CGTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CBTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CHTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.TTB = new ReaLTaiizor.Controls.MaterialButton();
            this.CTB = new ReaLTaiizor.Controls.MaterialButton();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.CSS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.CFN = new ReaLTaiizor.Controls.FoxNotification();
            this.CFTD = new ReaLTaiizor.Controls.MaterialDivider();
            this.CFBD = new ReaLTaiizor.Controls.MaterialDivider();
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
            "RGB",
            "HEX"});
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
            "HEX",
            "RGB"});
            this.TBCB.Location = new System.Drawing.Point(182, 4);
            this.TBCB.MaxDropDownItems = 2;
            this.TBCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TBCB.Name = "TBCB";
            this.TBCB.Size = new System.Drawing.Size(121, 35);
            this.TBCB.StartIndex = 0;
            this.TBCB.TabIndex = 2;
            this.TBCB.UseTallSize = false;
            this.TBCB.SelectedIndexChanged += new System.EventHandler(this.TCB_SelectedIndexChanged);
            // 
            // CRTB
            // 
            this.CRTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CRTB.Depth = 0;
            this.CRTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CRTB.Hint = "R";
            this.CRTB.Location = new System.Drawing.Point(3, 48);
            this.CRTB.MaxLength = 3;
            this.CRTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CRTB.Multiline = false;
            this.CRTB.Name = "CRTB";
            this.CRTB.Size = new System.Drawing.Size(56, 50);
            this.CRTB.TabIndex = 3;
            this.CRTB.Text = "255";
            this.CRTB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.CRTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // CGTB
            // 
            this.CGTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CGTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CGTB.Depth = 0;
            this.CGTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CGTB.Hint = "G";
            this.CGTB.Location = new System.Drawing.Point(65, 48);
            this.CGTB.MaxLength = 3;
            this.CGTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CGTB.Multiline = false;
            this.CGTB.Name = "CGTB";
            this.CGTB.Size = new System.Drawing.Size(56, 50);
            this.CGTB.TabIndex = 4;
            this.CGTB.Text = "255";
            this.CGTB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.CGTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // CBTB
            // 
            this.CBTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CBTB.Depth = 0;
            this.CBTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBTB.Hint = "B";
            this.CBTB.Location = new System.Drawing.Point(127, 48);
            this.CBTB.MaxLength = 3;
            this.CBTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CBTB.Multiline = false;
            this.CBTB.Name = "CBTB";
            this.CBTB.Size = new System.Drawing.Size(56, 50);
            this.CBTB.TabIndex = 5;
            this.CBTB.Text = "255";
            this.CBTB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.CBTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // CHTB
            // 
            this.CHTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CHTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CHTB.Depth = 0;
            this.CHTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CHTB.Hint = "HEX";
            this.CHTB.Location = new System.Drawing.Point(217, 48);
            this.CHTB.MaxLength = 6;
            this.CHTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CHTB.Multiline = false;
            this.CHTB.Name = "CHTB";
            this.CHTB.Size = new System.Drawing.Size(86, 50);
            this.CHTB.TabIndex = 6;
            this.CHTB.Text = "FFFFFF";
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
            this.TTB.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.TTB.AutoSize = false;
            this.TTB.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            this.TTB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TTB.UseAccentColor = false;
            this.TTB.UseVisualStyleBackColor = true;
            this.TTB.Click += new System.EventHandler(this.TTB_Click);
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
            this.CTB.Location = new System.Drawing.Point(35, 107);
            this.CTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CTB.Name = "CTB";
            this.CTB.Size = new System.Drawing.Size(116, 36);
            this.CTB.TabIndex = 7;
            this.CTB.Text = "CONVERT";
            this.CTB.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.CTB.AutoSize = false;
            this.CTB.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            this.CTB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CTB.UseAccentColor = false;
            this.CTB.UseVisualStyleBackColor = true;
            this.CTB.Click += new System.EventHandler(this.CTB_Click);
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
            this.CYB.Location = new System.Drawing.Point(238, 107);
            this.CYB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CYB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CYB.Name = "CYB";
            this.CYB.Size = new System.Drawing.Size(44, 36);
            this.CYB.TabIndex = 8;
            this.CYB.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.CYB.AutoSize = false;
            this.CYB.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            this.CYB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CYB.UseAccentColor = false;
            this.CYB.UseVisualStyleBackColor = true;
            this.CYB.Click += new System.EventHandler(this.CYB_Click);
            // 
            // CSS
            // 
            this.CSS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CSS.AutoSize = true;
            this.CSS.Depth = 0;
            this.CSS.Location = new System.Drawing.Point(77, 149);
            this.CSS.Margin = new System.Windows.Forms.Padding(0);
            this.CSS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CSS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CSS.Name = "CSS";
            this.CSS.Ripple = true;
            this.CSS.Size = new System.Drawing.Size(152, 37);
            this.CSS.TabIndex = 9;
            this.CSS.Text = "Core Settings";
            this.CSS.UseAccentColor = true;
            this.CSS.UseVisualStyleBackColor = true;
            this.CSS.CheckedChanged += new System.EventHandler(this.CSS_CheckedChanged);
            // 
            // CFN
            // 
            this.CFN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CFN.BlueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.CFN.BlueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))));
            this.CFN.BlueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(184)))));
            this.CFN.Cursor = System.Windows.Forms.Cursors.Default;
            this.CFN.EnabledCalc = true;
            this.CFN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CFN.GreenBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(214)))));
            this.CFN.GreenBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(182)))));
            this.CFN.GreenTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.CFN.Location = new System.Drawing.Point(3, 197);
            this.CFN.Name = "CFN";
            this.CFN.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CFN.RedBarColor = System.Drawing.Color.Orange;
            this.CFN.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.CFN.Size = new System.Drawing.Size(300, 40);
            this.CFN.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.CFN.TabIndex = 11;
            this.CFN.Text = "The converter does not have a core formula!";
            this.CFN.YellowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.CFN.YellowBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.CFN.YellowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
            // 
            // CFTD
            // 
            this.CFTD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CFTD.BackColor = System.Drawing.Color.Orange;
            this.CFTD.Depth = 0;
            this.CFTD.Location = new System.Drawing.Point(3, 197);
            this.CFTD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CFTD.Name = "CFTD";
            this.CFTD.Size = new System.Drawing.Size(75, 1);
            this.CFTD.TabIndex = 10;
            this.CFTD.Text = "CFTD";
            // 
            // CFBD
            // 
            this.CFBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CFBD.BackColor = System.Drawing.Color.Orange;
            this.CFBD.Depth = 0;
            this.CFBD.Location = new System.Drawing.Point(3, 236);
            this.CFBD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CFBD.Name = "CFBD";
            this.CFBD.Size = new System.Drawing.Size(175, 1);
            this.CFBD.TabIndex = 12;
            this.CFBD.Text = "CFBD";
            // 
            // COLOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.CFBD);
            this.Controls.Add(this.CFTD);
            this.Controls.Add(this.CFN);
            this.Controls.Add(this.CSS);
            this.Controls.Add(this.CYB);
            this.Controls.Add(this.CTB);
            this.Controls.Add(this.CHTB);
            this.Controls.Add(this.CBTB);
            this.Controls.Add(this.CGTB);
            this.Controls.Add(this.CRTB);
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.TBCB);
            this.Controls.Add(this.TACB);
            this.Name = "COLOR";
            this.Size = new System.Drawing.Size(306, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox TACB;
        private ReaLTaiizor.Controls.MaterialComboBox TBCB;
        private ReaLTaiizor.Controls.MaterialButton TTB;
        private ReaLTaiizor.Controls.MaterialTextBox CRTB;
        private ReaLTaiizor.Controls.MaterialTextBox CGTB;
        private ReaLTaiizor.Controls.MaterialTextBox CBTB;
        private ReaLTaiizor.Controls.MaterialTextBox CHTB;
        private ReaLTaiizor.Controls.MaterialButton CTB;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialSwitch CSS;
        private ReaLTaiizor.Controls.FoxNotification CFN;
        private ReaLTaiizor.Controls.MaterialDivider CFTD;
        private ReaLTaiizor.Controls.MaterialDivider CFBD;
    }
}
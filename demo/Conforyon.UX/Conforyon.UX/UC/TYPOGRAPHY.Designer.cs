
namespace Conforyon.UX.UC
{
    partial class TYPOGRAPHY
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
            this.TVTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.TRTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CSS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.CFAN = new ReaLTaiizor.Controls.FoxNotification();
            this.HFTD = new ReaLTaiizor.Controls.MaterialDivider();
            this.HFBD = new ReaLTaiizor.Controls.MaterialDivider();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.CTB = new ReaLTaiizor.Controls.MaterialButton();
            this.TTB = new ReaLTaiizor.Controls.MaterialButton();
            this.BTTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.TDCB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.CFTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CFBN = new ReaLTaiizor.Controls.FoxNotification();
            this.HFMD = new ReaLTaiizor.Controls.MaterialDivider();
            this.TCCB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // TACB
            // 
            this.TACB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TACB.AutoResize = false;
            this.TACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TACB.Depth = 0;
            this.TACB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TACB.DropDownHeight = 89;
            this.TACB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TACB.DropDownWidth = 121;
            this.TACB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TACB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TACB.FormattingEnabled = true;
            this.TACB.Hint = "Type A";
            this.TACB.IntegralHeight = false;
            this.TACB.ItemHeight = 29;
            this.TACB.Items.AddRange(new object[] {
            "INCH",
            "CM",
            "PX"});
            this.TACB.Location = new System.Drawing.Point(3, 4);
            this.TACB.MaxDropDownItems = 3;
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
            this.TBCB.DropDownHeight = 89;
            this.TBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TBCB.DropDownWidth = 121;
            this.TBCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TBCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBCB.FormattingEnabled = true;
            this.TBCB.Hint = "Type B";
            this.TBCB.IntegralHeight = false;
            this.TBCB.ItemHeight = 29;
            this.TBCB.Items.AddRange(new object[] {
            "INCH",
            "CM",
            "PX"});
            this.TBCB.Location = new System.Drawing.Point(182, 4);
            this.TBCB.MaxDropDownItems = 3;
            this.TBCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TBCB.Name = "TBCB";
            this.TBCB.Size = new System.Drawing.Size(121, 35);
            this.TBCB.TabIndex = 2;
            this.TBCB.UseTallSize = false;
            this.TBCB.SelectedIndexChanged += new System.EventHandler(this.TCB_SelectedIndexChanged);
            // 
            // TVTB
            // 
            this.TVTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TVTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVTB.Depth = 0;
            this.TVTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TVTB.Hint = "Typography Value";
            this.TVTB.Location = new System.Drawing.Point(3, 45);
            this.TVTB.MaxLength = 15;
            this.TVTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TVTB.Multiline = false;
            this.TVTB.Name = "TVTB";
            this.TVTB.Size = new System.Drawing.Size(172, 50);
            this.TVTB.TabIndex = 3;
            this.TVTB.Text = "1";
            this.TVTB.TextChanged += new System.EventHandler(this.TVTB_TextChanged);
            this.TVTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVTB_KeyPress);
            // 
            // TRTB
            // 
            this.TRTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRTB.Depth = 0;
            this.TRTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TRTB.Hint = "Typography Result";
            this.TRTB.Location = new System.Drawing.Point(99, 101);
            this.TRTB.MaxLength = 200;
            this.TRTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TRTB.Multiline = false;
            this.TRTB.Name = "TRTB";
            this.TRTB.ReadOnly = true;
            this.TRTB.Size = new System.Drawing.Size(204, 50);
            this.TRTB.TabIndex = 6;
            this.TRTB.Text = "2,54";
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
            this.CSS.TabIndex = 10;
            this.CSS.Text = "Core Settings";
            this.CSS.UseAccentColor = true;
            this.CSS.UseVisualStyleBackColor = true;
            this.CSS.CheckedChanged += new System.EventHandler(this.CSS_CheckedChanged);
            // 
            // CFAN
            // 
            this.CFAN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CFAN.BlueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.CFAN.BlueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))));
            this.CFAN.BlueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(184)))));
            this.CFAN.Cursor = System.Windows.Forms.Cursors.Default;
            this.CFAN.EnabledCalc = true;
            this.CFAN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CFAN.GreenBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(214)))));
            this.CFAN.GreenBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(182)))));
            this.CFAN.GreenTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.CFAN.Location = new System.Drawing.Point(3, 253);
            this.CFAN.Name = "CFAN";
            this.CFAN.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CFAN.RedBarColor = System.Drawing.Color.Orange;
            this.CFAN.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.CFAN.Size = new System.Drawing.Size(300, 40);
            this.CFAN.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.CFAN.TabIndex = 12;
            this.CFAN.YellowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.CFAN.YellowBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.CFAN.YellowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
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
            this.HFTD.TabIndex = 11;
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
            this.HFBD.Size = new System.Drawing.Size(6, 1);
            this.HFBD.TabIndex = 14;
            this.HFBD.Text = "HFBD";
            // 
            // CYB
            // 
            this.CYB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CYB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CYB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
            this.CYB.TabIndex = 9;
            this.CYB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CYB.UseAccentColor = false;
            this.CYB.UseVisualStyleBackColor = false;
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
            this.CTB.Location = new System.Drawing.Point(95, 160);
            this.CTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CTB.Name = "CTB";
            this.CTB.Size = new System.Drawing.Size(116, 36);
            this.CTB.TabIndex = 8;
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
            this.BTTB.Location = new System.Drawing.Point(23, 160);
            this.BTTB.MaxLength = 2;
            this.BTTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.BTTB.Multiline = false;
            this.BTTB.Name = "BTTB";
            this.BTTB.Size = new System.Drawing.Size(50, 36);
            this.BTTB.TabIndex = 7;
            this.BTTB.Text = "2";
            this.BTTB.UseTallSize = false;
            this.BTTB.TextChanged += new System.EventHandler(this.BTTB_TextChanged);
            this.BTTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTTB_KeyPress);
            // 
            // TDCB
            // 
            this.TDCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TDCB.AutoResize = false;
            this.TDCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TDCB.Depth = 0;
            this.TDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TDCB.DropDownHeight = 88;
            this.TDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TDCB.DropDownWidth = 121;
            this.TDCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TDCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TDCB.FormattingEnabled = true;
            this.TDCB.Hint = "Decimal";
            this.TDCB.IntegralHeight = false;
            this.TDCB.ItemHeight = 43;
            this.TDCB.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.TDCB.Location = new System.Drawing.Point(213, 45);
            this.TDCB.MaxDropDownItems = 2;
            this.TDCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TDCB.Name = "TDCB";
            this.TDCB.Size = new System.Drawing.Size(90, 49);
            this.TDCB.TabIndex = 4;
            this.TDCB.Tag = "";
            this.TDCB.SelectedIndexChanged += new System.EventHandler(this.TDCB_SelectedIndexChanged);
            // 
            // CFTB
            // 
            this.CFTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CFTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CFTB.Depth = 0;
            this.CFTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CFTB.Hint = "Core Formula [INCH - CM]";
            this.CFTB.Location = new System.Drawing.Point(16, 268);
            this.CFTB.MaxLength = 25;
            this.CFTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CFTB.Multiline = false;
            this.CFTB.Name = "CFTB";
            this.CFTB.Size = new System.Drawing.Size(286, 50);
            this.CFTB.TabIndex = 13;
            this.CFTB.Text = "2,54";
            this.CFTB.TextChanged += new System.EventHandler(this.CFTB_TextChanged);
            // 
            // CFBN
            // 
            this.CFBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CFBN.BlueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.CFBN.BlueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))));
            this.CFBN.BlueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(184)))));
            this.CFBN.Cursor = System.Windows.Forms.Cursors.Default;
            this.CFBN.EnabledCalc = true;
            this.CFBN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CFBN.GreenBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(214)))));
            this.CFBN.GreenBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(182)))));
            this.CFBN.GreenTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.CFBN.Location = new System.Drawing.Point(3, 292);
            this.CFBN.Name = "CFBN";
            this.CFBN.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CFBN.RedBarColor = System.Drawing.Color.Orange;
            this.CFBN.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.CFBN.Size = new System.Drawing.Size(300, 40);
            this.CFBN.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.CFBN.TabIndex = 15;
            this.CFBN.YellowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.CFBN.YellowBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.CFBN.YellowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
            // 
            // HFMD
            // 
            this.HFMD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HFMD.BackColor = System.Drawing.Color.Orange;
            this.HFMD.Depth = 0;
            this.HFMD.Location = new System.Drawing.Point(3, 330);
            this.HFMD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.HFMD.Name = "HFMD";
            this.HFMD.Size = new System.Drawing.Size(175, 1);
            this.HFMD.TabIndex = 16;
            this.HFMD.Text = "HFMD";
            // 
            // TCCB
            // 
            this.TCCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TCCB.AutoResize = false;
            this.TCCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TCCB.Depth = 0;
            this.TCCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TCCB.DropDownHeight = 88;
            this.TCCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCCB.DropDownWidth = 121;
            this.TCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TCCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TCCB.FormattingEnabled = true;
            this.TCCB.Hint = "Comma";
            this.TCCB.IntegralHeight = false;
            this.TCCB.ItemHeight = 43;
            this.TCCB.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.TCCB.Location = new System.Drawing.Point(3, 101);
            this.TCCB.MaxDropDownItems = 2;
            this.TCCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TCCB.Name = "TCCB";
            this.TCCB.Size = new System.Drawing.Size(90, 49);
            this.TCCB.TabIndex = 5;
            this.TCCB.Tag = "";
            this.TCCB.SelectedIndexChanged += new System.EventHandler(this.TCCB_SelectedIndexChanged);
            // 
            // TYPOGRAPHY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.TCCB);
            this.Controls.Add(this.HFMD);
            this.Controls.Add(this.HFBD);
            this.Controls.Add(this.CFTB);
            this.Controls.Add(this.CFBN);
            this.Controls.Add(this.TDCB);
            this.Controls.Add(this.BTTB);
            this.Controls.Add(this.CYB);
            this.Controls.Add(this.HFTD);
            this.Controls.Add(this.CFAN);
            this.Controls.Add(this.CSS);
            this.Controls.Add(this.CTB);
            this.Controls.Add(this.TRTB);
            this.Controls.Add(this.TVTB);
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.TBCB);
            this.Controls.Add(this.TACB);
            this.Name = "TYPOGRAPHY";
            this.Size = new System.Drawing.Size(306, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox TACB;
        private ReaLTaiizor.Controls.MaterialComboBox TBCB;
        private ReaLTaiizor.Controls.MaterialButton TTB;
        private ReaLTaiizor.Controls.MaterialTextBox TVTB;
        private ReaLTaiizor.Controls.MaterialButton CTB;
        private ReaLTaiizor.Controls.MaterialSwitch CSS;
        private ReaLTaiizor.Controls.FoxNotification CFAN;
        private ReaLTaiizor.Controls.MaterialDivider HFTD;
        private ReaLTaiizor.Controls.MaterialDivider HFBD;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialTextBox BTTB;
        private ReaLTaiizor.Controls.MaterialTextBox TRTB;
        private ReaLTaiizor.Controls.MaterialComboBox TDCB;
        private ReaLTaiizor.Controls.MaterialTextBox CFTB;
        private ReaLTaiizor.Controls.FoxNotification CFBN;
        private ReaLTaiizor.Controls.MaterialDivider HFMD;
        private ReaLTaiizor.Controls.MaterialComboBox TCCB;
    }
}
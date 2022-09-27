
namespace Conforyon.UX.UC
{
    partial class CLIPBOARD
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
            this.CVTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CRTB = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CSS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.HFN = new ReaLTaiizor.Controls.FoxNotification();
            this.HFTD = new ReaLTaiizor.Controls.MaterialDivider();
            this.HFBD = new ReaLTaiizor.Controls.MaterialDivider();
            this.PEB = new ReaLTaiizor.Controls.MaterialButton();
            this.CYB = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CVTB
            // 
            this.CVTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CVTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CVTB.Depth = 0;
            this.CVTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CVTB.Hint = "Clipboard Value";
            this.CVTB.Location = new System.Drawing.Point(3, 3);
            this.CVTB.MaxLength = 5000;
            this.CVTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CVTB.Multiline = false;
            this.CVTB.Name = "CVTB";
            this.CVTB.Size = new System.Drawing.Size(249, 50);
            this.CVTB.TabIndex = 0;
            this.CVTB.Text = "Where is my kingdom?";
            // 
            // CRTB
            // 
            this.CRTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CRTB.Depth = 0;
            this.CRTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CRTB.Hint = "Clipboard Result";
            this.CRTB.Location = new System.Drawing.Point(3, 59);
            this.CRTB.MaxLength = 5000;
            this.CRTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CRTB.Multiline = false;
            this.CRTB.Name = "CRTB";
            this.CRTB.ReadOnly = true;
            this.CRTB.Size = new System.Drawing.Size(249, 50);
            this.CRTB.TabIndex = 2;
            this.CRTB.Text = "It\'s all over the kingdom.";
            // 
            // CSS
            // 
            this.CSS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CSS.AutoSize = true;
            this.CSS.Depth = 0;
            this.CSS.Location = new System.Drawing.Point(77, 112);
            this.CSS.Margin = new System.Windows.Forms.Padding(0);
            this.CSS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CSS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CSS.Name = "CSS";
            this.CSS.Ripple = true;
            this.CSS.Size = new System.Drawing.Size(152, 37);
            this.CSS.TabIndex = 4;
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
            this.HFN.Location = new System.Drawing.Point(3, 160);
            this.HFN.Name = "HFN";
            this.HFN.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HFN.RedBarColor = System.Drawing.Color.Orange;
            this.HFN.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.HFN.Size = new System.Drawing.Size(300, 40);
            this.HFN.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.HFN.TabIndex = 6;
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
            this.HFTD.Location = new System.Drawing.Point(3, 160);
            this.HFTD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.HFTD.Name = "HFTD";
            this.HFTD.Size = new System.Drawing.Size(75, 1);
            this.HFTD.TabIndex = 5;
            this.HFTD.Text = "HFTD";
            // 
            // HFBD
            // 
            this.HFBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HFBD.BackColor = System.Drawing.Color.Orange;
            this.HFBD.Depth = 0;
            this.HFBD.Location = new System.Drawing.Point(3, 199);
            this.HFBD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.HFBD.Name = "HFBD";
            this.HFBD.Size = new System.Drawing.Size(175, 1);
            this.HFBD.TabIndex = 7;
            this.HFBD.Text = "HFBD";
            // 
            // PEB
            // 
            this.PEB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PEB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PEB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PEB.Depth = 0;
            this.PEB.DrawShadows = false;
            this.PEB.HighEmphasis = true;
            this.PEB.Icon = global::Conforyon.UX.Properties.Resources.Paste;
            this.PEB.Location = new System.Drawing.Point(259, 66);
            this.PEB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PEB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.PEB.Name = "PEB";
            this.PEB.Size = new System.Drawing.Size(44, 36);
            this.PEB.TabIndex = 3;
            this.PEB.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.PEB.AutoSize = false;
            this.PEB.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            this.PEB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PEB.UseAccentColor = false;
            this.PEB.UseVisualStyleBackColor = true;
            this.PEB.Click += new System.EventHandler(this.PEB_Click);
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
            this.CYB.Location = new System.Drawing.Point(259, 10);
            this.CYB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CYB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CYB.Name = "CYB";
            this.CYB.Size = new System.Drawing.Size(44, 36);
            this.CYB.TabIndex = 1;
            this.CYB.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.CYB.AutoSize = false;
            this.CYB.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            this.CYB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CYB.UseAccentColor = false;
            this.CYB.UseVisualStyleBackColor = true;
            this.CYB.Click += new System.EventHandler(this.CYB_Click);
            // 
            // CLIPBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.PEB);
            this.Controls.Add(this.CYB);
            this.Controls.Add(this.HFBD);
            this.Controls.Add(this.HFTD);
            this.Controls.Add(this.HFN);
            this.Controls.Add(this.CSS);
            this.Controls.Add(this.CRTB);
            this.Controls.Add(this.CVTB);
            this.Name = "CLIPBOARD";
            this.Size = new System.Drawing.Size(306, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBox CVTB;
        private ReaLTaiizor.Controls.MaterialTextBox CRTB;
        private ReaLTaiizor.Controls.MaterialSwitch CSS;
        private ReaLTaiizor.Controls.FoxNotification HFN;
        private ReaLTaiizor.Controls.MaterialDivider HFTD;
        private ReaLTaiizor.Controls.MaterialDivider HFBD;
        private ReaLTaiizor.Controls.MaterialButton CYB;
        private ReaLTaiizor.Controls.MaterialButton PEB;
    }
}
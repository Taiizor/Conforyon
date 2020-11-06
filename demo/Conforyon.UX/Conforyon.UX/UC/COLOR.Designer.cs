
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
            this.TTB = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TACB
            // 
            this.TACB.AutoResize = false;
            this.TACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TACB.Depth = 0;
            this.TACB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TACB.DropDownHeight = 118;
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
            this.TACB.MaxDropDownItems = 4;
            this.TACB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TACB.Name = "TACB";
            this.TACB.Size = new System.Drawing.Size(121, 35);
            this.TACB.TabIndex = 0;
            this.TACB.UseTallSize = false;
            // 
            // TBCB
            // 
            this.TBCB.AutoResize = false;
            this.TBCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBCB.Depth = 0;
            this.TBCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TBCB.DropDownHeight = 118;
            this.TBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TBCB.DropDownWidth = 121;
            this.TBCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TBCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBCB.FormattingEnabled = true;
            this.TBCB.Hint = "Type B";
            this.TBCB.IntegralHeight = false;
            this.TBCB.ItemHeight = 29;
            this.TBCB.Items.AddRange(new object[] {
            "RGB",
            "HEX"});
            this.TBCB.Location = new System.Drawing.Point(182, 4);
            this.TBCB.MaxDropDownItems = 4;
            this.TBCB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TBCB.Name = "TBCB";
            this.TBCB.Size = new System.Drawing.Size(121, 35);
            this.TBCB.TabIndex = 1;
            this.TBCB.UseTallSize = false;
            // 
            // TTB
            // 
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
            this.TTB.TabIndex = 2;
            this.TTB.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TTB.UseAccentColor = false;
            this.TTB.UseVisualStyleBackColor = true;
            // 
            // COLOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.TBCB);
            this.Controls.Add(this.TACB);
            this.Name = "COLOR";
            this.Size = new System.Drawing.Size(306, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox TACB;
        private ReaLTaiizor.Controls.MaterialComboBox TBCB;
        private ReaLTaiizor.Controls.MaterialButton TTB;
    }
}

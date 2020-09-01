namespace Conforyon.UX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BG = new ReaLTaiizor.Controls.Panel();
            this.BODY = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.VIEW = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.BAR = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.Units = new System.Windows.Forms.TabPage();
            this.Others = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            this.BG.SuspendLayout();
            this.BODY.SuspendLayout();
            this.BAR.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.Transparent;
            this.BG.BackgroundImage = global::Conforyon.UX.Properties.Resources.Background;
            this.BG.Controls.Add(this.BODY);
            this.BG.Controls.Add(this.BAR);
            this.BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG.EdgeColor = System.Drawing.Color.Transparent;
            this.BG.Location = new System.Drawing.Point(2, 36);
            this.BG.Name = "BG";
            this.BG.Padding = new System.Windows.Forms.Padding(5);
            this.BG.Size = new System.Drawing.Size(796, 462);
            this.BG.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BG.TabIndex = 0;
            this.BG.Text = "BG";
            // 
            // BODY
            // 
            this.BODY.ArrowColorF = System.Drawing.Color.Transparent;
            this.BODY.ArrowColorH = System.Drawing.Color.Transparent;
            this.BODY.BackColor = System.Drawing.Color.Transparent;
            this.BODY.BaseColor = System.Drawing.Color.Transparent;
            this.BODY.Controls.Add(this.VIEW);
            this.BODY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BODY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BODY.Location = new System.Drawing.Point(230, 5);
            this.BODY.Name = "BODY";
            this.BODY.ShowArror = false;
            this.BODY.ShowText = false;
            this.BODY.Size = new System.Drawing.Size(561, 452);
            this.BODY.TabIndex = 4;
            this.BODY.Text = "BODY";
            this.BODY.TextColor = System.Drawing.Color.Transparent;
            // 
            // VIEW
            // 
            this.VIEW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VIEW.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.VIEW.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.VIEW.BackColor = System.Drawing.Color.Transparent;
            this.VIEW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.VIEW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VIEW.Location = new System.Drawing.Point(215, 162);
            this.VIEW.Name = "VIEW";
            this.VIEW.ShowArror = false;
            this.VIEW.ShowText = false;
            this.VIEW.Size = new System.Drawing.Size(128, 128);
            this.VIEW.TabIndex = 5;
            this.VIEW.Text = "VIEW";
            this.VIEW.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            // 
            // BAR
            // 
            this.BAR.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.BAR.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.BAR.BackColor = System.Drawing.Color.Transparent;
            this.BAR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BAR.Controls.Add(this.materialTabControl1);
            this.BAR.Controls.Add(this.materialTabSelector1);
            this.BAR.Controls.Add(this.hopeButton1);
            this.BAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.BAR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BAR.Location = new System.Drawing.Point(5, 5);
            this.BAR.Name = "BAR";
            this.BAR.Padding = new System.Windows.Forms.Padding(15);
            this.BAR.ShowArror = false;
            this.BAR.ShowText = false;
            this.BAR.Size = new System.Drawing.Size(225, 452);
            this.BAR.TabIndex = 3;
            this.BAR.Text = "BAR";
            this.BAR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.materialTabControl1.Controls.Add(this.Units);
            this.materialTabControl1.Controls.Add(this.Others);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(18, 80);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(189, 229);
            this.materialTabControl1.TabIndex = 8;
            // 
            // Units
            // 
            this.Units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Units.Location = new System.Drawing.Point(4, 4);
            this.Units.Name = "Units";
            this.Units.Padding = new System.Windows.Forms.Padding(3);
            this.Units.Size = new System.Drawing.Size(181, 199);
            this.Units.TabIndex = 0;
            this.Units.Text = "Units";
            // 
            // Others
            // 
            this.Others.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Others.Location = new System.Drawing.Point(4, 4);
            this.Others.Name = "Others";
            this.Others.Padding = new System.Windows.Forms.Padding(3);
            this.Others.Size = new System.Drawing.Size(181, 199);
            this.Others.TabIndex = 1;
            this.Others.Text = "Others";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            this.materialTabSelector1.Location = new System.Drawing.Point(18, 18);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.materialTabSelector1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(189, 62);
            this.materialTabSelector1.TabIndex = 7;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.TitleTextState = ReaLTaiizor.Controls.MaterialTabSelector.TextState.Normal;
            // 
            // hopeButton1
            // 
            this.hopeButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButton1.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.hopeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButton1.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.hopeButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButton1.Location = new System.Drawing.Point(18, 394);
            this.hopeButton1.Name = "hopeButton1";
            this.hopeButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hopeButton1.Size = new System.Drawing.Size(189, 40);
            this.hopeButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButton1.TabIndex = 6;
            this.hopeButton1.Text = "Pratik Demolar";
            this.hopeButton1.TextColor = System.Drawing.Color.White;
            this.hopeButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BG);
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Image = global::Conforyon.UX.Properties.Resources.INPUT;
            this.MinimumSize = new System.Drawing.Size(230, 230);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conforyon UX";
            this.BG.ResumeLayout(false);
            this.BODY.ResumeLayout(false);
            this.BAR.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel BG;
        private ReaLTaiizor.Controls.ForeverGroupBox BAR;
        private ReaLTaiizor.Controls.ForeverGroupBox BODY;
        private ReaLTaiizor.Controls.ForeverGroupBox VIEW;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Units;
        private System.Windows.Forms.TabPage Others;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
    }
}
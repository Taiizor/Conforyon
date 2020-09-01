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
            this.Time = new ReaLTaiizor.Controls.HopeButton();
            this.Speed = new ReaLTaiizor.Controls.HopeButton();
            this.Typography = new ReaLTaiizor.Controls.HopeButton();
            this.Temperature = new ReaLTaiizor.Controls.HopeButton();
            this.DataStorage = new ReaLTaiizor.Controls.HopeButton();
            this.Color = new ReaLTaiizor.Controls.HopeButton();
            this.Others = new System.Windows.Forms.TabPage();
            this.Unicode = new ReaLTaiizor.Controls.HopeButton();
            this.Hash = new ReaLTaiizor.Controls.HopeButton();
            this.Crypto = new ReaLTaiizor.Controls.HopeButton();
            this.Clipboard = new ReaLTaiizor.Controls.HopeButton();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.BG.SuspendLayout();
            this.BODY.SuspendLayout();
            this.VIEW.SuspendLayout();
            this.BAR.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.Units.SuspendLayout();
            this.Others.SuspendLayout();
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
            this.VIEW.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.VIEW.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.VIEW.BackColor = System.Drawing.Color.Transparent;
            this.VIEW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.VIEW.Controls.Add(this.labelEdit1);
            this.VIEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VIEW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VIEW.Location = new System.Drawing.Point(0, 0);
            this.VIEW.Name = "VIEW";
            this.VIEW.ShowArror = false;
            this.VIEW.ShowText = false;
            this.VIEW.Size = new System.Drawing.Size(561, 452);
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
            this.materialTabControl1.Size = new System.Drawing.Size(189, 354);
            this.materialTabControl1.TabIndex = 8;
            // 
            // Units
            // 
            this.Units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Units.Controls.Add(this.Time);
            this.Units.Controls.Add(this.Speed);
            this.Units.Controls.Add(this.Typography);
            this.Units.Controls.Add(this.Temperature);
            this.Units.Controls.Add(this.DataStorage);
            this.Units.Controls.Add(this.Color);
            this.Units.Location = new System.Drawing.Point(4, 4);
            this.Units.Name = "Units";
            this.Units.Padding = new System.Windows.Forms.Padding(3);
            this.Units.Size = new System.Drawing.Size(181, 324);
            this.Units.TabIndex = 0;
            this.Units.Text = "Units";
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Time.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Time.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Time.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Time.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Time.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Time.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Time.Location = new System.Drawing.Point(6, 236);
            this.Time.Name = "Time";
            this.Time.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Time.Size = new System.Drawing.Size(169, 40);
            this.Time.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Time.TabIndex = 11;
            this.Time.Text = "Time";
            this.Time.TextColor = System.Drawing.Color.White;
            this.Time.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Time.Click += new System.EventHandler(this.Click);
            // 
            // Speed
            // 
            this.Speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Speed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Speed.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Speed.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Speed.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Speed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Speed.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Speed.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Speed.Location = new System.Drawing.Point(6, 190);
            this.Speed.Name = "Speed";
            this.Speed.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Speed.Size = new System.Drawing.Size(169, 40);
            this.Speed.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Speed.TabIndex = 10;
            this.Speed.Text = "Speed";
            this.Speed.TextColor = System.Drawing.Color.White;
            this.Speed.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Speed.Click += new System.EventHandler(this.Click);
            // 
            // Typography
            // 
            this.Typography.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Typography.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Typography.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Typography.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Typography.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Typography.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Typography.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Typography.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Typography.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Typography.Location = new System.Drawing.Point(6, 144);
            this.Typography.Name = "Typography";
            this.Typography.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Typography.Size = new System.Drawing.Size(169, 40);
            this.Typography.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Typography.TabIndex = 9;
            this.Typography.Text = "Typography";
            this.Typography.TextColor = System.Drawing.Color.White;
            this.Typography.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Typography.Click += new System.EventHandler(this.Click);
            // 
            // Temperature
            // 
            this.Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temperature.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Temperature.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Temperature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temperature.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Temperature.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Temperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Temperature.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Temperature.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Temperature.Location = new System.Drawing.Point(6, 98);
            this.Temperature.Name = "Temperature";
            this.Temperature.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Temperature.Size = new System.Drawing.Size(169, 40);
            this.Temperature.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Temperature.TabIndex = 8;
            this.Temperature.Text = "Temperature";
            this.Temperature.TextColor = System.Drawing.Color.White;
            this.Temperature.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Temperature.Click += new System.EventHandler(this.Click);
            // 
            // DataStorage
            // 
            this.DataStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataStorage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.DataStorage.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.DataStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataStorage.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.DataStorage.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataStorage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataStorage.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.DataStorage.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.DataStorage.Location = new System.Drawing.Point(6, 52);
            this.DataStorage.Name = "DataStorage";
            this.DataStorage.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DataStorage.Size = new System.Drawing.Size(169, 40);
            this.DataStorage.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.DataStorage.TabIndex = 7;
            this.DataStorage.Text = "Data Storage";
            this.DataStorage.TextColor = System.Drawing.Color.White;
            this.DataStorage.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.DataStorage.Click += new System.EventHandler(this.Click);
            // 
            // Color
            // 
            this.Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Color.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Color.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Color.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Color.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Color.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Color.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Color.Location = new System.Drawing.Point(6, 6);
            this.Color.Name = "Color";
            this.Color.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Color.Size = new System.Drawing.Size(169, 40);
            this.Color.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Color.TabIndex = 6;
            this.Color.Text = "Color";
            this.Color.TextColor = System.Drawing.Color.White;
            this.Color.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Color.Click += new System.EventHandler(this.Click);
            // 
            // Others
            // 
            this.Others.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Others.Controls.Add(this.Unicode);
            this.Others.Controls.Add(this.Hash);
            this.Others.Controls.Add(this.Crypto);
            this.Others.Controls.Add(this.Clipboard);
            this.Others.Location = new System.Drawing.Point(4, 4);
            this.Others.Name = "Others";
            this.Others.Padding = new System.Windows.Forms.Padding(3);
            this.Others.Size = new System.Drawing.Size(181, 324);
            this.Others.TabIndex = 1;
            this.Others.Text = "Others";
            // 
            // Unicode
            // 
            this.Unicode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unicode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Unicode.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Unicode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unicode.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Unicode.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Unicode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Unicode.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Unicode.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Unicode.Location = new System.Drawing.Point(6, 144);
            this.Unicode.Name = "Unicode";
            this.Unicode.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Unicode.Size = new System.Drawing.Size(169, 40);
            this.Unicode.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Unicode.TabIndex = 10;
            this.Unicode.Text = "Unicode";
            this.Unicode.TextColor = System.Drawing.Color.White;
            this.Unicode.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Unicode.Click += new System.EventHandler(this.Click);
            // 
            // Hash
            // 
            this.Hash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Hash.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Hash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hash.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Hash.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Hash.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Hash.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Hash.Location = new System.Drawing.Point(6, 98);
            this.Hash.Name = "Hash";
            this.Hash.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Hash.Size = new System.Drawing.Size(169, 40);
            this.Hash.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Hash.TabIndex = 9;
            this.Hash.Text = "Hash";
            this.Hash.TextColor = System.Drawing.Color.White;
            this.Hash.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Hash.Click += new System.EventHandler(this.Click);
            // 
            // Crypto
            // 
            this.Crypto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Crypto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Crypto.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Crypto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crypto.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Crypto.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Crypto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Crypto.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Crypto.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Crypto.Location = new System.Drawing.Point(6, 52);
            this.Crypto.Name = "Crypto";
            this.Crypto.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Crypto.Size = new System.Drawing.Size(169, 40);
            this.Crypto.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Crypto.TabIndex = 8;
            this.Crypto.Text = "Crypto";
            this.Crypto.TextColor = System.Drawing.Color.White;
            this.Crypto.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Crypto.Click += new System.EventHandler(this.Click);
            // 
            // Clipboard
            // 
            this.Clipboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clipboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Clipboard.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.Clipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clipboard.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Clipboard.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Clipboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Clipboard.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.Clipboard.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Clipboard.Location = new System.Drawing.Point(6, 6);
            this.Clipboard.Name = "Clipboard";
            this.Clipboard.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Clipboard.Size = new System.Drawing.Size(169, 40);
            this.Clipboard.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Clipboard.TabIndex = 7;
            this.Clipboard.Text = "Clipboard";
            this.Clipboard.TextColor = System.Drawing.Color.White;
            this.Clipboard.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Clipboard.Click += new System.EventHandler(this.Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // labelEdit1
            // 
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 101F, System.Drawing.FontStyle.Bold);
            this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit1.Location = new System.Drawing.Point(0, 0);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(561, 452);
            this.labelEdit1.TabIndex = 0;
            this.labelEdit1.Text = "Coming\r\nSoon!";
            this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.VIEW.ResumeLayout(false);
            this.BAR.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.Units.ResumeLayout(false);
            this.Others.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel BG;
        private ReaLTaiizor.Controls.ForeverGroupBox BAR;
        private ReaLTaiizor.Controls.ForeverGroupBox BODY;
        private ReaLTaiizor.Controls.ForeverGroupBox VIEW;
        private ReaLTaiizor.Controls.HopeButton Color;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Units;
        private System.Windows.Forms.TabPage Others;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private ReaLTaiizor.Controls.HopeButton Clipboard;
        private ReaLTaiizor.Controls.HopeButton Crypto;
        private ReaLTaiizor.Controls.HopeButton Hash;
        private ReaLTaiizor.Controls.HopeButton Unicode;
        private ReaLTaiizor.Controls.HopeButton Time;
        private ReaLTaiizor.Controls.HopeButton Speed;
        private ReaLTaiizor.Controls.HopeButton Typography;
        private ReaLTaiizor.Controls.HopeButton Temperature;
        private ReaLTaiizor.Controls.HopeButton DataStorage;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
    }
}
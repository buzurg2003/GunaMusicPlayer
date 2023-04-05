namespace Guna_Music_Player
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.NowPlayingTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.NowPlayingTabPage = new System.Windows.Forms.TabPage();
            this.NowPlayingListBox = new System.Windows.Forms.ListBox();
            this.FavouritesTabPage = new System.Windows.Forms.TabPage();
            this.FavouritesListBox = new System.Windows.Forms.ListBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.FontButton = new Guna.UI2.WinForms.Guna2Button();
            this.DefaultSettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearDataButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.AppLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.ThemeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AppearanceLabel = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.picArt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RepeatLabel = new System.Windows.Forms.Label();
            this.RepeatMusicToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.PreviousButton = new Guna.UI2.WinForms.Guna2Button();
            this.NextButton = new Guna.UI2.WinForms.Guna2Button();
            this.PlayButton = new Guna.UI2.WinForms.Guna2Button();
            this.nowPlayingTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.ImportButton = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.TabControl.SuspendLayout();
            this.NowPlayingTabPage.SuspendLayout();
            this.FavouritesTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Silver;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CloseButton.BorderRadius = 5;
            this.CloseButton.BorderThickness = 3;
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(753, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(36, 36);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NowPlayingTextBox
            // 
            this.NowPlayingTextBox.Animated = true;
            this.NowPlayingTextBox.BorderRadius = 5;
            this.NowPlayingTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NowPlayingTextBox.DefaultText = "";
            this.NowPlayingTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NowPlayingTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NowPlayingTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NowPlayingTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NowPlayingTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NowPlayingTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NowPlayingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NowPlayingTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NowPlayingTextBox.Location = new System.Drawing.Point(184, 12);
            this.NowPlayingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NowPlayingTextBox.Name = "NowPlayingTextBox";
            this.NowPlayingTextBox.PasswordChar = '\0';
            this.NowPlayingTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NowPlayingTextBox.PlaceholderText = "Now Playing";
            this.NowPlayingTextBox.ReadOnly = true;
            this.NowPlayingTextBox.SelectedText = "";
            this.NowPlayingTextBox.Size = new System.Drawing.Size(419, 36);
            this.NowPlayingTextBox.TabIndex = 3;
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl.Controls.Add(this.NowPlayingTabPage);
            this.TabControl.Controls.Add(this.FavouritesTabPage);
            this.TabControl.Controls.Add(this.SettingsTabPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.TabControl.Location = new System.Drawing.Point(9, 55);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(779, 434);
            this.TabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabControl.TabIndex = 30;
            this.TabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // NowPlayingTabPage
            // 
            this.NowPlayingTabPage.BackColor = System.Drawing.Color.White;
            this.NowPlayingTabPage.Controls.Add(this.NowPlayingListBox);
            this.NowPlayingTabPage.Location = new System.Drawing.Point(184, 4);
            this.NowPlayingTabPage.Name = "NowPlayingTabPage";
            this.NowPlayingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NowPlayingTabPage.Size = new System.Drawing.Size(591, 426);
            this.NowPlayingTabPage.TabIndex = 0;
            this.NowPlayingTabPage.Text = "Now Playing";
            // 
            // NowPlayingListBox
            // 
            this.NowPlayingListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NowPlayingListBox.FormattingEnabled = true;
            this.NowPlayingListBox.ItemHeight = 29;
            this.NowPlayingListBox.Location = new System.Drawing.Point(0, 0);
            this.NowPlayingListBox.Name = "NowPlayingListBox";
            this.NowPlayingListBox.Size = new System.Drawing.Size(595, 435);
            this.NowPlayingListBox.TabIndex = 0;
            this.NowPlayingListBox.SelectedIndexChanged += new System.EventHandler(this.NowPlayingListBox_SelectedIndexChanged);
            this.NowPlayingListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NowPlayingListBox_MouseUp);
            // 
            // FavouritesTabPage
            // 
            this.FavouritesTabPage.BackColor = System.Drawing.Color.White;
            this.FavouritesTabPage.Controls.Add(this.FavouritesListBox);
            this.FavouritesTabPage.Location = new System.Drawing.Point(184, 4);
            this.FavouritesTabPage.Name = "FavouritesTabPage";
            this.FavouritesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FavouritesTabPage.Size = new System.Drawing.Size(591, 426);
            this.FavouritesTabPage.TabIndex = 1;
            this.FavouritesTabPage.Text = "Favourites";
            // 
            // FavouritesListBox
            // 
            this.FavouritesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FavouritesListBox.FormattingEnabled = true;
            this.FavouritesListBox.ItemHeight = 29;
            this.FavouritesListBox.Location = new System.Drawing.Point(0, 0);
            this.FavouritesListBox.Name = "FavouritesListBox";
            this.FavouritesListBox.Size = new System.Drawing.Size(591, 435);
            this.FavouritesListBox.TabIndex = 0;
            this.FavouritesListBox.SelectedIndexChanged += new System.EventHandler(this.FavouritesListBox_SelectedIndexChanged);
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.White;
            this.SettingsTabPage.Controls.Add(this.FontButton);
            this.SettingsTabPage.Controls.Add(this.DefaultSettingsButton);
            this.SettingsTabPage.Controls.Add(this.ClearDataButton);
            this.SettingsTabPage.Controls.Add(this.guna2Separator4);
            this.SettingsTabPage.Controls.Add(this.AppLabel);
            this.SettingsTabPage.Controls.Add(this.LanguageComboBox);
            this.SettingsTabPage.Controls.Add(this.guna2Separator3);
            this.SettingsTabPage.Controls.Add(this.LanguageLabel);
            this.SettingsTabPage.Controls.Add(this.ThemeLabel);
            this.SettingsTabPage.Controls.Add(this.guna2Separator2);
            this.SettingsTabPage.Controls.Add(this.ThemeComboBox);
            this.SettingsTabPage.Controls.Add(this.AppearanceLabel);
            this.SettingsTabPage.Controls.Add(this.guna2Separator1);
            this.SettingsTabPage.Controls.Add(this.SettingsLabel);
            this.SettingsTabPage.Location = new System.Drawing.Point(184, 4);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(591, 426);
            this.SettingsTabPage.TabIndex = 3;
            this.SettingsTabPage.Text = "Settings";
            // 
            // FontButton
            // 
            this.FontButton.Animated = true;
            this.FontButton.BorderRadius = 5;
            this.FontButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FontButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FontButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FontButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FontButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.FontButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontButton.ForeColor = System.Drawing.Color.White;
            this.FontButton.Location = new System.Drawing.Point(9, 158);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(112, 36);
            this.FontButton.TabIndex = 75;
            this.FontButton.Text = "Set Font";
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // DefaultSettingsButton
            // 
            this.DefaultSettingsButton.Animated = true;
            this.DefaultSettingsButton.BorderRadius = 5;
            this.DefaultSettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DefaultSettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DefaultSettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DefaultSettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DefaultSettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DefaultSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefaultSettingsButton.ForeColor = System.Drawing.Color.White;
            this.DefaultSettingsButton.Location = new System.Drawing.Point(9, 343);
            this.DefaultSettingsButton.Name = "DefaultSettingsButton";
            this.DefaultSettingsButton.Size = new System.Drawing.Size(127, 36);
            this.DefaultSettingsButton.TabIndex = 74;
            this.DefaultSettingsButton.Text = "Default Settings";
            this.DefaultSettingsButton.Click += new System.EventHandler(this.DefaultSettingsButton_Click);
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.Animated = true;
            this.ClearDataButton.BorderRadius = 5;
            this.ClearDataButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearDataButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearDataButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearDataButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearDataButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClearDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDataButton.ForeColor = System.Drawing.Color.White;
            this.ClearDataButton.Location = new System.Drawing.Point(142, 343);
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.Size = new System.Drawing.Size(99, 36);
            this.ClearDataButton.TabIndex = 73;
            this.ClearDataButton.Text = "Clear Data";
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Location = new System.Drawing.Point(89, 311);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(489, 10);
            this.guna2Separator4.TabIndex = 72;
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AppLabel.Location = new System.Drawing.Point(3, 300);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(62, 31);
            this.AppLabel.TabIndex = 71;
            this.AppLabel.Text = "App";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.Transparent;
            this.LanguageComboBox.BorderRadius = 5;
            this.LanguageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LanguageComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LanguageComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.LanguageComboBox.ItemHeight = 30;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "English",
            "Russian"});
            this.LanguageComboBox.Location = new System.Drawing.Point(9, 249);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(140, 36);
            this.LanguageComboBox.TabIndex = 63;
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(137, 217);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(445, 10);
            this.guna2Separator3.TabIndex = 60;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.LanguageLabel.Location = new System.Drawing.Point(3, 206);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(134, 31);
            this.LanguageLabel.TabIndex = 59;
            this.LanguageLabel.Text = "Language";
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ThemeLabel.Location = new System.Drawing.Point(6, 113);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(106, 31);
            this.ThemeLabel.TabIndex = 57;
            this.ThemeLabel.Text = "Theme:";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(184, 85);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(393, 10);
            this.guna2Separator2.TabIndex = 56;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ThemeComboBox.BorderRadius = 5;
            this.ThemeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThemeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThemeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ThemeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ThemeComboBox.ItemHeight = 30;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.ThemeComboBox.Location = new System.Drawing.Point(118, 113);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(140, 36);
            this.ThemeComboBox.TabIndex = 55;
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // AppearanceLabel
            // 
            this.AppearanceLabel.AutoSize = true;
            this.AppearanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppearanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AppearanceLabel.Location = new System.Drawing.Point(6, 73);
            this.AppearanceLabel.Name = "AppearanceLabel";
            this.AppearanceLabel.Size = new System.Drawing.Size(160, 31);
            this.AppearanceLabel.TabIndex = 54;
            this.AppearanceLabel.Text = "Appearance";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 60);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(573, 10);
            this.guna2Separator1.TabIndex = 53;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.SettingsLabel.Location = new System.Drawing.Point(3, 3);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(192, 54);
            this.SettingsLabel.TabIndex = 52;
            this.SettingsLabel.Text = "Settings";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.picArt);
            this.guna2Panel1.Controls.Add(this.RepeatLabel);
            this.guna2Panel1.Controls.Add(this.RepeatMusicToggleSwitch);
            this.guna2Panel1.Controls.Add(this.PreviousButton);
            this.guna2Panel1.Controls.Add(this.NextButton);
            this.guna2Panel1.Controls.Add(this.PlayButton);
            this.guna2Panel1.Controls.Add(this.nowPlayingTrackBar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 495);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 85);
            this.guna2Panel1.TabIndex = 31;
            // 
            // picArt
            // 
            this.picArt.BackColor = System.Drawing.Color.Transparent;
            this.picArt.BorderRadius = 3;
            this.picArt.Image = global::Guna_Music_Player.Properties.Resources.logo;
            this.picArt.ImageRotate = 0F;
            this.picArt.Location = new System.Drawing.Point(258, 33);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(40, 40);
            this.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArt.TabIndex = 45;
            this.picArt.TabStop = false;
            this.picArt.UseTransparentBackground = true;
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.RepeatLabel.Location = new System.Drawing.Point(531, 43);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(62, 20);
            this.RepeatLabel.TabIndex = 46;
            this.RepeatLabel.Text = "Repeat";
            // 
            // RepeatMusicToggleSwitch
            // 
            this.RepeatMusicToggleSwitch.Animated = true;
            this.RepeatMusicToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepeatMusicToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepeatMusicToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RepeatMusicToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RepeatMusicToggleSwitch.Location = new System.Drawing.Point(490, 43);
            this.RepeatMusicToggleSwitch.Name = "RepeatMusicToggleSwitch";
            this.RepeatMusicToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.RepeatMusicToggleSwitch.TabIndex = 47;
            this.RepeatMusicToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RepeatMusicToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RepeatMusicToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RepeatMusicToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.RepeatMusicToggleSwitch.CheckedChanged += new System.EventHandler(this.RepeatMusicToggleSwitch_CheckedChanged);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Animated = true;
            this.PreviousButton.BorderRadius = 5;
            this.PreviousButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PreviousButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PreviousButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreviousButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PreviousButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PreviousButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.Location = new System.Drawing.Point(304, 33);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(40, 40);
            this.PreviousButton.TabIndex = 50;
            this.PreviousButton.Text = "<";
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Animated = true;
            this.NextButton.BorderRadius = 5;
            this.NextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(444, 33);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(40, 40);
            this.NextButton.TabIndex = 49;
            this.NextButton.Text = ">";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Animated = true;
            this.PlayButton.BorderRadius = 5;
            this.PlayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PlayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PlayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PlayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PlayButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(350, 33);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(88, 40);
            this.PlayButton.TabIndex = 48;
            this.PlayButton.Text = "Play";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // nowPlayingTrackBar
            // 
            this.nowPlayingTrackBar.DisplayFocus = true;
            this.nowPlayingTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.nowPlayingTrackBar.IndicateFocus = true;
            this.nowPlayingTrackBar.Location = new System.Drawing.Point(10, 6);
            this.nowPlayingTrackBar.Name = "nowPlayingTrackBar";
            this.nowPlayingTrackBar.Size = new System.Drawing.Size(780, 26);
            this.nowPlayingTrackBar.TabIndex = 44;
            this.nowPlayingTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.nowPlayingTrackBar.Value = 0;
            this.nowPlayingTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nowPlayingTrackBarMouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MinimizeButton.BorderRadius = 5;
            this.MinimizeButton.BorderThickness = 3;
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(711, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(36, 36);
            this.MinimizeButton.TabIndex = 32;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Animated = true;
            this.ImportButton.BorderRadius = 5;
            this.ImportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ImportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ImportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ImportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ImportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ImportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(629, 13);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(76, 36);
            this.ImportButton.TabIndex = 71;
            this.ImportButton.Text = "Import";
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog.Caption = null;
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.MessageDialog.Parent = null;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MessageDialog.Text = null;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Guna_Music_Player.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 51;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(139, 13);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(38, 35);
            this.player.TabIndex = 1;
            this.player.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.NowPlayingTextBox);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.NowPlayingTabPage.ResumeLayout(false);
            this.FavouritesTabPage.ResumeLayout(false);
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox NowPlayingTextBox;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2TabControl TabControl;
        private System.Windows.Forms.TabPage NowPlayingTabPage;
        private System.Windows.Forms.TabPage FavouritesTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picArt;
        private System.Windows.Forms.Label RepeatLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RepeatMusicToggleSwitch;
        private Guna.UI2.WinForms.Guna2Button PreviousButton;
        private Guna.UI2.WinForms.Guna2Button NextButton;
        private Guna.UI2.WinForms.Guna2Button PlayButton;
        private Guna.UI2.WinForms.Guna2TrackBar nowPlayingTrackBar;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label SettingsLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label AppearanceLabel;
        private System.Windows.Forms.Label ThemeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ThemeComboBox;
        private System.Windows.Forms.Label LanguageLabel;
        private Guna.UI2.WinForms.Guna2ComboBox LanguageComboBox;
        private Guna.UI2.WinForms.Guna2Button ImportButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox NowPlayingListBox;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label AppLabel;
        private Guna.UI2.WinForms.Guna2Button ClearDataButton;
        private System.Windows.Forms.ListBox FavouritesListBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button DefaultSettingsButton;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
        private Guna.UI2.WinForms.Guna2Button FontButton;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}


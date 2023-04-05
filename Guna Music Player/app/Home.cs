using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Guna_Music_Player {
    public partial class Home : Form {
        bool on = true;
        private FontDialog fd = new FontDialog();

        public Home() {
            InitializeComponent();
        }

        String[] paths, files;

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }


        private void NextButton_Click(object sender, EventArgs e) {
            if(NowPlayingListBox.SelectedIndex < NowPlayingListBox.Items.Count-1) {
                NowPlayingListBox.SelectedIndex = NowPlayingListBox.SelectedIndex + 1;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e) {
            if(NowPlayingListBox.SelectedIndex > 0) {
                NowPlayingListBox.SelectedIndex = NowPlayingListBox.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                nowPlayingTrackBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                nowPlayingTrackBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
        }

        private void nowPlayingTrackBarMouseDown(object sender, MouseEventArgs e) {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / nowPlayingTrackBar.Width; 
        }

        private void RepeatMusicToggleSwitch_CheckedChanged(object sender, EventArgs e) {
            if (RepeatMusicToggleSwitch.Checked) {
                player.settings.setMode("loop", true);
            } else {
                player.settings.setMode("loop", false);
            }
        }

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (ThemeComboBox.SelectedIndex == 0) {
                BackColor = Color.FromArgb(33, 42, 57);
                SettingsTabPage.BackColor = Color.FromArgb(33, 42, 57);
                SettingsLabel.ForeColor = Color.White; 
                AppearanceLabel.ForeColor = Color.White;
                ThemeLabel.ForeColor = Color.White;
                
                ThemeComboBox.FillColor = Color.FromArgb(33, 42, 57);
                ThemeComboBox.BorderColor = Color.White;
                ThemeComboBox.ForeColor = Color.White;
                
                LanguageLabel.ForeColor = Color.White;
                
                LanguageComboBox.FillColor = Color.FromArgb(33, 42, 57);
                LanguageComboBox.BorderColor = Color.White;
                LanguageComboBox.ForeColor = Color.White;

                AppLabel.ForeColor = Color.White;

                nowPlayingTrackBar.FillColor = Color.White;
                nowPlayingTrackBar.ThumbColor = Color.White;

                NowPlayingTabPage.ForeColor = Color.FromArgb(33, 42, 57);
                FavouritesTabPage.ForeColor = Color.FromArgb(33, 42, 57);
                
                NowPlayingListBox.BackColor = Color.FromArgb(33, 42, 57);
                FavouritesListBox.BackColor = Color.FromArgb(33, 42, 57);
                
                NowPlayingListBox.ForeColor = Color.White;
                FavouritesListBox.ForeColor = Color.White;
                
                NowPlayingListBox.BorderStyle = BorderStyle.None;
                FavouritesListBox.BorderStyle = BorderStyle.None;
                
                RepeatLabel.ForeColor = Color.White;

                NowPlayingTextBox.ForeColor = Color.White;
                NowPlayingTextBox.FillColor = Color.FromArgb(33, 42, 57);
                NowPlayingTextBox.PlaceholderForeColor = Color.White;
            } else {
                BackColor = Color.White;
                SettingsTabPage.BackColor = Color.White;
                SettingsLabel.ForeColor = Color.FromArgb(33, 42, 57);
                AppearanceLabel.ForeColor = Color.FromArgb(33, 42, 57);
                ThemeLabel.ForeColor = Color.FromArgb(33, 42, 57);
                
                
                ThemeComboBox.FillColor = Color.White;
                ThemeComboBox.BorderColor = Color.Silver;
                ThemeComboBox.ForeColor = Color.FromArgb(33, 42, 57);
                
                LanguageLabel.ForeColor = Color.FromArgb(33, 42, 57);
                
                LanguageComboBox.FillColor = Color.White;
                LanguageComboBox.BorderColor = Color.Silver;
                LanguageComboBox.ForeColor = Color.FromArgb(33, 42, 57);

                AppLabel.ForeColor = Color.FromArgb(33, 42, 57);

                nowPlayingTrackBar.FillColor = Color.FromArgb(33, 42, 57);
                nowPlayingTrackBar.ThumbColor = Color.FromArgb(33, 42, 57);

                NowPlayingTabPage.ForeColor = Color.White;
                FavouritesTabPage.ForeColor = Color.White;
                
                NowPlayingListBox.BackColor = Color.White;
                FavouritesListBox.BackColor = Color.White;
                
                NowPlayingListBox.ForeColor = Color.FromArgb(33, 42, 57);
                FavouritesListBox.ForeColor = Color.FromArgb(33, 42, 57);
                
                NowPlayingListBox.ForeColor = Color.FromArgb(33, 42, 57);

                NowPlayingListBox.BorderStyle = BorderStyle.None;
                FavouritesListBox.BorderStyle = BorderStyle.None;
                
                RepeatLabel.ForeColor = Color.FromArgb(33, 42, 57);

                NowPlayingTextBox.ForeColor = Color.FromArgb(33, 42, 57);
                NowPlayingTextBox.FillColor = Color.White;
                NowPlayingTextBox.PlaceholderForeColor = Color.FromArgb(33, 42, 57);
            }
        }

        private void DefaultSettingsButton_Click(object sender, EventArgs e) {
            SettingsLabel.Font = new Font("Microsoft Sans Serif", 35);
            AppearanceLabel.Font = new Font("Microsoft Sans Serif", 20);
            ThemeLabel.Font = new Font("Microsoft Sans Serif", 20);
            AppLabel.Font = new Font("Microsoft Sans Serif", 20);
            FontButton.Font = new Font("Segoe UI", 10);
            ImportButton.Font = new Font("Segoe UI", 10);
            PlayButton.Font = new Font("Segoe UI", 15);
            DefaultSettingsButton.Font = new Font("Segoe UI", 10);
            ClearDataButton.Font = new Font("Segoe UI", 10);
            NowPlayingListBox.Font = new Font("Microsoft Sans Serif", 18);
            FavouritesListBox.Font = new Font("Microsoft Sans Serif", 18);
            RepeatLabel.Font = new Font("Microsoft Sans Serif", 12);
            LanguageLabel.Font = new Font("Microsoft Sans Serif", 20);
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (LanguageComboBox.SelectedIndex == 0) {
                SettingsLabel.Text = "Settings";
                AppearanceLabel.Text = "Appearance";
                ThemeLabel.Text = "Theme:";
                LanguageLabel.Text = "Language";
                AppLabel.Text = "App";
                ImportButton.Text = "Import";
                RepeatLabel.Text = "Repeat";
                FontButton.Text = "Set Font";
                NowPlayingTextBox.PlaceholderText = "Now Playing";
                DefaultSettingsButton.Text = "Default Settings";
                ClearDataButton.Text = "Clear Data";
                MessageDialog.Caption = "Something works wrong";
            } else {
                SettingsLabel.Text = "Настройки";
                AppearanceLabel.Text = "Внешний вид";
                ThemeLabel.Text = "Тема";
                LanguageLabel.Text = "Язык";
                AppLabel.Text = "Прил.";
                ImportButton.Text = "Импорт";
                RepeatLabel.Text = "Повтор";
                FontButton.Text = "Задать Шрифт";
                NowPlayingTextBox.PlaceholderText = "Название";
                DefaultSettingsButton.Text = "По умолчанию";
                ClearDataButton.Text = "Очистка";
                MessageDialog.Caption = "Что-то работал не так";
            }
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            if (on) {
                PlayButton.Text = "Pause";
                player.Ctlcontrols.play();
                on = false;
            } else {
                PlayButton.Text = "Play";
                on = true;
                player.Ctlcontrols.pause();
            }
        }

        private void NowPlayingListBox_SelectedIndexChanged(object sender, EventArgs e) {
            player.URL = paths[NowPlayingListBox.SelectedIndex];
            player.Ctlcontrols.play();

            PlayButton.Text = "Pause";

            try {
                var file = TagLib.File.Create(paths[NowPlayingListBox.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                NowPlayingTextBox.Text = Path.GetFileName(player.URL);
                picArt.Image = Image.FromStream(new MemoryStream(bin));
            } catch {

            }
        }

        private void FavouritesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            player.URL = paths[NowPlayingListBox.SelectedIndex];
            player.Ctlcontrols.play();
            PlayButton.Text = "Pause";

            try {
                var file = TagLib.File.Create(paths[FavouritesListBox.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                FavouritesListBox.Text = Path.GetFileName(player.URL);
                picArt.Image = Image.FromStream(new MemoryStream(bin));
            } catch {

            }
        }

        private void NowPlayingListBox_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                string item = (string)NowPlayingListBox.SelectedItem;
                FavouritesListBox.Items.Add(item);
            }
        }

        private void ClearDataButton_Click(object sender, EventArgs e) {
            NowPlayingListBox.Items.Clear();
            FavouritesListBox.Items.Clear();
            NowPlayingTextBox.PlaceholderText = "";
        }
        
        private void FontButton_Click(object sender, EventArgs e) {
            if (fd.ShowDialog() == DialogResult.OK) {
                NowPlayingListBox.Font = fd.Font;
                TabControl.Font = fd.Font;
                FavouritesListBox.Font = fd.Font;
                ImportButton.Font = fd.Font;
                SettingsLabel.Font = fd.Font;
                AppearanceLabel.Font = fd.Font;
                ThemeLabel.Font = fd.Font;
                FontButton.Font = fd.Font;
                LanguageLabel.Font = fd.Font;
                AppLabel.Font = fd.Font;
                DefaultSettingsButton.Font = fd.Font;
                ClearDataButton.Font = fd.Font;
                PlayButton.Font = fd.Font;
                RepeatLabel.Font = fd.Font;
            } 
        }

        private void ImportButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)  {
                files = openFileDialog.FileNames;
                paths = openFileDialog.FileNames;

                for (int x = 0; x < files.Length; x++) {
                    NowPlayingListBox.Items.Add(Path.GetFileName(files[x]));
                }
            }   
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows;

namespace ZIG04_syntezator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        SpeechSynthesizer synthMale = new SpeechSynthesizer();
        SpeechSynthesizer synthFemale = new SpeechSynthesizer();
        bool isPaused = false;
        string fullText = "";

        public MainWindow() {
            InitializeComponent();
            LoadVoices();
        }

        private void LoadVoices() {
            VoiceComboBoxMale.Items.Clear();
            VoiceComboBoxFemale.Items.Clear();

            //MALE
            foreach (var voice in synthMale.GetInstalledVoices()) {
                VoiceComboBoxMale.Items.Add(voice.VoiceInfo.Name);
            }
            if (VoiceComboBoxMale.Items.Count > 0)
                VoiceComboBoxMale.SelectedIndex = 0;

            //FEMALE
            foreach (var voice in synthFemale.GetInstalledVoices()) {
                VoiceComboBoxFemale.Items.Add(voice.VoiceInfo.Name);
            }
            if (VoiceComboBoxFemale.Items.Count > 0)
                VoiceComboBoxFemale.SelectedIndex = 0;
        }

        private void LoadFile_Click(object sender, RoutedEventArgs e) {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Pliki tekstowe|*.txt";
            if (dialog.ShowDialog() == true) {
                fullText = File.ReadAllText(dialog.FileName);
                StatusText.Text = "Status: Wczytano plik.";
            }
        }

        private async void Start_Click(object sender, RoutedEventArgs e) {
            synthMale.SpeakAsyncCancelAll();
            synthFemale.SpeakAsyncCancelAll();

            string voiceNameMale = VoiceComboBoxMale.SelectedItem?.ToString();
            string voiceNameFemale = VoiceComboBoxFemale.SelectedItem?.ToString();
            synthMale.SelectVoice(voiceNameMale);
            synthFemale.SelectVoice(voiceNameFemale);

            StatusText.Text = "Status: Czytanie...";
            await Task.Run(() => ReadTextWithMarkers(fullText));
            StatusText.Dispatcher.Invoke(() => StatusText.Text = "Status: Zakończono.");
        }

        private void ReadTextWithMarkers(string text) {
            var parts = text.Split(new[] { "[MALE]", "[FEMALE]" }, StringSplitOptions.None);
            var tags = GetTags(text);

            for (int i = 0; i < parts.Length; i++) {
                if (i == 0 && tags.Count == 0) {
                    synthMale.Speak(parts[i]);
                } else {
                    string tag = tags[Math.Max(i - 1, 0)];
                    if (tag == "MALE")
                        synthMale.Speak(parts[i]);
                    else if (tag == "FEMALE")
                        synthFemale.Speak(parts[i]);
                }
            }
        }

        private List<string> GetTags(string text) {
            var tags = new List<string>();
            int index = 0;
            while (index < text.Length) {
                int male = text.IndexOf("[MALE]", index);
                int female = text.IndexOf("[FEMALE]", index);

                if (male == -1 && female == -1) break;

                if (male != -1 && (female == -1 || male < female)) {
                    tags.Add("MALE");
                    index = male + 6;
                } else {
                    tags.Add("FEMALE");
                    index = female + 8;
                }
            }
            return tags;
        }

        private void PauseResume_Click(object sender, RoutedEventArgs e) {
            if (!isPaused) {
                synthMale.Pause();
                synthFemale.Pause();
                isPaused = true;
                StatusText.Text = "Status: Zapauzowano.";
            } else {
                synthMale.Resume();
                synthFemale.Resume();
                isPaused = false;
                StatusText.Text = "Status: Wznowiono.";
            }
        }
        }
    }
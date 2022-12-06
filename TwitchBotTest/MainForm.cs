using System;
using System.Windows.Forms;
using TwitchChatBot.Classes;

namespace TwitchChatBot {
    public partial class MainForm : Form {
        Bot twitchChatBot { get; set; }

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.twitchUsernameTextbox.Text = LoLStatsTwitchBot.Properties.Settings.Default.twitchBotName.ToString();
            this.accessTokenTextbox.Text = LoLStatsTwitchBot.Properties.Settings.Default.twitchAccessToken.ToString();
            this.joinMessageTextBox.Text = LoLStatsTwitchBot.Properties.Settings.Default.joinMessage.ToString();
            this.riotGamesApiTextBox.Text = LoLStatsTwitchBot.Properties.Settings.Default.riotGamesAPIKey.ToString();
        }

        private void startButton_Click(object sender, EventArgs e) {
            string twitchUsername = this.twitchUsernameTextbox.Text.Trim();
            string twitchAccessToken = this.accessTokenTextbox.Text.Trim();
            string twitchChannelName = this.channelNameTextbot.Text.Trim();

            this.twitchChatBot = new Bot(twitchUsername, twitchAccessToken, twitchChannelName);
            this.startButton.Enabled = false;
            this.stopButton.Enabled = true;

            this.twitchChatBot.Connect();

        }

        private void stopButton_Click(object sender, EventArgs e) {
            Console.WriteLine("Bot disconnected.");
            this.twitchChatBot.Disconnect();
            this.startButton.Enabled = true;
            this.stopButton.Enabled = false;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e) {
            LoLStatsTwitchBot.Properties.Settings.Default.twitchBotName = this.twitchUsernameTextbox.Text.Trim();
            LoLStatsTwitchBot.Properties.Settings.Default.twitchAccessToken = this.accessTokenTextbox.Text.Trim();
            LoLStatsTwitchBot.Properties.Settings.Default.joinMessage = this.joinMessageTextBox.Text.Trim();
            LoLStatsTwitchBot.Properties.Settings.Default.riotGamesAPIKey = this.riotGamesApiTextBox.Text.Trim();
            LoLStatsTwitchBot.Properties.Settings.Default.Save();

            MessageBox.Show("Impostazioni salvate", "Salva");
        }
    }
}

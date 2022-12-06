namespace TwitchChatBot {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.riotGamesApiTextBox = new System.Windows.Forms.TextBox();
            this.riotGamesApiLabel = new System.Windows.Forms.Label();
            this.joinMessageTextBox = new System.Windows.Forms.TextBox();
            this.joinTextLabel = new System.Windows.Forms.Label();
            this.channelNameTextbot = new System.Windows.Forms.TextBox();
            this.channelName = new System.Windows.Forms.Label();
            this.accessTokenTextbox = new System.Windows.Forms.TextBox();
            this.accessToken = new System.Windows.Forms.Label();
            this.twitchUsernameTextbox = new System.Windows.Forms.TextBox();
            this.twitchUsernameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.riotGamesApiTextBox);
            this.groupBox1.Controls.Add(this.riotGamesApiLabel);
            this.groupBox1.Controls.Add(this.joinMessageTextBox);
            this.groupBox1.Controls.Add(this.joinTextLabel);
            this.groupBox1.Controls.Add(this.channelNameTextbot);
            this.groupBox1.Controls.Add(this.channelName);
            this.groupBox1.Controls.Add(this.accessTokenTextbox);
            this.groupBox1.Controls.Add(this.accessToken);
            this.groupBox1.Controls.Add(this.twitchUsernameTextbox);
            this.groupBox1.Controls.Add(this.twitchUsernameLabel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // riotGamesApiTextBox
            // 
            resources.ApplyResources(this.riotGamesApiTextBox, "riotGamesApiTextBox");
            this.riotGamesApiTextBox.Name = "riotGamesApiTextBox";
            // 
            // riotGamesApiLabel
            // 
            resources.ApplyResources(this.riotGamesApiLabel, "riotGamesApiLabel");
            this.riotGamesApiLabel.Name = "riotGamesApiLabel";
            // 
            // joinMessageTextBox
            // 
            resources.ApplyResources(this.joinMessageTextBox, "joinMessageTextBox");
            this.joinMessageTextBox.Name = "joinMessageTextBox";
            // 
            // joinTextLabel
            // 
            resources.ApplyResources(this.joinTextLabel, "joinTextLabel");
            this.joinTextLabel.Name = "joinTextLabel";
            // 
            // channelNameTextbot
            // 
            resources.ApplyResources(this.channelNameTextbot, "channelNameTextbot");
            this.channelNameTextbot.Name = "channelNameTextbot";
            // 
            // channelName
            // 
            resources.ApplyResources(this.channelName, "channelName");
            this.channelName.Name = "channelName";
            // 
            // accessTokenTextbox
            // 
            resources.ApplyResources(this.accessTokenTextbox, "accessTokenTextbox");
            this.accessTokenTextbox.Name = "accessTokenTextbox";
            // 
            // accessToken
            // 
            resources.ApplyResources(this.accessToken, "accessToken");
            this.accessToken.Name = "accessToken";
            // 
            // twitchUsernameTextbox
            // 
            resources.ApplyResources(this.twitchUsernameTextbox, "twitchUsernameTextbox");
            this.twitchUsernameTextbox.Name = "twitchUsernameTextbox";
            // 
            // twitchUsernameLabel
            // 
            resources.ApplyResources(this.twitchUsernameLabel, "twitchUsernameLabel");
            this.twitchUsernameLabel.Name = "twitchUsernameLabel";
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // saveSettingsButton
            // 
            resources.ApplyResources(this.saveSettingsButton, "saveSettingsButton");
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox twitchUsernameTextbox;
        private System.Windows.Forms.Label twitchUsernameLabel;
        private System.Windows.Forms.TextBox accessTokenTextbox;
        private System.Windows.Forms.Label accessToken;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox channelNameTextbot;
        private System.Windows.Forms.Label channelName;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox joinMessageTextBox;
        private System.Windows.Forms.Label joinTextLabel;
        private System.Windows.Forms.TextBox riotGamesApiTextBox;
        private System.Windows.Forms.Label riotGamesApiLabel;
    }
}


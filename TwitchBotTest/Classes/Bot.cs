using System;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Client;
using TwitchLib.Communication.Models;
using TwitchLib.Communication.Clients;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.LeagueV4;

namespace TwitchChatBot.Classes {
    class Bot {
        TwitchClient client;
        string channel;

        public Bot(string twitchUsername, string accessToken, string channelName) {
            ConnectionCredentials credentials = new ConnectionCredentials(twitchUsername, accessToken);
            var clientOptions = new ClientOptions {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };

            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, channelName);
            this.channel = channelName;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnChatCommandReceived += Client_OnCommandReceived;

            client.OnConnected += Client_OnConnected;

        }

        public void Connect() { this.client.Connect(); }

        public void Disconnect() {
            this.client.Disconnect();
        }

        private void Client_OnLog(object sender, OnLogArgs e) {
            Console.WriteLine($"{e.DateTime.ToString()}: {e.BotUsername} - {e.Data}");
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e) {
            Console.WriteLine($"Connected to {e.AutoJoinChannel}");
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e) {
           client.SendMessage(e.Channel, LoLStatsTwitchBot.Properties.Settings.Default.joinMessage.ToString());
        }



        private void Client_OnCommandReceived(object sender, OnChatCommandReceivedArgs commandArgs) {
            string commandReceived = commandArgs.Command.CommandText;
            ChatMessage chatMessage = commandArgs.Command.ChatMessage;
            string cmdArgs = commandArgs.Command.ArgumentsAsString;

            if (cmdArgs.Length == 0 || cmdArgs == null) {
                client.SendMessage(this.channel, "Il summoner non può essere vuoto. PERDDDDIO");
            } else {
                switch (commandReceived) {
                    case "lolstats":
                        // Delegating Fetch and Print of Summoner's stats
                        string summonerString = commandArgs.Command.ArgumentsAsString;
                        this.GetAndPrintLoLStats(summonerString);
                        break;
                }
            }
        }

        private void GetAndPrintLoLStats(string summonerString) {
            string message = "";
            RiotApiFacade facade = RiotApiFacade.Build(); // Creating a Facade to use RiotApi Interface
            Summoner summoner = facade.GetSummonerByName(summonerString); // Saving the summoner
            if (summoner == null) {
                message = "Il summoner non esiste";
            } else {

                LeagueEntry[] summonerLeagueEntries = facade.GetSummonerStatsById(summoner.Id);
                LeagueEntry rankedEntry = new LeagueEntry();

                if (summonerLeagueEntries.Length == 0) {
                    message = $"{summoner.Name} è Unranked";
                } else {
                    foreach (var entry in summonerLeagueEntries) {
                        if (entry.QueueType.Equals("RANKED_SOLO_5x5")) {
                            rankedEntry = entry;
                            break;
                        }
                    }
                    message = $"{rankedEntry.SummonerName} - Rank: {rankedEntry.Tier} {rankedEntry.Rank} | Wins: {rankedEntry.Wins} Losses: {rankedEntry.Losses}";
                }
            }
            
            client.SendMessage(this.channel, $"[EUW] {message}");
        }
    }
}
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.LeagueV4;
using MingweiSamuel.Camille.SummonerV4;
using System;
using MingweiSamuel.Camille.Enums;
using System.Windows.Forms.PropertyGridInternal;

namespace TwitchChatBot.Classes {
    internal class RiotApiFacade {
        private RiotApi riotApi { get; set; }
        private Region apiRegion;

        private RiotApiFacade() {
            this.riotApi = RiotApi.NewInstance(LoLStatsTwitchBot.Properties.Settings.Default.riotGamesAPIKey);
        }

        public Summoner GetSummonerByName(string summonerName) {
            Summoner summoner = riotApi.SummonerV4.GetBySummonerName(Region.EUW, summonerName);
            return summoner;
        }

        public LeagueEntry[] GetSummonerStatsById(string summonerId) {
            return riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.EUW, summonerId);
        }

        public static RiotApiFacade Build() {
            return new RiotApiFacade();
        }
    }
}

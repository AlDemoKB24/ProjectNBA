using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NBAScheduleApp
{
    public class FavoriteTeamManager
    {
        private const string FavoritesFileName = "favorites.json";
        private List<string> _favoriteTeams;

        public FavoriteTeamManager()
        {
            _favoriteTeams = new List<string>();
            LoadFavorites();
        }

        public List<string> GetFavorites()
        {
            return new List<string>(_favoriteTeams);
        }

        public void AddFavorite(string teamName)
        {
            if (!_favoriteTeams.Contains(teamName))
            {
                _favoriteTeams.Add(teamName);
                SaveFavorites();
            }
        }

        public void RemoveFavorite(string teamName)
        {
            if (_favoriteTeams.Contains(teamName))
            {
                _favoriteTeams.Remove(teamName);
                SaveFavorites();
            }
        }

        public bool IsFavorite(string teamName)
        {
            return _favoriteTeams.Contains(teamName);
        }

        private void LoadFavorites()
        {
            if (File.Exists(FavoritesFileName))
            {
                try
                {
                    string json = File.ReadAllText(FavoritesFileName);
                    _favoriteTeams = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
                }
                catch
                {
                    _favoriteTeams = new List<string>();
                }
            }
        }

        private void SaveFavorites()
        {
            string json = JsonConvert.SerializeObject(_favoriteTeams);
            File.WriteAllText(FavoritesFileName, json);
        }
    }
}
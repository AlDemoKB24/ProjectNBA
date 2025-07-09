using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static NBAScheduleApp.Team;



namespace NBAScheduleApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Загрузка списка команд...";

            try
            {
                string teamsUrl = "https://www.thesportsdb.com/api/v1/json/123/search_all_teams.php?l=NBA";
                HttpResponseMessage response = await _client.GetAsync(teamsUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<TeamsResponse>(json); // Десериализация

                    cbTeams.Items.Clear();
                    foreach (var team in data.Teams)
                    {
                        cbTeams.Items.Add(team.Name);
                    }

                    if (cbTeams.Items.Count > 0)
                    {
                        cbTeams.SelectedIndex = 0;
                        cbSeasons.SelectedIndex = 0;
                    }

                    lblStatus.Text = "Готово. Выберите команду и сезон.";
                }
                else
                {
                    lblStatus.Text = "Ошибка загрузки списка команд";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ошибка: {ex.Message}";
            }
        }



        private async void btnLoadMatches_Click(object sender, EventArgs e)
        {
            if (cbTeams.SelectedItem == null || cbSeasons.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите команду и сезон", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teamName = cbTeams.SelectedItem.ToString();
            string season = cbSeasons.SelectedItem.ToString();
            string matchesUrl = $"https://www.thesportsdb.com/api/v1/json/3/eventsseason.php?id=4387&s={season}";

            lblStatus.Text = $"Загрузка матчей {teamName} за сезон {season}...";
            listViewMatches.Items.Clear();

            try
            {
                HttpResponseMessage response = await _client.GetAsync(matchesUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<MatchesResponse>(json); // Десериализация

                    int matchCount = 0;
                    foreach (var match in data.Events)
                    {
                        if (match.HomeTeam == teamName || match.AwayTeam == teamName)
                        {
                            string date = DateTime.Parse(match.Date).ToString("dd.MM.yyyy");
                            ListViewItem item = new ListViewItem(date);
                            item.SubItems.Add(match.HomeTeam);
                            item.SubItems.Add(match.AwayTeam);
                            item.SubItems.Add(match.Score);

                            listViewMatches.Items.Add(item);
                            matchCount++;
                        }
                    }

                    lblStatus.Text = $"Загружено {matchCount} матчей для {teamName} ({season})";
                }
                else
                {
                    lblStatus.Text = "Ошибка при загрузке матчей";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
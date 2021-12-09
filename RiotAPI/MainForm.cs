using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace RiotAPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new MatchViewModel();
            MatchViewModelBindingSource.DataSource = ViewModel;
        }

        private MatchViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    MatchViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            riotApi = RiotApi.NewInstance(APIKeyTextBox.Text);
            summoner = riotApi.SummonerV4.GetBySummonerName(NA, SummonerNameTextBox.Text);

            var Matches = riotApi.MatchV5.GetMatchIdsByPUUID(Americas, summoner.Puuid);

            MatchListBox.Items.AddRange(Matches);

        }

        private void MatchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matchID = MatchListBox.SelectedItem.ToString();

            var jsonMatch = riotApi.MatchV5.GetMatch(Americas, matchID);
            ViewModel.Match = JsonConvert.DeserializeObject<Match>(jsonMatch.ToString());

            // make current participant(player) property of Match?
            foreach (Participant participant in _viewModel._match.Info.Participants)
            {
                if (participant.SummonerName == summoner.Name)
                {
                    currentParticipant = participant;
                }
            }

            // set participant values here
        }

        private RiotApi riotApi;
        private Summoner summoner;
        private Participant currentParticipant;

        private MatchViewModel _viewModel;

        private Region NA = MingweiSamuel.Camille.Enums.Region.NA;
        private Region Americas = MingweiSamuel.Camille.Enums.Region.Americas;
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace RiotAPI
{
    internal class MatchViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public BindingList<Participant> Participants { get; set; }

        public Match Match
        {
            set
            {
                if (_match != value)
                {
                    _match = value;
                    if (_match != null)
                    {
                        Participants = new BindingList<Participant>(_match.Info.Participants);
                    }
                }
            }
        }

        public Match _match;
    }
}

using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Mvvm;
using TTT.Data.Models;

namespace TTT.Data.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
        private Participant _participantToAdd;

        public SettingsViewModel()
        {
            ParticipantToAdd = new Participant();

            Participants.Add(new Participant
            {
                FirstName = "Timo",
                LastName = "Ehrenbrusthof",
                NickName = "TheHoff"
            });

            Participants.Add(new Participant
            {
                FirstName = "Patrick",
                LastName = "Brunck"
            });

            Participants.Add(new Participant
            {
                FirstName = "Lutz",
                LastName = "Brandt"
            });

        }

        public ObservableCollection<Participant> Participants { get; set; } = new ObservableCollection<Participant>();

        public Participant ParticipantToAdd
        {
            get => _participantToAdd;
            set => SetProperty(ref _participantToAdd, value);
        }

        public DelegateCommand AddParticipantCommand => new DelegateCommand(() =>
        {
            Participants.Add(ParticipantToAdd);
            ParticipantToAdd = new Participant();
        } );

    }
}
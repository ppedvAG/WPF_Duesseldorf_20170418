using HalloMVVM.Helpers;
using System.Collections.Generic;

namespace HalloMVVM.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _welcomeText;
        public string WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                SetProperty(ref _welcomeText, value);
            }
        }

        public List<string> Friends
        {
            get
            {
                return new List<string>
                {
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz",
                    "Hans", "Peter", "Luis", "Franz"
                };
            }
        }


        private RelayCommand _changeTextCommand;
        public RelayCommand ChangeTextCommand
        {
            get
            {
                if (_changeTextCommand == null)
                    _changeTextCommand = new RelayCommand(
                        execute: () => WelcomeText = "Mein neuer Text aus dem VM! ;-)",
                        canExecute: () => WelcomeText == null || WelcomeText.Length < 10);

                return _changeTextCommand;
            }
        }

        private RelayCommand _showMessageCommand;
        private readonly IMessageBoxHelper _mBoxHelper;

        public RelayCommand ShowMessageCommand
        {
            get
            {
                return _showMessageCommand ??
                    (_showMessageCommand = new RelayCommand(
                        () => _mBoxHelper.ShowMessage("Item gelöscht.")));
            }
        }

        public MainWindowViewModel(IMessageBoxHelper mboxHelper)
        {
            _mBoxHelper = mboxHelper;
        }
    }
}
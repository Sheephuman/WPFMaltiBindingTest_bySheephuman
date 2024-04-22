using System.ComponentModel;

namespace WPFMaltiBindingTest
{
    public class QueryField : INotifyPropertyChanged
    {
        private string _userInputA = string.Empty;
        public string UserInputA
        {
            get => _userInputA;
            set
            {
                if (_userInputA != value)
                {
                    _userInputA = value;
                    OnPropertyChanged(nameof(UserInputA));
                    UpdateAllInput();
                }
            }
        }

        private string _userInputB = string.Empty;
        public string UserInputB
        {
            get => _userInputB;
            set
            {
                if (_userInputB != value)
                {
                    _userInputB = value;
                    OnPropertyChanged(nameof(UserInputB));
                    UpdateAllInput();
                }
            }
        }

        private string _allInput = string.Empty;
        public string AllInput
        {
            get => _allInput;
            private set
            {
                if (_allInput != value)
                {
                    _allInput = value;
                    OnPropertyChanged(nameof(AllInput));
                }
            }
        }
        private void UpdateAllInput()
        {
            AllInput = $"-b:v {_userInputA}k -codec:v {_userInputB}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

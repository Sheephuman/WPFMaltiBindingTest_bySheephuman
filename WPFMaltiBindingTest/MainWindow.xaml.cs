using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFMaltiBindingTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _userInput = string.Empty;

        // ユーザー入力用文字列
        public string UserInput
        {
            get => _userInput;
            set
            {
                if (_userInput != value)
                {
                    _userInput = value;
                    StringB = $"-b:v {_userInput}k";
                    OnPropertyChanged(nameof(UserInput));
                }
            }
        }

        private string _stringB = string.Empty;

        // StringBプロパティ
        public string StringB
        {
            get => _stringB;
            set
            {
                if (_stringB != value)
                {
                    _stringB = value;
                    OnPropertyChanged(nameof(StringB));
                }
            }
        }

        // INotifyPropertyChangedのイベント
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            SetupBindings();
        }

        // バインディングのセットアップ
        private void SetupBindings()
        {
            // ユーザー入力バインディング
            Binding userInputBinding = new Binding("UserInput")
            {
                Source = this,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            textBoxInput.SetBinding(TextBox.TextProperty, userInputBinding);

            // マルチバインディング設定
            MultiBinding multiBinding = new MultiBinding()
            {
                StringFormat = "{0}"
            };
            multiBinding.Bindings.Add(new Binding("StringB") { Source = this, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged });
            textBlockOutput.SetBinding(TextBlock.TextProperty, multiBinding);
        }

        // プロパティが変更された時にUIに通知するためのヘルパーメソッド
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

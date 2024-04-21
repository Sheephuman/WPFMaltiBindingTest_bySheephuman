using System.ComponentModel;
using System.Windows;

namespace WPFMaltiBindingTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
        {
            private string _userInput = string.Empty;



            //ユーザー入力用文字列
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


            // ビューモデルのプロパティを公開するためのプロパティ
            private string _stringB { get; set; } = string.Empty;
            // INotifyPropertyChangedのイベント
            public event PropertyChangedEventHandler? PropertyChanged;

            // StringBプロパティ
            public string StringB
            {
                get { return _stringB; }
                set
                {
              
                    if (_stringB != value)
                    {

                        _stringB = value;
                        OnPropertyChanged(nameof(StringB));  // 変更通知
                   
                    }
                }
            }


            public MainWindow()
            {
                InitializeComponent();
                // ビューモデルまたはコードビハインドのプロパティに初期値を設定


                // DataContextにこのウィンドウ自体をセット（コードビハインドプロパティ用）
                DataContext = this;
            }
            // プロパティが変更された時にUIに通知するためのヘルパーメソッド
            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
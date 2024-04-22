using System.ComponentModel;
using System.Windows;

namespace WPFMaltiBindingTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
        {
         

            public MainWindow()
            {
                InitializeComponent();
                // ビューモデルまたはコードビハインドのプロパティに初期値を設定


                // DataContextにこのウィンドウ自体をセット（コードビハインドプロパティ用）
                var qf =new QueryField();
                DataContext = qf;
            }

        public event PropertyChangedEventHandler? PropertyChanged;

        // プロパティが変更された時にUIに通知するためのヘルパーメソッド
        protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
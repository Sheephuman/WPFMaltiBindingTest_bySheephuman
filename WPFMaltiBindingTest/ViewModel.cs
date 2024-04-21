using System.Collections.ObjectModel;
using System.Windows.Data;

namespace WPFMaltiBindingTest
{
   public class MyViewModel :BindingBase
    {
        public MyViewModel() 
        {
            // 実験用にリストを作成
            ItemList.Add(1);
            ItemList.Add(2);
            ItemList.Add(3);
            ItemList.Add(4);
            ItemList.Add(5);
        }
        public ObservableCollection<int> ItemList { get => _itemList; set => _itemList = value; }
        private ObservableCollection<int> _itemList = new ObservableCollection<int>();

        public string Unit { get; } = "メートル";

      
    }
}
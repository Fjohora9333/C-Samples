using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.IO;
using System.Windows;

namespace Zisa_Retail_Item_Class
{
    public class VM : INotifyPropertyChanged
    {
        RetailItem[] RatailItems;
      
        //field to hold the entity list--RatailItems
        private BindingList<RetailItem> itemList;

        //Property Linked to the entity list
        public BindingList<RetailItem> ItemList
        {
            get { return itemList; }
            set { itemList = value; NotifyChanged(); }
        }

        void AssignItemToList()
        {
            BindingList<RetailItem> ShowedItemList = new BindingList<RetailItem>();

            for (int i = 0; i < RatailItems.Length; i++)
            {
                ShowedItemList.Add( RatailItems[i]);
                
            }
            ItemList = ShowedItemList;
        }
        public VM()
        {
            //creating new objects of the entity class
            RetailItem Jacket = new RetailItem("Jacket", "12 ", "59.95");
            RetailItem Jeans = new RetailItem("Jeans", " 40 ", " 34.95");
            RetailItem Shirt = new RetailItem("Shirt", "20", "24.95");

            RatailItems = new RetailItem[] { Jacket, Jeans, Shirt };
            AssignItemToList();
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}

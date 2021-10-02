using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryList
{
    public static class Common
    {
        public static void SaveToFile(string fileName, CheckBox checkBoxName, string items)
        {
            Store s = new Store();
            s.StoreName = checkBoxName.Text;

            string[] itemArray = items.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            List <Item>itemsList = new List<Item>();

            foreach(var item in itemArray)
            {
                itemsList.Add(new Item(item.ToString(), "Pending"));
            }

            s.Items = itemsList;

            try
            {
                File.AppendAllText(fileName, JsonConvert.SerializeObject(s));
                checkBoxName.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public class Store
        {
            public string StoreName { get; set; }
            public List<Item> Items { get; set; }
        }

        public class Item
        {
            public Item(string name, string status)
            {
                this.Name = name;
                this.Status = status;
            }

            public string Name { get; set; }
            public string Status { get; set; }
        }

        public static string GetMessageBody(string dataFile)
        {
            string json = File.ReadAllText(dataFile);
            List<Store> stores = JsonConvert.DeserializeObject<List<Store>>(json);
            var sb = new StringBuilder();
            foreach (var store in stores)
            {
                sb.AppendLine("<b>" + store.StoreName + "</b><br/>");
                foreach (var i in store.Items)
                {
                    sb.Append(i.Name + " - ");
                    sb.AppendLine(i.Status);
                }
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}

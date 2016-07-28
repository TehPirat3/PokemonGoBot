using PokemonGoBot.API;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PokemonGoBot
{
    public partial class Bag : Form
    {
        public Client client { get; set; }
        public Bag()
        {
            InitializeComponent();
        }

        private async void Bag_Load(object sender, EventArgs e)
        {
            var inv = await client.GetItems(client);
            foreach (var item in inv)
            {
                var a = Regex.Replace($"{(AllEnum.ItemId)item.Item_}", "([a-z])([A-Z])", "$1 $2");
                ListViewItem lvi = new ListViewItem(a.Replace("Item", ""));
                listView1.Items.Add(lvi);
                lvi.SubItems.Add(item.Count.ToString());
            }
        }
    }
}

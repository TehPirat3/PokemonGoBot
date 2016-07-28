using PokemonGoBot.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGoBot
{
    public partial class Setup : Form
    {
        public bool completed = false;
        public Setup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Not all fields are valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //var data = Main.data;
            Data data = new Data();
            Main.id++;
            CancellationTokenSource cts = new CancellationTokenSource();
            //CancellationToken token = cts.Token;
            data.AuthType = authType.Text.Equals("Ptc") ? AuthType.Ptc : AuthType.Google;
            data.PtcUsername = user.Text;
            data.PtcPassword = pass.Text;
            data.DefaultLatitude = double.Parse(lat.Value.ToString());
            data.DefaultLongitude = double.Parse(lon.Value.ToString());
            data.LevelOutput = levelOutput.Text;
            data.LevelTimeInterval = int.Parse(levelInterval.Value.ToString());
            data.RecycleItemsInterval = int.Parse(recycleInterval.Value.ToString());
            data.TransferType = trasnferType.Text;
            data.TransferCPThreshold = int.Parse(cpThreshold.Value.ToString());
            data.EvolveAllGivenPokemons = evolve.Checked;
            data.CurrentLevel = -1;
            data.GoogleRefreshToken = string.Empty;
            //data.token = new CancellationTokenSource();
            data.token = cts;
            Main.clientData.Add(Main.id, data);
            /*data.user = user.Text;
            data.password = pass.Text;
            data.lat = lat;
            data.lon = lon;
            //data.levelOutput = levelOutput;
            data.levelInterval = levelInterval;
            data.recycleInterval = recycleInterval;
            data.transferType = trasnferType;
            data.cpTreshold = cpThreshold;
            data.evolve = evolve;*/
            //Main.addFlow();
            completed = true;
            Close();
        }

        private void authType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (authType.Text)
            {
                case "Ptc":
                    pass.Enabled = true;
                    user.Enabled = true;
                    break;
                case "Google":
                    pass.Enabled = false;
                    user.Enabled = false;
                    break;
            }
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void levelOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (levelOutput.Text)
            {
                case "levelup":
                    levelInterval.Enabled = false;
                        break;
                case "time":
                    levelInterval.Enabled = true;
                    break;
            }
        }

        private void trasnferType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (trasnferType.Text)
            {
                case "cp":
                    cpThreshold.Enabled = true;
                    break;
                default:
                    cpThreshold.Enabled = false;
                    break;
            }
        }

        //public Control GroupBox()

    }
}

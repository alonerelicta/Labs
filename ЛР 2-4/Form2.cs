using LabaInformationTechologics.BuisnesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaInformationTechologics
{
    public partial class Form2 : Form
    {
        private readonly Form1 _form1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            _form1.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            _form1.Show();
        }

        private async void TurnOn_Click(object sender, EventArgs e)
        {
            
            using (HttpClient client = new HttpClient())
            {
                var result = Task.Run(
                    async  () => {
                        return await client.GetAsync("https://api.spacexdata.com/v3/info");
                        }
                );
                await result;
                Label labelJson = new Label();
                String text  = await result.Result.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<ModelJson>(text);
                labelJson.Text = $"Company information\n" +
                    $"name = {data.name}\n" +
                    $"founder = {data.founder}\n" +
                    $"founded = {data.founded}\n" +
                    $"summary = {data.summary}";
                labelJson.Enabled = true;
                labelJson.AutoSize = true;
                labelJson.MaximumSize = new Size(400, 300);
                this.panel2.Controls.Add(labelJson);
            }

        }
    }
}

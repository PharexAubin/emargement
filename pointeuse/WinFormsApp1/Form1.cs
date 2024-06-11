using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            HttpClient clint = new HttpClient();

            clint.BaseAddress = new Uri("https://localhost:7295/");
            HttpResponseMessage response = clint.GetAsync("api/Eleves").Result;
            var elvs = response.Content.ReadAsAsync<IEnumerable<Eleve>>().Result;
            dataGridView1.DataSource = elvs;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Eleve nouvelEleve = new Eleve
            {
                Nom = textBoxnom.Text,
                Prenom = textBoxpnom.Text,
                Telephone = textBoxtel.Text,
                Email = textBoxemail.Text,
                ElClasseId = Convert.ToInt32(textBoxelclasse.Text)
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7295/");

            HttpResponseMessage response = await client.PostAsJsonAsync("api/Eleves", nouvelEleve);

            if (response.IsSuccessStatusCode)
            {
                response = await client.GetAsync("api/Eleves");
                var elvs = await response.Content.ReadAsAsync<IEnumerable<Eleve>>();
                dataGridView1.DataSource = elvs;

                textBoxnom.Text = "";
                textBoxpnom.Text = "";
                textBoxtel.Text = "";
                textBoxemail.Text = "";
                textBoxelclasse.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
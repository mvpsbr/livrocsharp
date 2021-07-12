using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadAssincrono
{
    public partial class frmPrincipal : Form
    {
        string site;
        public frmPrincipal()
        {
            InitializeComponent();
            this.btnLer.Click += async (o, e) => { await btnLer_Click(o, e); };
            site = "";
        }

        private async Task btnLer_Click(object sender, EventArgs e)
        {
            lstStatus.Items.Add("Lendo site...");
            lstStatus.Refresh();
            var web = new HttpClient();
            site = await web.GetStringAsync(new Uri(txtSite.Text));
            if (site != "" && txtPalavra.Text != "")
            {
                lstStatus.Items.Add("Site lido");
                btnContar_Click(sender, e);
            }
        }

        private async void btnContar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "")
            {
                var total = await ContarPalavras(txtPalavra.Text);
                lstStatus.Items.Add($"Total de ocorrências da palavra {txtPalavra.Text} = { total}");
            }
            else
            {
                lstStatus.Items.Add("Palavra não informada");
            }
        }

        private async Task<int> ContarPalavras(string palavra)
        {
            return await Task.Run(() => Regex.Matches(site, palavra).Count());
        }
    }
}

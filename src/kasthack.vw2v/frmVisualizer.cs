namespace kasthack.wv2test2
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.Web.WebView2.Core;

    public partial class FrmVisualizer : Form
    {
        private readonly string content;

        public FrmVisualizer(Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider objectProvider)
        {
            this.InitializeComponent();
            this.content = objectProvider?.GetObject() as string ?? "&gt;nothing to show&lt;";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "kasthack.wv2v");
            var webView2Environment = await CoreWebView2Environment.CreateAsync(null, userDataFolder).ConfigureAwait(true);
            await this.brsContent.EnsureCoreWebView2Async(webView2Environment).ConfigureAwait(true);
            this.brsContent.NavigateToString(this.content);
        }
    }
}

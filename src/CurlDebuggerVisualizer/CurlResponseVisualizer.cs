using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Net.Http;
using System.Windows.Forms;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(CurlDebuggerVisualizer.CurlResponseVisualizer),
    typeof(CurlDebuggerVisualizer.HttpResponseVisualizerObjectSource),
    Target = typeof(HttpResponseMessage),
    Description = "cURL request")]

namespace CurlDebuggerVisualizer
{
    public class CurlResponseVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (objectProvider == null) throw new ArgumentNullException(nameof(objectProvider));
            var request = (HttpRequestMessage)objectProvider.GetObject();
            string curl = CurlRequestFormatter.ToCurl(request);

            using (var form = new Form())
            using (var textBox = new TextBox())
            {
                form.Text = "cURL";
                textBox.Multiline = true;
                textBox.ReadOnly = true;
                textBox.Dock = DockStyle.Fill;
                textBox.Text = curl;
                form.ClientSize = new System.Drawing.Size(800, 450);
                form.Controls.Add(textBox);
                windowService.ShowDialog(form);
            }
        }
    }

    public class HttpResponseVisualizerObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            if (target is HttpResponseMessage response && response.RequestMessage != null)
            {
                base.GetData(response.RequestMessage, outgoingData);
            }
            else
            {
                base.GetData(null, outgoingData);
            }
        }
    }
}

using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
            typeof(kasthack.wv2test2.DebuggerSide),
            typeof(VisualizerObjectSource),
            Target = typeof(string),
            Description = "WebView2 visualizer")]

namespace kasthack.wv2test2
{
    public class DebuggerSide : DialogDebuggerVisualizer
    {
        public static void TestShowVisualizer(object objectToVisualize)
            => new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide))
                .ShowVisualizer();

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider) => windowService.ShowDialog(new FrmVisualizer(objectProvider));
    }
}

using Avalonia;
using Avalonia.Markup.Xaml;

namespace CrossSnakeGUI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

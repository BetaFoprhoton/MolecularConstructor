using Avalonia;
using Avalonia.Controls;
using Avalonia.Dialogs;
using Avalonia.Markup.Xaml;
using SukiUI.Controls;

namespace RealismConstructor.ui;

public partial class UIWindow : SukiWindow {
    public UIWindow() {
        
    }
    /*
    public static AppBuilder BuildAvaloniaApp() {
        var app = AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();

        if (OperatingSystem.IsWindows() || OperatingSystem.IsMacOS() || OperatingSystem.IsLinux())
            app.UseManagedSystemDialogs();
        return app;
    }*/
}
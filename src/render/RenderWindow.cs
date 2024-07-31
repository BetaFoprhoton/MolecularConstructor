using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace MolecularConstructor.silk;

public class RenderWindow {
    private static IWindow? _window;
    private static GL Gl;
    
    public RenderWindow(int width, int height, string title) {
        //Create a window.
        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>(width, height);
        options.Title = title;
        
        _window = Window.Create(options);
        
        //Assign events.
        /*
         _window.Load += OnLoad;
         _window.Update += OnUpdate;
         _window.Render += OnRender;    
         _window.FramebufferResize += OnFramebufferResize;
         */
    }

    public void Run() {
        _window?.Run();
    }
    
    public void Dispose() {
        _window?.Dispose();
    }
}
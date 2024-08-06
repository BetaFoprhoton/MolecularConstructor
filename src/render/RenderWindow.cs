using MolecularConstructor.render;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace MolecularConstructor.silk;

public class RenderWindow {
    private IWindow? _window;
    private FreeCamera _camera;
    private GL Gl;
    
    public RenderWindow(int width, int height, string title) {
        //Create a window.
        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>(width, height);
        options.Title = title;
        
        _window = Window.Create(options);
        _camera = new FreeCamera(_window);
        
        
         _window.Load += OnLoad;
         //_window.Update += OnUpdate;
         //_window.Render += OnRender;    
         _window.FramebufferResize += OnFramebufferResize;
         
    }
    
    private void OnFramebufferResize(Vector2D<int> newSize) {
        Gl.Viewport(newSize);
    }

    private void OnLoad() {
        Gl = GL.GetApi(_window);
    }

    public void Run() {
        _window?.Run();
    }
    
    public void Dispose() {
        _window?.Dispose();
    }
}
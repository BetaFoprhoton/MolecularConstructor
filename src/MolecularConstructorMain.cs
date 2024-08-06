using MolecularConstructor.silk;
using Python.Runtime;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace MolecularConstructor;

public class MolecularConstructorMain {
    public static void Main() {
        Runtime.PythonDLL = Environment.CurrentDirectory.Replace(@"bin\Debug\net8.0", @"src\venv\python312.dll");
        PythonEngine.Initialize();
        var window = new RenderWindow(800, 600, "Molecular Constructor");
        window.Run();
        window.Dispose();
    }

}
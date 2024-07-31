using MolecularConstructor.silk;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace MolecularConstructor {
    class MolecularConstructorMain {
        public virtual void Main(string[] args) {
            var window = new RenderWindow(800, 600, "Molecular Constructor");
            window.Run();
            window.Dispose();
        }
    }
}
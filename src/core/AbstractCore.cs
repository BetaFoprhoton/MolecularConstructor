using Silk.NET.OpenGL;

namespace MolecularConstructor.core;

public abstract class AbstractCore {

    public AbstractCore() {
        Init();
    }
    
    public abstract void Init();
    public abstract MoleResult Tick();

    public abstract class MoleResult {
        
    }
}

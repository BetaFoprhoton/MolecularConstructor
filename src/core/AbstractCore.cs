using Silk.NET.OpenGL;

namespace RealismConstructor.core;

public abstract class AbstractCore {

    public AbstractCore() {
        Init();
    }
    
    public abstract void Init();
    public abstract MoleResult Tick();

    public abstract class MoleResult {
        
    }
}

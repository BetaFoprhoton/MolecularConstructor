using System.Numerics;

namespace MolecularConstructor.render;

public class FreeCamera {
    private Vector3 CameraPosition = new(0.0f, 0.0f, 3.0f);
    private Vector3 CameraFront = new(0.0f, 0.0f, -1.0f);
    private Vector3 CameraUp = Vector3.UnitY;
    private Vector3 CameraDirection = Vector3.Zero;
    private float CameraYaw = -90f;
    private float CameraPitch = 0f;
    private float CameraZoom = 45f;
    
    private Vector2 LastMousePosition;
    
    
}
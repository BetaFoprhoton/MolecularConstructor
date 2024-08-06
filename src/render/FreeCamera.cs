using System.Numerics;
using Silk.NET.Input;
using Silk.NET.Windowing;

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
    private IKeyboard primaryKeyboard;

    public FreeCamera(IWindow window) {
        window.Initialize();
        var input = window.CreateInput();
        primaryKeyboard = input.Keyboards.FirstOrDefault();
        
        for (int i = 0; i < input.Mice.Count; i++) {
            input.Mice[i].Cursor.CursorMode = CursorMode.Raw;
            input.Mice[i].MouseMove += ProcessMouseMove;
            input.Mice[i].Scroll += ProcessMouseWheel;
        }
    }

    private void ProcessMovement(double δtime) {
        var moveSpeed = 2.5f * (float) δtime;
        
        if (primaryKeyboard.IsKeyPressed(Key.W)) {
            CameraPosition += moveSpeed * CameraFront;
        }
        if (primaryKeyboard.IsKeyPressed(Key.S)) {
            CameraPosition -= moveSpeed * CameraFront;
        }
        if (primaryKeyboard.IsKeyPressed(Key.A)) {
            CameraPosition -= Vector3.Normalize(Vector3.Cross(CameraFront, CameraUp)) * moveSpeed;
        }
        if (primaryKeyboard.IsKeyPressed(Key.D)) {
            CameraPosition += Vector3.Normalize(Vector3.Cross(CameraFront, CameraUp)) * moveSpeed;
        }
    }
    
    private void ProcessMouseMove(IMouse mouse, Vector2 position) {
        var lookSensitivity = 0.1f;
        if (LastMousePosition == default) { LastMousePosition = position; }
        else {
            var xOffset = (position.X - LastMousePosition.X) * lookSensitivity;
            var yOffset = (position.Y - LastMousePosition.Y) * lookSensitivity;
            LastMousePosition = position;

            CameraYaw += xOffset;
            CameraPitch -= yOffset;
            
            CameraPitch = Math.Clamp(CameraPitch, -89.0f, 89.0f);

            CameraDirection.X = MathF.Cos(MathHelper.DegreesToRadians(CameraYaw)) * MathF.Cos(MathHelper.DegreesToRadians(CameraPitch));
            CameraDirection.Y = MathF.Sin(MathHelper.DegreesToRadians(CameraPitch));
            CameraDirection.Z = MathF.Sin(MathHelper.DegreesToRadians(CameraYaw)) * MathF.Cos(MathHelper.DegreesToRadians(CameraPitch));
            CameraFront = Vector3.Normalize(CameraDirection);
        }
    }
    
    private void ProcessMouseWheel(IMouse mouse, ScrollWheel scrollWheel) {
        //We don't want to be able to zoom in too close or too far away so clamp to these values
        CameraZoom = Math.Clamp(CameraZoom - scrollWheel.Y, 1.0f, 45f);
    }
}
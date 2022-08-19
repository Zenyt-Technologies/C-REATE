using Raylib_cs;
using rlImGui_cs;
using ImGuiNET;

namespace project_create
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1280, 720, "C-REATE");

            rlImGui.

            while (!Raylib.WindowShouldClose())
            {
                Raylib.ClearBackground(Color.WHITE);
                
                Raylib.BeginDrawing();
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
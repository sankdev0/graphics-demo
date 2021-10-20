using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace OpenTK
{
    class MainWindow : GameWindow
    {
        public MainWindow(string title, int w, int h)
        {
            Title = title;
            Width = w;
            Height = h;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color4.Gray);

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);


            GL.Begin(BeginMode.Quads);
            GL.Color3(System.Drawing.Color.FromArgb(139, 69, 19));
            GL.Vertex3(-0.5, -0.9, 0);
            GL.Vertex3(-0.5, 0.4, 0);
            GL.Vertex3(0.5, 0.4, 0);
            GL.Vertex3(0.5, -0.9, 0);
            GL.End();


            GL.Begin(BeginMode.TriangleStrip);
            GL.Color3(System.Drawing.Color.FromArgb(222, 36, 5));
            GL.Vertex3(-0.5, 0.42, 0);
            GL.Vertex3(-0.5, 0.7, 0);
            GL.Vertex3(-0.25, 0.42, 0);
            GL.Vertex3(-0.25, 0.7, 0);
            GL.End();


            GL.Begin(BeginMode.Triangles);
            GL.Color3(System.Drawing.Color.FromArgb(222, 0, 134));
            GL.Vertex3(0.27, 0.42, 0);
            GL.Vertex3(0.5, 0.68, 0);
            GL.Vertex3(0.5, 0.42, 0);
            GL.End();


            GL.Begin(BeginMode.Triangles);
            GL.Color3(System.Drawing.Color.FromArgb(222, 0, 134));
            GL.Vertex3(0.25, 0.42, 0);
            GL.Vertex3(0.5, 0.7, 0);
            GL.Vertex3(0.25, 0.7, 0);
            GL.End();


            GL.Begin(BeginMode.TriangleFan);
            GL.Color3(System.Drawing.Color.FromArgb(255, 180, 0));
            GL.Vertex3(-0.375, 0.9, 0);
            GL.Vertex3(-0.5, 0.72, 0);
            GL.Vertex3(-0.458, 0.72, 0);
            GL.Vertex3(-0.375, 0.72, 0);
            GL.Vertex3(-0.292, 0.72, 0);
            GL.Vertex3(-0.25, 0.72, 0);
            GL.End();

            GL.Begin(BeginMode.TriangleFan);
            GL.Color3(System.Drawing.Color.FromArgb(255, 180, 0));
            GL.Vertex3(0.375, 0.9, 0);
            GL.Vertex3(0.5, 0.72, 0);
            GL.Vertex3(0.458, 0.72, 0);
            GL.Vertex3(0.375, 0.72, 0);
            GL.Vertex3(0.292, 0.72, 0);
            GL.Vertex3(0.25, 0.72, 0);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Color3(System.Drawing.Color.FromArgb(148, 255, 231));

            GL.Vertex3(-0.1, 0.42, 0);
            GL.Vertex3(0.1, 0.42, 0);
            GL.Vertex3(0.1, 0.7, 0);
            GL.Vertex3(0, 0.8, 0);
            GL.Vertex3(-0.1, 0.7, 0);
            GL.End();

            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(System.Drawing.Color.FromArgb(90, 0, 247));
            GL.Vertex3(-0.2, 0.2, 0);
            GL.Vertex3(-0.2, -0.1, 0);
            GL.Vertex3(-0.1, 0.1, 0);
            GL.Vertex3(-0.1, -0.2, 0);
            GL.Vertex3(0.1, 0.1, 0);
            GL.Vertex3(0.1, -0.2, 0);
            GL.End();


            ///////////////////////Контуры фигур///////////////////////////////

            GL.PolygonMode(MaterialFace.Back, PolygonMode.Line);
            GL.LineWidth(4);


            GL.Begin(BeginMode.TriangleStrip);
            GL.Color3(System.Drawing.Color.FromArgb(0, 0, 0));

            GL.Vertex3(-0.5, 0.42, 0);
            GL.Vertex3(-0.5, 0.7, 0);
            GL.Vertex3(-0.25, 0.42, 0);
            GL.Vertex3(-0.25, 0.7, 0);
            GL.End();

            GL.Begin(BeginMode.Triangles);
            GL.Vertex3(0.27, 0.42, 0);
            GL.Vertex3(0.5, 0.68, 0);
            GL.Vertex3(0.5, 0.42, 0);
            GL.End();

            GL.Begin(BeginMode.Triangles);
            GL.Vertex3(0.25, 0.42, 0);
            GL.Vertex3(0.25, 0.7, 0);
            GL.Vertex3(0.5, 0.7, 0);
            GL.End();

            GL.Begin(BeginMode.TriangleFan);
            GL.Vertex3(-0.375, 0.9, 0);
            GL.Vertex3(-0.25, 0.72, 0);
            GL.Vertex3(-0.292, 0.72, 0);
            GL.Vertex3(-0.375, 0.72, 0);
            GL.Vertex3(-0.458, 0.72, 0);
            GL.Vertex3(-0.5, 0.72, 0);
            GL.End();

            GL.Begin(BeginMode.TriangleFan);
            GL.Vertex3(0.375, 0.9, 0);
            GL.Vertex3(0.5, 0.72, 0);
            GL.Vertex3(0.458, 0.72, 0);
            GL.Vertex3(0.375, 0.72, 0);
            GL.Vertex3(0.292, 0.72, 0);
            GL.Vertex3(0.25, 0.72, 0);
            GL.End();

            GL.Begin(BeginMode.Quads);
            GL.Vertex3(-0.5, -0.9, 0);
            GL.Vertex3(-0.5, 0.4, 0);
            GL.Vertex3(0.5, 0.4, 0);
            GL.Vertex3(0.5, -0.9, 0);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-0.1, 0.42, 0);
            GL.Vertex3(-0.1, 0.7, 0);
            GL.Vertex3(0, 0.8, 0);
            GL.Vertex3(0.1, 0.7, 0);
            GL.Vertex3(0.1, 0.42, 0);
            GL.End();

            GL.PolygonMode(MaterialFace.Front, PolygonMode.Line);


            GL.Begin(BeginMode.QuadStrip);
            GL.Vertex3(0.1, -0.2, 0);
            GL.Vertex3(0.1, 0.1, 0);
            GL.Vertex3(-0.1, -0.2, 0);
            GL.Vertex3(-0.1, 0.1, 0);
            GL.Vertex3(-0.2, -0.1, 0);
            GL.Vertex3(-0.2, 0.2, 0);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.15, -0.37, 0);
            GL.Vertex3(-0.28, -0.41, 0);
            GL.Vertex3(-0.36, -0.6, 0);
            GL.Vertex3(-0.25, -0.68, 0);
            GL.End();

            GL.Begin(BeginMode.Lines);
            GL.Vertex3(-0.08, -0.41, 0);
            GL.Vertex3(0.11, -0.37, 0);
            GL.End();

            GL.Begin(BeginMode.Lines);
            GL.Vertex3(-0.05, -0.37, 0);
            GL.Vertex3(-0.05, -0.68, 0);
            GL.End();

            GL.Begin(BeginMode.LineStrip);
            GL.Vertex3(0.2, -0.68, 0);
            GL.Vertex3(0.4, -0.37, 0);
            GL.Vertex3(0.2, -0.42, 0);
            GL.Vertex3(0.35, -0.57, 0);
            GL.End();

            GL.PointSize(4);

            GL.Begin(BeginMode.Points);
            GL.Vertex3(0.4, -0.68, 0);
            GL.End();

            SwapBuffers();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            this.Exit();
        }
    }
}

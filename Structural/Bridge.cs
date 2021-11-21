/*Le pont est un patron de conception qui permet de découpler 
 * l'interface d'une classe et son implémentation. 
 * Ainsi l'interface et l'implémentation peuvent varier séparément.
 * */

using System;

namespace DesignPatternImplementation.Structural
{
    public interface IDrawingAPI
    {
        public void DrawCircle(double x, double y, double radius);
    }

    public class DrawingAPI2D : IDrawingAPI
    {
        void IDrawingAPI.DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("API2D.circle pos " + x + ":" + y + " rad " + radius);
        }
    }

    public class DrawingAPI2DIso : IDrawingAPI
    {
        void IDrawingAPI.DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("API2DIso.circle pos " + x + ":" + y + " rad " + radius);
        }
    }

    public interface IShape
    {
        public void Draw();
        public void ResizeByPercentage(double pct);
    }

    public class CircleShape : IShape
    {
        private double x, y, radius;
        private IDrawingAPI drawingAPI;

        public CircleShape(double x, double y, double radius, IDrawingAPI drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.drawingAPI = drawingAPI;
        }

        void IShape.Draw()
        {
            drawingAPI.DrawCircle(x, y, radius);
        }

        void IShape.ResizeByPercentage(double pct)
        {
            radius *= pct;
        }
    }
}

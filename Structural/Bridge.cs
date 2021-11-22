/* Le pont est un patron de conception qui permet de découpler 
 * l'interface d'une classe et son implémentation. 
 * Ainsi l'interface et l'implémentation peuvent varier séparément.
 */

/* Le Pont est un patron de conception structurel qui permet de 
 * séparer une grosse classe ou un ensemble de classes connexes en 
 * deux hiérarchies — abstraction et implémentation — qui peuvent 
 * évoluer indépendamment l’une de l’autre.
 * 
 * Complexité 3/3
 * Popularité 1/3
 * 
 * Le patron de conception pont est très utile pour gérer les 
 * applications multiplateformes, prendre en charge différents 
 * types de serveurs de bases de données ou travailler avec plusieurs 
 * fournisseurs d’API d’un certain genre (par exemple les plateformes 
 * de cloud, réseaux sociaux, etc.).
 */

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

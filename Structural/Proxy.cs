/*Un proxy est une classe se substituant à une autre classe. 
 * Par convention et simplicité, le proxy implémente la même 
 * interface que la classe à laquelle il se substitue. 
 * L'utilisation de ce proxy ajoute une indirection à 
 * l'utilisation de la classe à substituer. Le proxy 
 * sert à gérer l'accès à un objet, il agit comme un 
 * intermédiaire entre la classe utilisatrice et l'objet.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternImplementation.Structural.Proxy
{
    public interface IImage
    {
        public void DisplayImage();
    }

    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadImageFromDisk();
        }

        private void loadImageFromDisk()
        {
            Console.WriteLine(fileName + " loaded !");
        }

        void IImage.DisplayImage()
        {
            Console.WriteLine(fileName + " displayed !");
        }
    }

    public class ProxyImage : IImage
    {
        private string fileName;
        private IImage image;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void DisplayImage()
        {
            if (image == null)
            {
                image = new RealImage(fileName);
            }
            image.DisplayImage();
        }
    }
}

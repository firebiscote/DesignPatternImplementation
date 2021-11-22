/*La technique de l'État est un patron de conception comportemental 
 * utilisé en génie logiciel. Ce patron de conception est utilisé 
 * entre autres lorsqu'il est souhaité pouvoir changer le comportement 
 * de l'État d'un objet sans pour autant en changer l'instance.
 */

using System;

namespace DesignPatternImplementation.Behavior.State
{
    public interface ITool
    {
        public void Draw();
    }

    public class DogDrawer : ITool
    {
        void ITool.Draw()
        {
            Console.WriteLine("Dog");
        }
    }

    public class CatDrawer : ITool
    {
        void ITool.Draw()
        {
            Console.WriteLine("Cat");
        }
    }

    public class ToolController
    {
        private ITool currentTool;

        public ToolController() 
        {
            SelectDogDrawer();
        }

        public void Draw()
        {
            currentTool.Draw();
        }

        public void SelectDogDrawer()
        {
            this.currentTool = new DogDrawer();
        }

        public void SelectCatDrawer()
        {
            this.currentTool = new CatDrawer();
        }
    }
}

/* Un patron de méthode définit le squelette d'un algorithme à l'aide 
 * d'opérations abstraites dont le comportement concret se trouvera 
 * dans les sous-classes, qui implémenteront ces opérations.
 */

/* L’Adaptateur est un patron de conception structurel qui 
 * permet de faire collaborer des objets ayant des 
 * interfaces normalement incompatibles.
 * 
 * Complexité 1/3
 * Popularité 3/3
 * 
 * L’adaptateur est très répandu en C#. On le retrouve 
 * souvent dans des systèmes basés sur du code hérité, 
 * dans lesquels l’adaptateur fait fonctionner du code 
 * hérité avec des classes modernes.
 */

using System;

namespace DesignPatternImplementation.Behavior.TemplateMethod
{
    public abstract class Game
    {
        protected int playerNumber;

        public abstract void InitGame();
        public abstract void DoGame(int player);
        public abstract bool GameEnd();
        public abstract void ShowWinner();

        public void PlayAGame(int playerNumber)
        {
            this.playerNumber = playerNumber;
            InitGame();
            int player = 0;
            while (!GameEnd())
            {
                DoGame(player);
                player++;
                player %= playerNumber;
            }
            ShowWinner();
        }
    }

    public class Monopoly : Game
    {
        public override void InitGame()
        {
            throw new NotImplementedException();
        }

        public override void DoGame(int player)
        {
            throw new NotImplementedException();
        }

        public override bool GameEnd()
        {
            throw new NotImplementedException();
        }

        public override void ShowWinner()
        {
            throw new NotImplementedException();
        }
    }
}

/*Un patron de méthode définit le squelette d'un algorithme à l'aide 
 * d'opérations abstraites dont le comportement concret se trouvera 
 * dans les sous-classes, qui implémenteront ces opérations.
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

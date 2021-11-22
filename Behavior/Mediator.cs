/* Le patron de conception Médiateur fournit une interface 
 * unifiée pour un ensemble d'interfaces d'un sous-système. 
 * Il est utilisé pour réduire les dépendances entre plusieurs 
 * classes.
 */

/* Médiateur est un patron de conception comportemental qui diminue 
 * les dépendances chaotiques entre les objets. Il restreint les 
 * communications directes entre les objets et les force à collaborer 
 * uniquement via un objet médiateur.
 * 
 * Complexité 2/3
 * Popularité 2/3
 * 
 * Le médiateur est le plus souvent utilisé en C# pour faciliter les 
 * communications entre les composants de l’interface graphique d’une 
 * application. Le contrôleur du modèle MVC est le synonyme du médiateur.
 */

using System;

namespace DesignPatternImplementation.Behavior.Mediator
{
    public interface ICommand
    {
        public void Execute();
    }

    public class Mediator
    {
        public ButtonView BtnView;
        public ButtonSearch BtnSearch;
        public ButtonBook BtnBook;
        public LabelDisplay LblDisplay;

        public void RegisterView(ButtonView buttonView)
        {
            this.BtnView = buttonView;
        }

        public void RegisterSearch(ButtonSearch buttonSearch)
        {
            this.BtnSearch = buttonSearch;
        }

        public void RegisterBook(ButtonBook buttonBook)
        {
            this.BtnBook = buttonBook;
        }

        public void RegisterDisplay(LabelDisplay labelDisplay)
        {
            this.LblDisplay = labelDisplay;
        }

        public void Book()
        {
            BtnBook.SetEnabled(false);
            BtnView.SetEnabled(true);
            BtnSearch.SetEnabled(true);
            LblDisplay.SetText("Booking...");
        }

        public void View()
        {
            BtnBook.SetEnabled(true);
            BtnView.SetEnabled(false);
            BtnSearch.SetEnabled(true);
            LblDisplay.SetText("Viewing...");
        }

        public void Search()
        {
            BtnBook.SetEnabled(true);
            BtnView.SetEnabled(true);
            BtnSearch.SetEnabled(false);
            LblDisplay.SetText("Searching...");
        }
    }

    public abstract class Button
    {
        private bool enabled;

        public void SetEnabled(bool enabled)
        {
            this.enabled = enabled;
        }
    }

    public class ButtonView : Button, ICommand
    {
        private Mediator mediator;

        public ButtonView(Action action, Mediator mediator)
        {
            this.mediator = mediator;
            mediator.RegisterView(this);
        }

        public void Execute()
        {
            mediator.View();
        }
    }

    public class ButtonBook : Button, ICommand
    {
        private Mediator mediator;

        public ButtonBook(Action action, Mediator mediator)
        {
            this.mediator = mediator;
            mediator.RegisterBook(this);
        }

        public void Execute()
        {
            mediator.Book();
        }
    }

    public class ButtonSearch : Button, ICommand
    {
        private Mediator mediator;

        public ButtonSearch(Action action, Mediator mediator)
        {
            this.mediator = mediator;
            mediator.RegisterSearch(this);
        }

        public void Execute()
        {
            mediator.Search();
        }
    }

    public abstract class Display
    {
        private string text;

        public void SetText(string text)
        {
            this.text = text;
        }
    }

    public class LabelDisplay : Display
    {
        private Mediator mediator;

        public LabelDisplay(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}

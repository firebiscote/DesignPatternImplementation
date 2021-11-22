/* Le patron de conception Médiateur fournit une interface 
 * unifiée pour un ensemble d'interfaces d'un sous-système. 
 * Il est utilisé pour réduire les dépendances entre plusieurs 
 * classes.
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

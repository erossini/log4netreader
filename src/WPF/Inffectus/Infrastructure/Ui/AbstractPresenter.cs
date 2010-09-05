using System;
using System.Windows;
using System.Windows.Threading;

namespace Inffectus.Infrastructure.Ui
{
    public abstract class AbstractPresenter<TModel, TView> : IDisposable, IPresenter
        where TView : Window, new()
    {
        private TModel model;

        protected AbstractPresenter()
        {
            View = new TView();
            View.Closed += (sender, args) => Dispose();
        }

        protected TView View { get; set; }


        protected TModel Model
        {
            get { return model; }
            set
            {
                model = value;
                View.DataContext = model;
            }
        }

        #region IDisposable Members

        public virtual void Dispose()
        {
            View.Close();
            Disposed();
        }

        #endregion

        #region IPresenter Members

        DependencyObject IPresenter.View
        {
            get { return View; }
        }

        public object Result { get; protected set; }

        public Dispatcher ViewDispatcher
        {
            get { return View.Dispatcher; }
        }


        public void Show()
        {
            View.Show();
        }

        public void ShowDialog()
        {
            View.ShowDialog();
        }

        public event Action Disposed = delegate { };

        #endregion

        public void SetViewModel(TModel themodel)
        {
            Model = themodel;
        }
    }
}
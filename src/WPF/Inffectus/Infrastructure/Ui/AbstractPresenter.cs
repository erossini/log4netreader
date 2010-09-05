using System;
using System.Windows;

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

        internal TView View { get; set; }


        internal TModel Model
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
    }
}
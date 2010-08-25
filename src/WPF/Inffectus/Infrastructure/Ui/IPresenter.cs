using System;
using System.Windows;

namespace Inffectus.Infrastructure.Ui
{
    public interface IPresenter
	{
		DependencyObject View { get; }
		void Show();
		object Result{ get;}
		event Action Disposed;
		void ShowDialog();
	}
}
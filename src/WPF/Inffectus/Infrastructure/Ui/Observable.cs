using System.ComponentModel;

namespace Inffectus.Infrastructure.Ui
{
    public class Observable<T> : INotifyPropertyChanged
	{
		private T value;

		public Observable()
		{
			
		}

		public Observable(T value)
		{
			this.value = value;
		}

		public T Value
		{
			get{ return value;}
			set
			{
				this.value = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Value"));
			}
		}

		public static implicit operator T(Observable<T> val)
		{
			return val.value;
		}


		public event PropertyChangedEventHandler PropertyChanged = delegate { };
	}
}
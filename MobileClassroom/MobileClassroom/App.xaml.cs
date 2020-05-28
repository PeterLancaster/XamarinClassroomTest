using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileClassroom
{
	public partial class App : Application
	{
		#region Public Constructors

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		#endregion Public Constructors

		#region Protected Methods

		protected override void OnResume()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnStart()
		{
		}

		#endregion Protected Methods
	}
}
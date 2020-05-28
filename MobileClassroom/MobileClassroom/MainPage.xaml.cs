using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileClassroom
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		#region Public Constructors

		public MainPage()
		{
			InitializeComponent();
		}

		#endregion Public Constructors

		#region Private Methods

		private void Button_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage.Navigation.PushAsync(new ClassroomWebView());
		}

		#endregion Private Methods
	}
}
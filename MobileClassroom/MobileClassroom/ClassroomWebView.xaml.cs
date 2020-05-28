using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileClassroom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClassroomWebView : ContentPage
	{
		#region Public Fields

		public string sourceUrl = @"https://qa-classroom.princetonreview.com/?room=classroomcheckin101&r=2&T20=1";

		#endregion Public Fields

		#region Public Constructors

		public ClassroomWebView()
		{
			InitializeComponent();

			webView.Source = sourceUrl;
		}

		#endregion Public Constructors

		#region Public Methods

		public async Task<PermissionStatus> CheckAndRequestAVCapturePermission()
		{
			var status = await Permissions.CheckStatusAsync<AVCapturePermission>();
			if (status != PermissionStatus.Granted)
			{
				status = await Permissions.RequestAsync<AVCapturePermission>();
			}

			// Additionally could prompt the user to turn on in settings

			return status;
		}

		public async Task<PermissionStatus> CheckAndRequestCameraPermission()
		{
			var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
			if (status != PermissionStatus.Granted)
			{
				status = await Permissions.RequestAsync<Permissions.Camera>();
			}

			// Additionally could prompt the user to turn on in settings

			return status;
		}

		public async Task<PermissionStatus> CheckAndRequestMicrophonePermission()
		{
			var status = await Permissions.CheckStatusAsync<Permissions.Microphone>();
			if (status != PermissionStatus.Granted)
			{
				status = await Permissions.RequestAsync<Permissions.Microphone>();
			}

			// Additionally could prompt the user to turn on in settings

			return status;
		}

		#endregion Public Methods

		#region Protected Methods

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await CheckAndRequestCameraPermission();
			await CheckAndRequestMicrophonePermission();
			await CheckAndRequestAVCapturePermission();
		}

		#endregion Protected Methods
	}
}
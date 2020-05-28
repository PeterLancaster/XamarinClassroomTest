using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MobileClassroom.Droid
{
	public partial class AVCapturePermission : Xamarin.Essentials.Permissions.BasePlatformPermission
	{
		#region Public Properties

		public override (string androidPermission, bool isRuntime)[] RequiredPermissions => new List<(string androidPermission, bool isRuntime)>
	{
		(Android.Manifest.Permission.CaptureAudioOutput, true),
		(Android.Manifest.Permission.CaptureVideoOutput, true),
		(Android.Webkit.PermissionRequest.ResourceAudioCapture, true),
		(Android.Webkit.PermissionRequest.ResourceVideoCapture, true)
	}.ToArray();

		#endregion Public Properties
	}
}
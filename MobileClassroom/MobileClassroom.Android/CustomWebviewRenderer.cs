using Android.Annotation;
using Android.App;
using Android.Content;
using Android.Webkit;
using MobileClassroom.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MobileClassroom.MyWebView), typeof(CustomWebViewRenderer))]

namespace MobileClassroom.Droid
{
	public class CustomWebViewRenderer : WebViewRenderer
	{
		#region Private Fields

		private Activity mContext;

		#endregion Private Fields

		#region Public Constructors

		public CustomWebViewRenderer(Context context) : base(context)
		{
			this.mContext = context as Activity;
		}

		#endregion Public Constructors

		#region Protected Methods

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
		{
			base.OnElementChanged(e);
			Control.Settings.JavaScriptEnabled = true;
			Control.ClearCache(true);
			Control.SetWebChromeClient(new MyWebClient(mContext));
		}

		#endregion Protected Methods

		#region Public Classes

		public class MyWebClient : WebChromeClient
		{
			#region Private Fields

			private Activity mContext;

			#endregion Private Fields

			#region Public Constructors

			public MyWebClient(Activity context)
			{
				this.mContext = context;
			}

			#endregion Public Constructors

			#region Public Methods

			[TargetApi(Value = 21)]
			public override void OnPermissionRequest(PermissionRequest request)
			{
				mContext.RunOnUiThread(() =>
				{
					request.Grant(request.GetResources());
				});
			}

			#endregion Public Methods
		}

		#endregion Public Classes
	}
}
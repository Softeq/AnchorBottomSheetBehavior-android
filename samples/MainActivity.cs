using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.ConstraintLayout.Widget;
using Com.Trafi.Anchorbottomsheetbehavior;

namespace AnchorBottomSheetBehaviorSamples;

[Activity(
    Label = "@string/app_name",
    Theme = "@style/AppTheme.NoActionBar",
    MainLauncher = true)]
public class MainActivity : AppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        ConstraintLayout constraintLayout = FindViewById<ConstraintLayout>(Resource.Id.bottomSheet);
        AnchorBottomSheetBehavior behavior = AnchorBottomSheetBehavior.From(constraintLayout);

        int hPx = Resources.DisplayMetrics.HeightPixels;
        float cardAnchorSizeDp = 270 + 20;
        float cardAnchorSizePx = PxFromDp(this, cardAnchorSizeDp);

        int anchor = hPx - (int)cardAnchorSizePx;

        behavior.AnchorOffset = anchor;
    }

    public static float DpFromPx(Context context, float px)
    {
        return px / context.Resources.DisplayMetrics.Density;
    }

    public static float PxFromDp(Context context, float dp)
    {
        return dp * context.Resources.DisplayMetrics.Density;
    }
}

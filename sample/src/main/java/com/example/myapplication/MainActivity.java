package com.example.myapplication;

import android.content.Context;
import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import com.softeq.bottomsheet.AnchorBottomSheetBehavior;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ConstraintLayout constraintLayout = this.findViewById(R.id.bottomSheet);
        AnchorBottomSheetBehavior behavior = AnchorBottomSheetBehavior.from(constraintLayout);

        int hPx = getResources().getDisplayMetrics().heightPixels;
        float cardAnchorSizeDp = 270 + 20;
        float cardAnchorSizePx = pxFromDp(this, cardAnchorSizeDp);

        int anchor = hPx - (int) cardAnchorSizePx;

        behavior.setAnchorOffset(anchor);
    }

    public static float dpFromPx(final Context context, final float px) {
        return px / context.getResources().getDisplayMetrics().density;
    }

    public static float pxFromDp(final Context context, final float dp) {
        return dp * context.getResources().getDisplayMetrics().density;
    }
}
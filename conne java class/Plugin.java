package com.lop.conne;



import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

public class Plugin extends Activity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        receiveIntent();
        passIntent();
    }

    protected void receiveIntent() {
        Intent i = getIntent();
        String type = i.getType();
        if ("text/plain".equals(type)) {
            String GetMessage = i.getStringExtra(Intent.EXTRA_TEXT);
            Log.d("Message tag", GetMessage);


        }
    }

    
}

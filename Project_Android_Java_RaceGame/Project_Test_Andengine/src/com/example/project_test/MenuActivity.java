package com.example.project_test;

import org.anddev.andengine.audio.sound.Sound;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ImageButton;

public class MenuActivity extends Activity{
	
	private ImageButton btnPlay;
	private ImageButton btnExit;
	private Context mContext = MenuActivity.this;
	private BackgroundMusic mBackGroundMusic;	
	private SoundEffect mSoundEffect = new SoundEffect(mContext);

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		mBackGroundMusic = new BackgroundMusic();
		mBackGroundMusic.execute(new Context[]{this});
		
		btnPlay = (ImageButton) findViewById(R.id.btn_play);
		btnExit = (ImageButton) findViewById(R.id.btn_exit);
		
		btnPlay.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
		    	Intent i = new Intent(getApplicationContext(),MainActivity.class);
		    	startActivity(i);	
		    	//mSoundEffect.play(Constant.MUSIC_CAR_TURBO);
			}
		});
		
		btnExit.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				finish();
				System.exit(0);
			}
		});
	}

}

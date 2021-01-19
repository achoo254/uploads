package com.example.project_test;

import android.content.Context;
import android.media.MediaPlayer;
import android.os.AsyncTask;

public class BackgroundMusic extends AsyncTask<Context, Void, Void>{
	
	private MediaPlayer player;

	@Override
	protected Void doInBackground(Context... params) {
		// TODO Auto-generated method stub
		player = MediaPlayer.create(params[0], Constant.MUSIC_BACKGROUND);
		player.setLooping(true);
		player.start();
		return null;
	}

	public void stop(){
		player.stop();
	}

}

package com.example.project_test;

import android.content.Context;
import android.media.AudioManager;
import android.media.SoundPool;
import android.media.SoundPool.OnLoadCompleteListener;

public class SoundEffect {
	int[] arrIntSoundID;
	private Context mContext;
	private SoundPool mSoundPool;
	private float leftVolume = 1.0f;
	private float rightVolume = 1.0f;
	private float rate = 1.0f;
	
	public SoundEffect(Context paraContext){
		mSoundPool = new SoundPool(Constant.MAX_EFFECT, AudioManager.STREAM_MUSIC, 100);
		mContext = paraContext;
		arrIntSoundID = new int[Constant.MAX_EFFECT];
		initArrIntSoundID();
	}

	private void initArrIntSoundID() {
		// TODO Auto-generated method stub
		for (int i = 0; i < arrIntSoundID.length; i++) {
			arrIntSoundID[i] = -1;
		}
	}
	
	public int load(int sound_id){
		return mSoundPool.load(mContext, sound_id, 1);
	}
	
	public void play(int sound_id){
		 final int soundId = mSoundPool.load(mContext, sound_id, 1); // in 2nd param u have to pass your desire ringtone
		 mSoundPool.setOnLoadCompleteListener(new OnLoadCompleteListener() {
			
			@Override
			public void onLoadComplete(SoundPool soundPool, int sampleId, int status) {
				// TODO Auto-generated method stub
				mSoundPool.play(soundId, leftVolume, rightVolume, 1, 1, rate);
			}
		});
	}
	
	public void ReleaseAll(){
		mSoundPool.release();
	}
}


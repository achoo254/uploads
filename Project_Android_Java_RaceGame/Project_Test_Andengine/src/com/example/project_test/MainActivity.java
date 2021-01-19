package com.example.project_test;

import java.util.ArrayList;

import javax.microedition.khronos.opengles.GL10;

import org.anddev.andengine.audio.sound.Sound;
import org.anddev.andengine.engine.Engine;
import org.anddev.andengine.engine.camera.BoundCamera;
import org.anddev.andengine.engine.camera.hud.controls.AnalogOnScreenControl;
import org.anddev.andengine.engine.handler.IUpdateHandler;
import org.anddev.andengine.engine.handler.physics.PhysicsHandler;
import org.anddev.andengine.engine.options.EngineOptions;
import org.anddev.andengine.engine.options.EngineOptions.ScreenOrientation;
import org.anddev.andengine.engine.options.resolutionpolicy.RatioResolutionPolicy;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXLayer;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTiledMap;
import org.anddev.andengine.entity.modifier.AlphaModifier;
import org.anddev.andengine.entity.scene.Scene;
import org.anddev.andengine.entity.scene.Scene.IOnSceneTouchListener;
import org.anddev.andengine.entity.scene.background.ColorBackground;
import org.anddev.andengine.entity.sprite.AnimatedSprite;
import org.anddev.andengine.entity.text.ChangeableText;
import org.anddev.andengine.entity.text.Text;
import org.anddev.andengine.entity.util.FPSLogger;
import org.anddev.andengine.input.touch.TouchEvent;
import org.anddev.andengine.opengl.font.Font;
import org.anddev.andengine.opengl.texture.TextureOptions;
import org.anddev.andengine.opengl.texture.atlas.bitmap.BitmapTextureAtlas;
import org.anddev.andengine.opengl.texture.atlas.bitmap.BitmapTextureAtlasTextureRegionFactory;
import org.anddev.andengine.opengl.texture.region.TextureRegion;
import org.anddev.andengine.opengl.texture.region.TiledTextureRegion;
import org.anddev.andengine.ui.activity.BaseGameActivity;

import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.os.CountDownTimer;

public class MainActivity extends BaseGameActivity {

	private static final int CAMERA_WIDTH = 800;
	private static final int CAMERA_HEIGHT = 480;

	private BoundCamera mCamera;
	private Scene mScene;

	// Xu ly ban do
	private TMXTiledMap mTMXTiledMap;
	private TMXLayer VatCanTMXLayer;
	private TMXLayer CayCoiTMXLayer;
	private TMXLayer NenCoTMXLayer;
	private TMXLayer ChamMoc1TMXLayer;
	private TMXLayer ChamMoc2TMXLayer;
	private TMXLayer ChamMoc3TMXLayer;
	private TMXLayer ChamMoc4TMXLayer;
	private static TMXLayer tmxLayer;
	private String strBando = "map_test5.tmx";

	// Tao nhan vat di chuyen
	private BitmapTextureAtlas mCharacterTexture;
	private TiledTextureRegion mHeroTiledTextureRegion;
	private AnimatedSprite mHeroAnimatedSprite;
	// ket thuc

	// Tao control
	private BitmapTextureAtlas mControlBaseTexture;
	private BitmapTextureAtlas mControlKnobTexture;
	private TextureRegion mScreenControlBaseTextureRegion;
	private TextureRegion mScreenControlKnobTextureRegion;
	// private DigitalOnScreenControl mDigitalOnScreenControl;
	private AnalogOnScreenControl mDigitalOnScreenControl;

	// Tao score
	private BitmapTextureAtlas mTextTexture;
	private BitmapTextureAtlas mRetryTexture;
	private BitmapTextureAtlas mScoreTexture;
	private BitmapTextureAtlas mRestartTexture;
	private Font mText;
	private Font mRetry;
	private Font mScore;
	private Font mRestart;
	// Ket thuc

	// Tao bot car
	private static final float speedBot = 200.0f;
	private BitmapTextureAtlas mBotTexture;
	private TiledTextureRegion mBotTiledTextureRegion;
	private static BotCar bot;
	private static BotCar bot2;
	private static BotCar bot3;
	// Ket thuc
	
	//Kiem tra game over
	private boolean gameOver = true;
	//Ket thuc
	
	//Tao bien dem thoi gian
	private long demNguoc = 61; // seconds
	private long boDem = 61;
	//Ket thuc
	
	//Nhac nen va tieng hieu ung
	private Context mContext;
	private BackgroundMusic mBackGroundMusic;
	private SoundEffect mSoundEffect;
	private Sound mSound;
	//Ket thuc

	@Override
	public Engine onLoadEngine() {
		// TODO Auto-generated method stub
		// final Display defaultDisplay =
		// getWindow().getWindowManager().getDefaultDisplay();
		// CAMERA_WIDTH = defaultDisplay.getWidth();
		// CAMERA_HEIGHT = defaultDisplay.getHeight();

		mCamera = new BoundCamera(0, 0, CAMERA_WIDTH, CAMERA_HEIGHT);
		final EngineOptions engineOptions = new EngineOptions(true,
				ScreenOrientation.LANDSCAPE, new RatioResolutionPolicy(
						CAMERA_WIDTH, CAMERA_HEIGHT), mCamera);

		engineOptions.getTouchOptions().setRunOnUpdateThread(true);
		
		return new Engine(engineOptions);
	}

	@Override
	public void onLoadResources() {
		// TODO Auto-generated method stub
		// mBitmapTextureAtlas = new BitmapTextureAtlas(512, 512,
		// TextureOptions.BILINEAR);

		// Load nhan vat
		mCharacterTexture = new BitmapTextureAtlas(64, 64,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);

		mHeroTiledTextureRegion = BitmapTextureAtlasTextureRegionFactory
				.createTiledFromAsset(mCharacterTexture, this, "car.png", 0, 0,
						1, 1);

		mEngine.getTextureManager().loadTexture(mCharacterTexture);
		// Ket thuc

		// Load control
		mControlBaseTexture = new BitmapTextureAtlas(256, 256,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);

		mControlKnobTexture = new BitmapTextureAtlas(256, 256,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);

		mScreenControlBaseTextureRegion = BitmapTextureAtlasTextureRegionFactory
				.createFromAsset(mControlBaseTexture, this,
						"onscreen_control_base.png", 0, 0);

		mScreenControlKnobTextureRegion = BitmapTextureAtlasTextureRegionFactory
				.createFromAsset(mControlKnobTexture, this,
						"onscreen_control_knob.png", 128, 0);

		mEngine.getTextureManager().loadTexture(mControlBaseTexture);
		mEngine.getTextureManager().loadTexture(mControlKnobTexture);
		// Ket thuc

		// Load score
		mTextTexture = new BitmapTextureAtlas(256, 256,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);
		mRetryTexture = new BitmapTextureAtlas(256, 256,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);
		mScoreTexture = new BitmapTextureAtlas(256, 256,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);
		mRestartTexture = new BitmapTextureAtlas(256, 256,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);		

		mText = new Font(this.mTextTexture, Typeface.create(Typeface.DEFAULT,
				Typeface.BOLD), 32, true, Color.BLACK);
		mRetry = new Font(this.mRetryTexture, Typeface.create(Typeface.DEFAULT,
				Typeface.BOLD), 70, true, Color.BLUE);
		mScore = new Font(this.mScoreTexture, Typeface.create(Typeface.DEFAULT,
				Typeface.BOLD), 32, true, Color.BLACK);
		mRestart = new Font(this.mRestartTexture, Typeface.create(Typeface.DEFAULT,
				Typeface.BOLD), 32, true, Color.BLACK);		

		this.mEngine.getTextureManager().loadTexture(mTextTexture);
		this.mEngine.getTextureManager().loadTexture(mRetryTexture);
		this.mEngine.getTextureManager().loadTexture(mScoreTexture);
		this.mEngine.getTextureManager().loadTexture(mRestartTexture);

		getEngine().getFontManager().loadFont(mText);
		getEngine().getFontManager().loadFont(mRetry);
		getEngine().getFontManager().loadFont(mScore);
		getEngine().getFontManager().loadFont(mRestart);
		// Ket thuc

		// Load Bot
		mBotTexture = new BitmapTextureAtlas(256, 64,
				TextureOptions.BILINEAR_PREMULTIPLYALPHA);

		mBotTiledTextureRegion = BitmapTextureAtlasTextureRegionFactory
				.createTiledFromAsset(mBotTexture, this, "twich.png", 0, 0, 5,
						1);

		mEngine.getTextureManager().loadTexture(mBotTexture);
		// Ket thuc
	}

	@Override
	public Scene onLoadScene() {
		// TODO Auto-generated method stub
		mEngine.registerUpdateHandler(new FPSLogger());
		mScene = new Scene();
		mScene.setBackground(new ColorBackground(0.09804f, 0.6274f, 0.8784f));
		// mScene.setBackground(mGrassBackground);

		// Tai map
		mTMXTiledMap = BanDoGame.getTMXTiledMap(mScene, mEngine, this,
				strBando, this);

		// ket thuc
		// final int centerX = ((CAMERA_WIDTH -
		// mHeroTiledTextureRegion.getWidth()) / 2);
		// final int centerY = ((CAMERA_HEIGHT - mHeroTiledTextureRegion
		// .getHeight()) / 2);
		final int centerX = 640;
		final int centerY = 256;

		mHeroAnimatedSprite = new AnimatedSprite(centerX, centerY,
				mHeroTiledTextureRegion);

		final PhysicsHandler mPhysicsHandler = new PhysicsHandler(
				mHeroAnimatedSprite);
		mHeroAnimatedSprite.registerUpdateHandler(mPhysicsHandler);
		mHeroAnimatedSprite.setRotation(90);

		ArrayList<TMXLayer> mapLayers = mTMXTiledMap.getTMXLayers();
		for (TMXLayer layer : mapLayers) {
			if (layer.getName().equals("vatcan")) {
				VatCanTMXLayer = layer;
			}
			if (layer.getName().equals("caycoi")) {
				CayCoiTMXLayer = layer;
			}
			if (layer.getName().equals("nenco")) {
				NenCoTMXLayer = layer;
			}
			if (layer.getName().equals("chammoc1")) {
				ChamMoc1TMXLayer = layer;
			}
			if (layer.getName().equals("chammoc2")) {
				ChamMoc2TMXLayer = layer;
			}
			if (layer.getName().equals("chammoc3")) {
				ChamMoc3TMXLayer = layer;
			}
			if (layer.getName().equals("chammoc4")) {
				ChamMoc4TMXLayer = layer;
			}

			mScene.attachChild(layer);
		}

		mScene.attachChild(mHeroAnimatedSprite);

		// final TMXLayer tmxLayer = this.mTMXTiledMap.getTMXLayers().get(0);
		tmxLayer = this.mTMXTiledMap.getTMXLayers().get(0);
		mCamera.setBounds(0, tmxLayer.getWidth(), 0, tmxLayer.getHeight());
		mCamera.setBoundsEnabled(true);
		mCamera.setChaseEntity(mHeroAnimatedSprite);

		// mDigitalOnScreenControl = new DigitalOnScreenControl(0, CAMERA_HEIGHT
		// - mScreenControlBaseTextureRegion.getHeight(), mCamera,
		// mScreenControlBaseTextureRegion,
		// mScreenControlKnobTextureRegion, 0.1f,
		// new ControlListener(mHeroAnimatedSprite,VatCanTMXLayer, mTMXTiledMap,
		// mPhysicsHandler));

		// Khoi tao bot
		bot = new BotCar(256, 111, 32, 64, mBotTiledTextureRegion);
		bot2 = new BotCar(1000, 640, 32, 64, mBotTiledTextureRegion);
		bot3 = new BotCar(0, 55, 32, 64, mBotTiledTextureRegion);
		bot.animate(new long[] { 200, 200, 200, 200, 200 }, 0, 4, true);
		bot2.animate(new long[] { 200, 200, 200, 200, 200 }, 0, 4, true);
		bot3.animate(new long[] { 200, 200, 200, 200, 200 }, 0, 4, true);
		// Ket thuc

		mDigitalOnScreenControl = new AnalogOnScreenControl(0, CAMERA_HEIGHT
				- mScreenControlBaseTextureRegion.getHeight(), mCamera,
				mScreenControlBaseTextureRegion,
				mScreenControlKnobTextureRegion, 0.1f, new ControlTest(
						mHeroAnimatedSprite, bot, bot2, bot3, VatCanTMXLayer,
						CayCoiTMXLayer, NenCoTMXLayer, ChamMoc1TMXLayer,
						ChamMoc2TMXLayer, ChamMoc3TMXLayer, ChamMoc4TMXLayer,
						mTMXTiledMap, mPhysicsHandler));

		// mDigitalOnScreenControl = new AnalogOnScreenControl(0, CAMERA_HEIGHT
		// - mScreenControlBaseTextureRegion.getHeight(), mCamera,
		// mScreenControlBaseTextureRegion,
		// mScreenControlKnobTextureRegion, 0.1f,
		// new IAnalogOnScreenControlListener() {
		//
		// @Override
		// public void onControlChange(
		// BaseOnScreenControl pBaseOnScreenControl,
		// float pValueX, float pValueY) {
		// // TODO Auto-generated method stub
		// mPhysicsHandler.setVelocity(pValueX * 256,
		// pValueY * 256);
		// final float rotationInRad = (float) Math.atan2(pValueX,
		// -pValueY);
		// mHeroAnimatedSprite.setRotation(MathUtils
		// .radToDeg(rotationInRad));
		// }
		//
		// @Override
		// public void onControlClick(
		// AnalogOnScreenControl pAnalogOnScreenControl) {
		// // TODO Auto-generated method stub
		//
		// }
		// });
		
			mDigitalOnScreenControl.getControlBase().setBlendFunction(
					GL10.GL_SRC_ALPHA, GL10.GL_ONE_MINUS_SRC_ALPHA);
			mDigitalOnScreenControl.getControlBase().setAlpha(0.5f);
			mDigitalOnScreenControl.getControlBase().setScaleCenter(0, 128);
			mDigitalOnScreenControl.getControlBase().setScale(0.75f);
			mDigitalOnScreenControl.refreshControlKnobPosition();
			mDigitalOnScreenControl.setTouchAreaBindingEnabled(true);
			mScene.setChildScene(mDigitalOnScreenControl);			

		// Hien thi score va turn
		final ChangeableText textScore = new ChangeableText(0, 0, mText,
				"Score:", "Score: XXXXX".length());
		final ChangeableText textTurn = new ChangeableText(0, 0, mScore,
				"Turn:", "Turn: XXXXXXXXXXXXXXXXX".length());	
		final ChangeableText textRetry = new ChangeableText(0, 0, mRestart,
				"Retry:", "XXXXXXXXXXX".length());		
		textScore.setPosition(CAMERA_WIDTH, CAMERA_HEIGHT);
		textTurn.setPosition(CAMERA_WIDTH, CAMERA_HEIGHT - 25);
		textRetry.setPosition(CAMERA_WIDTH, CAMERA_HEIGHT - 50);
		mScene.attachChild(textScore);
		mScene.attachChild(textTurn);
		mScene.attachChild(textRetry);		
		// Ket thuc

		final Text mGameOver = new Text(320, centerY, mRetry,
				"Retry? Click here");

		// Reload score
		mScene.registerUpdateHandler(new IUpdateHandler() {

			@Override
			public void reset() {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void onUpdate(float pSecondsElapsed) {
				// TODO Auto-generated method stub
				
				if(PublicStatic.gameOver == false){
					try {
						Thread.sleep(10);
					} catch (Exception e) {
						// TODO: handle exception
					}
					textScore.setText("Score: " + PublicStatic.score);
					// textTurn.setText("Turn: " + PublicStatic.turn1 + "/1; "+
					// PublicStatic.turn2 + "/2; " + PublicStatic.turn3 + "/3");
					textTurn.setText("Turn: " + PublicStatic.turn + "/3");
					
					textRetry.setText("Retry: "+ demNguoc);
					
					// Game over
					if (PublicStatic.turn == 0 || demNguoc == 0) {
						
						mSoundEffect.play(Constant.MUSIC_CAR_BOOM);

						PublicStatic.gameOver = true;
						
						textRetry.setText("Game Over");
						
						mHeroAnimatedSprite.setPosition(640, 256);
						
						mGameOver.registerEntityModifier(new AlphaModifier(10f, 1f,
								0f));
						mScene.attachChild(mGameOver);
	
						mScene.setTouchAreaBindingEnabled(true);
						mScene.setOnSceneTouchListener(new IOnSceneTouchListener() {
	
							@Override
							public boolean onSceneTouchEvent(Scene pScene,
									TouchEvent pSceneTouchEvent) {
								// TODO Auto-generated method stub
								float clickBtnX = mGameOver.getX()
										+ mGameOver.getWidth();
								float clickBtnY = mGameOver.getY()
										+ mGameOver.getHeight();
								if (pSceneTouchEvent.getX() >= mGameOver.getX()
										&& pSceneTouchEvent.getX() < clickBtnX
										&& pSceneTouchEvent.getY() < clickBtnY
										&& pSceneTouchEvent.getY() >= mGameOver
												.getY()) {
									mDigitalOnScreenControl.setVisible(true);
									mDigitalOnScreenControl
											.setTouchAreaBindingEnabled(true);
									mScene.detachChild(mGameOver);
									PublicStatic.turn = 3;
									PublicStatic.gameOver = false;
									boDem = 61;
									demNguoc = 61;
									mSoundEffect.play(Constant.MUSIC_CAR_TURBO);
								}
								return true;
							}
						});
	
					}
				}
				// Ket thuc
			}
		});
		// Ket thuc

		// load bot
		mScene.attachChild(bot);
		mScene.attachChild(bot2);
		mScene.attachChild(bot3);
		// Ket thuc
		
		//Dem nguoc thoi gian
		CallBackTimer();

		//Ket thuc

		return mScene;
	}

	@Override
	public void onLoadComplete() {
		// TODO Auto-generated method stub
//		mBackGroundMusic = new BackgroundMusic();
//		mBackGroundMusic.execute(new Context[]{this});
		mContext = MainActivity.this;
		mSoundEffect = new SoundEffect(mContext);
	}

	private static class BotCar extends AnimatedSprite {
		private final PhysicsHandler mPhysicsHandler;

		public BotCar(float pX, float pY, float pTileWidth, float pTileHeight,
				TiledTextureRegion pTiledTextureRegion) {
			super(pX, pY, pTileWidth, pTileHeight, pTiledTextureRegion);
			// TODO Auto-generated constructor stub
			this.mPhysicsHandler = new PhysicsHandler(this);
			this.registerUpdateHandler(this.mPhysicsHandler);
			this.mPhysicsHandler.setVelocity(MainActivity.speedBot,
					MainActivity.speedBot);
		}

		@Override
		protected void onManagedUpdate(final float pSecondsElapsed) {
			if (this.mX < 0) {
				this.mPhysicsHandler.setVelocityX(MainActivity.speedBot);
			} else if (this.mX + this.getWidth() > tmxLayer.getWidth()) {
				this.mPhysicsHandler.setVelocityX(-MainActivity.speedBot);
				bot.setFlippedHorizontal(true);
				bot2.setFlippedHorizontal(true);
				bot3.setFlippedHorizontal(true);
			}

			if (this.mY < 0) {
				this.mPhysicsHandler.setVelocityY(MainActivity.speedBot);
			} else if (this.mY + this.getHeight() > tmxLayer.getHeight()) {
				this.mPhysicsHandler.setVelocityY(-MainActivity.speedBot);
				bot.setFlippedHorizontal(false);
				bot2.setFlippedHorizontal(false);
				bot3.setFlippedHorizontal(false);
			}

			super.onManagedUpdate(pSecondsElapsed);
		}

	}
	
	private void CallBackTimer(){
		 new CountDownTimer(1000, 1000) {
				
			@Override
			public void onTick(long millisUntilFinished) {
				// TODO Auto-generated method stub
				if(demNguoc >= 1){
					boDem = boDem - 1;
					demNguoc = boDem;
				}
				else{
					if(boDem >= 1){
						demNguoc = boDem;
					}
					else{
						demNguoc = 1;
					}
				}
			}
			
			@Override
			public void onFinish() {
				// TODO Auto-generated method stub	    	 
		    	 start();
			}
		}.start();	  
	}
}

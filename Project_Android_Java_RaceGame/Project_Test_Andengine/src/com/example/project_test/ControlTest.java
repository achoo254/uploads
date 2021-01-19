package com.example.project_test;

import org.anddev.andengine.engine.camera.hud.controls.AnalogOnScreenControl;
import org.anddev.andengine.engine.camera.hud.controls.AnalogOnScreenControl.IAnalogOnScreenControlListener;
import org.anddev.andengine.engine.camera.hud.controls.BaseOnScreenControl;
import org.anddev.andengine.engine.handler.physics.PhysicsHandler;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXLayer;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXProperties;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXProperty;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTile;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTileProperty;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTiledMap;
import org.anddev.andengine.entity.scene.Scene;
import org.anddev.andengine.entity.sprite.AnimatedSprite;
import org.anddev.andengine.util.MathUtils;

import android.content.Context;
import android.util.Log;

public class ControlTest implements IAnalogOnScreenControlListener {

	AnimatedSprite hero;
	AnimatedSprite bot;
	AnimatedSprite bot2;
	AnimatedSprite bot3;
	TMXLayer vatcan;
	TMXLayer nenco;
	TMXLayer caycoi;
	TMXLayer chammoc1;
	TMXLayer chammoc2;
	TMXLayer chammoc3;
	TMXLayer chammoc4;
	TMXTiledMap map;
	PhysicsHandler physic;
	int checkmoc1 = 0; // 1 la kich hoat; 0 la chua kich hoat
	int checkmoc2 = 0; // 1 la kich hoat; 0 la chua kich hoat
	int checkmoc3 = 0; // 1 la kich hoat; 0 la chua kich hoat
	int checkmoc4 = 0; // 1 la kich hoat; 0 la chua kich hoat
	Scene mScene;
	int trangThaiGiamToc = 256;
	float rotationInRad;
	SoundEffect mSoundEffect;
	Context mContext;	

	public ControlTest(AnimatedSprite mHeroAnimatedSprite, AnimatedSprite mBot,
			AnimatedSprite mBot2, AnimatedSprite mBot3,
			TMXLayer mVatCanTMXLayer, TMXLayer mCayCoiTMXLayer,
			TMXLayer mNenCoTMXLayer, TMXLayer mChamMoc1TMXLayer,
			TMXLayer mChamMoc2TMXLayer, TMXLayer mChamMoc3TMXLayer,
			TMXLayer mChamMoc4TMXLayer, TMXTiledMap mTMXTiledMap,
			PhysicsHandler mPhysicsHandler) {
		hero = mHeroAnimatedSprite;
		bot = mBot;
		bot2 = mBot2;
		bot3 = mBot3;
		vatcan = mVatCanTMXLayer;
		nenco = mNenCoTMXLayer;
		caycoi = mCayCoiTMXLayer;
		chammoc1 = mChamMoc1TMXLayer;
		chammoc2 = mChamMoc2TMXLayer;
		chammoc3 = mChamMoc3TMXLayer;
		chammoc4 = mChamMoc4TMXLayer;
		map = mTMXTiledMap;
		physic = mPhysicsHandler;
	}

	@Override
	public void onControlChange(BaseOnScreenControl pBaseOnScreenControl,
			float pValueX, float pValueY) {
		// TODO Auto-generated method stub
		// lay vi tri tile hero dang dung
		if(PublicStatic.gameOver == false){
			if (pValueX != 0 || pValueY != 0) {
				//Load turbo sound
				//MainActivity.mSoundEffect.play(Constant.MUSIC_CAR_TURBO);				
				//Ket thuc
				float pXHero = hero.getX() + hero.getWidth();
				float pYHero = hero.getY() + hero.getHeight();
	
				TMXTile mTileVatCan = vatcan.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao vat can
					if (mTileVatCan != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileVatCan
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("vatcan")) {
							Log.v("da dung", "dung vao tuong ");
							hero.setPosition(640, 256);
							PublicStatic.flag = 1;
							checkmoc1 = 0;
							checkmoc2 = 0;
							checkmoc3 = 0;
							checkmoc4 = 0;
							PublicStatic.turn1 = 0;
							PublicStatic.turn2 = 0;
							PublicStatic.turn3 = 0;
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					//Log.v("dang di chuyen", "chay bon bon");
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				TMXTile mTileCayCoi = caycoi.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao cay coi
					if (mTileCayCoi != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileCayCoi
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("caycoi")) {
							Log.v("da dung", "dung vao cay coi");
							hero.setPosition(640, 256);
							PublicStatic.flag = 1;
							checkmoc1 = 0;
							checkmoc2 = 0;
							checkmoc3 = 0;
							checkmoc4 = 0;
							PublicStatic.turn1 = 0;
							PublicStatic.turn2 = 0;
							PublicStatic.turn3 = 0;
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				TMXTile mTileNenCo = nenco.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao nen co
					if (mTileNenCo != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileNenCo
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("nenco")) {
							Log.v("di cham", "di tren nen co");
							physic.setVelocity(pValueX * 56, pValueY * 56);
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				TMXTile mTileChamMoc1 = chammoc1.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao moc 1
					if (mTileChamMoc1 != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileChamMoc1
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("chammoc1")) {
							Log.v("can moc", "da ve moc 1");
							checkmoc1 = 1;
							if (checkmoc1 == 1 && checkmoc2 == 1 && checkmoc3 == 1
									&& checkmoc4 == 1) {
								PublicStatic.score = PublicStatic.score + 10;
								System.out.println(PublicStatic.score);
								checkmoc1 = 0;
								checkmoc2 = 0;
								checkmoc3 = 0;
								checkmoc4 = 0;
								PublicStatic.turn1 = 0;
								PublicStatic.turn2 = 0;
								PublicStatic.turn3 = 0;
							}
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				TMXTile mTileChamMoc2 = chammoc2.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao moc 2
					if (mTileChamMoc2 != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileChamMoc2
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("chammoc2")) {
							Log.v("can moc", "da ve moc 2");
							checkmoc2 = 1;
							PublicStatic.turn1 = 1;
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				TMXTile mTileChamMoc3 = chammoc3.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao moc 3
					if (mTileChamMoc3 != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileChamMoc3
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("chammoc3")) {
							if (checkmoc2 == 1 && checkmoc4 == 0) {
								Log.v("can moc", "da ve moc 3");
								checkmoc3 = 1;
								PublicStatic.turn2 = 2;
							}
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				TMXTile mTileChamMoc4 = chammoc4.getTMXTileAt(pXHero, pYHero);
	
				try {// Roi vao moc 4
					if (mTileChamMoc4 != null) {
						TMXProperties<TMXTileProperty> mTMXProperty = mTileChamMoc4
								.getTMXTileProperties(map);
						TMXProperty tmxProperty = mTMXProperty.get(0);
						if (tmxProperty.getName().equals("chammoc4")) {
							Log.v("can moc", "da ve moc 4");
							if (checkmoc2 == 1 && checkmoc3 == 1) {
								checkmoc4 = 1;
								PublicStatic.turn3 = 3;
							}
	
						}
					}
				} catch (Exception e) {// Khong vao vat can
					// TODO: handle exception
					physic.setVelocity(pValueX * 256, pValueY * 256);
					rotationInRad = (float) Math.atan2(pValueX, -pValueY);
					hero.setRotation(MathUtils.radToDeg(rotationInRad));
				}
	
				// Cham vao bot
				if(VaCham(hero, bot) || VaCham(hero, bot2) || VaCham(hero, bot3)){
					hero.setPosition(640, 256);
					checkmoc1 = 0;
					checkmoc2 = 0;
					checkmoc3 = 0;
					checkmoc4 = 0;
					PublicStatic.turn1 = 0;
					PublicStatic.turn2 = 0;
					PublicStatic.turn3 = 0;	
					PublicStatic.score = 0;
					if(PublicStatic.turn >= 1){
						PublicStatic.turn = PublicStatic.turn - 1;					
					}else{
						PublicStatic.turn = 0;
					}
	
				}
				// Ket thuc
	
			} else {
				physic.setVelocity(pValueX * 0, pValueY * 0);
				
				if(VaCham(hero, bot) || VaCham(hero, bot2) || VaCham(hero, bot3)){
					hero.setPosition(640, 256);
					checkmoc1 = 0;
					checkmoc2 = 0;
					checkmoc3 = 0;
					checkmoc4 = 0;
					PublicStatic.turn1 = 0;
					PublicStatic.turn2 = 0;
					PublicStatic.turn3 = 0;
					PublicStatic.score = 0;
					if(PublicStatic.turn >= 1){
						PublicStatic.turn = PublicStatic.turn - 1;					
					}else{
						PublicStatic.turn = 0;
					}				
				}			
			}
		}
		else{
			physic.setVelocity(pValueX * 0, pValueY * 0);
		}
	}

	@Override
	public void onControlClick(AnalogOnScreenControl pAnalogOnScreenControl) {
		// TODO Auto-generated method stub

	}
	
	public boolean VaCham(AnimatedSprite a, AnimatedSprite b){
		if(a.collidesWith(b)){
			return true;
		}
		return false;
		
	}

}

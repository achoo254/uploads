package com.example.project_test;

import org.anddev.andengine.engine.camera.hud.controls.BaseOnScreenControl;
import org.anddev.andengine.engine.camera.hud.controls.BaseOnScreenControl.IOnScreenControlListener;
import org.anddev.andengine.engine.handler.IUpdateHandler;
import org.anddev.andengine.engine.handler.physics.PhysicsHandler;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXLayer;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXProperties;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXProperty;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTile;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTileProperty;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTiledMap;
import org.anddev.andengine.entity.scene.Scene;
import org.anddev.andengine.entity.sprite.AnimatedSprite;

import android.util.Log;




public class ControlListener implements IOnScreenControlListener {

	AnimatedSprite hero;
	TMXLayer vatcan;
	TMXTiledMap map;
	PhysicsHandler physic;
	int trangthai = 0; // 1 la trai , 2 la phai , 3 la xuong, 4 la len
	Scene mScene;
	int trangThaiGiamToc = 256;

	public ControlListener(AnimatedSprite mHeroAnimatedSprite,
			TMXLayer mVatCanTMXLayer, TMXTiledMap mTMXTiledMap,
			PhysicsHandler mPhysicsHandler) {
		hero = mHeroAnimatedSprite;
		vatcan = mVatCanTMXLayer;
		map = mTMXTiledMap;
		physic = mPhysicsHandler;
	}

	@Override
	public void onControlChange(BaseOnScreenControl pBaseOnScreenControl,
			final float pValueX, final float pValueY) {
		// TODO Auto-generated method stub
		if (pValueX != 0 || pValueY != 0) {// tinh truc toa do tu knob
			float pXHero = 0, pYHero = 0;
//			pXHero = hero.getX()+16;
//			pYHero = hero.getY()+16;
			if (pValueX > 0) {// di chuyen ben phai
				if (trangthai != 2) {
					hero.animate(new long[] { 200, 200, 200 }, 6, 8, true);
					trangthai = 2;
				}
					pXHero = hero.getX() + hero.getWidth();
					pYHero = hero.getY() + hero.getHeight()/2;				
			} else if (pValueX < 0) {// di chuyen ben trai
				if (trangthai != 1) {
					hero.animate(new long[] { 200, 200, 200 }, 3, 5, true);
					trangthai = 1;				
				}
					pXHero = hero.getX();
					pYHero = hero.getY() + hero.getHeight()/2;					
			} else if (pValueY > 0) {// di chuyen xuong duoi
				if (trangthai != 3) {
					hero.animate(new long[] { 200, 200, 200 }, 0, 2, true);
					trangthai = 3;					
				}
					pXHero = hero.getX() + hero.getWidth()/2;
					pYHero = hero.getY() + hero.getHeight();				
			} else if (pValueY < 0) {// di chuyen len tren
				if (trangthai != 4) {
					hero.animate(new long[] { 200, 200, 200 }, 9, 11, true);
					trangthai = 4;					
				}
					pXHero = hero.getX() + hero.getWidth()/2;
					pYHero = hero.getY();				
			}
			// lay vi tri tile hero dang dung
			TMXTile mTileHero = vatcan.getTMXTileAt(pXHero, pYHero);
			try {// Roi vao vat can
				if (mTileHero != null) {
					TMXProperties<TMXTileProperty> mTMXProperty = mTileHero
							.getTMXTileProperties(map);
					TMXProperty tmxProperty = mTMXProperty.get(0);
					if (tmxProperty.getName().equals("vatcan") || tmxProperty.getName().equals("caycoi")) {
						Log.v("da dung", "dung vao tuong, trang thai = "+ trangthai);
						System.out.println("da dung "+ "pXHero="+hero.getX()+" pYHero="+hero.getY());
						physic.setVelocity(pValueX * 0, pValueY * 0);	
						//hero.setPosition(pXHero, pYHero);
					}
					if (tmxProperty.getName().equals("nenco")) {
						Log.v("di cham", "dang di tren co, trang thai = "+ trangthai);
						physic.setVelocity(pValueX * 100, pValueY * 100);	
						//hero.setPosition(pXHero, pYHero);
					}					
				}
			} catch (Exception e) {// Khong vao vat can
				// TODO: handle exception
				Log.v("dang di chuyen", "khong tuong, trang thai = "+ trangthai);		
				System.out.println("dang di chuyen "+ "pXHero="+hero.getX()+" pYHero="+hero.getY());
				physic.setVelocity(pValueX * 256, pValueY * 256);
				System.out.println(mTileHero.getTileX()+ "  | " + mTileHero.getTileY());
				//hero.setPosition(pXHero1, pYHero1);
			}
		}else{
			physic.setVelocity(pValueX * 0, pValueY * 0);

		}
	}

}

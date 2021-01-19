package com.example.project_test;

import org.anddev.andengine.engine.Engine;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXLayer;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXLoader;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXLoader.ITMXTilePropertiesListener;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXProperties;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTile;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTileProperty;
import org.anddev.andengine.entity.layer.tiled.tmx.TMXTiledMap;
import org.anddev.andengine.entity.scene.Scene;
import org.anddev.andengine.opengl.texture.TextureOptions;

import android.app.Activity;
import android.content.Context;

public class BanDoGame {
	public static TMXTiledMap getTMXTiledMap(Scene mScene, Engine mEngine,
			Context mContext, String str_map, final Activity activity) {
		TMXTiledMap mTMXTiledMap;
		try {
			final TMXLoader tmxLoader = new TMXLoader(mContext,
					mEngine.getTextureManager(),
					TextureOptions.BILINEAR_PREMULTIPLYALPHA,
					new ITMXTilePropertiesListener() {

						@Override
						public void onTMXTileWithPropertiesCreated(
								TMXTiledMap pTMXTiledMap,
								TMXLayer pTMXLayer,
								TMXTile pTMXTile,
								TMXProperties<TMXTileProperty> pTMXTileProperties) {
							// TODO Auto-generated method stub

						}
					});
			mTMXTiledMap = tmxLoader.loadFromAsset(mContext, str_map);
			//System.out.println(mTMXTiledMap);
			return mTMXTiledMap;
		} catch (Exception e) {
			// TODO: handle exception
		}
		return null;
	}
}

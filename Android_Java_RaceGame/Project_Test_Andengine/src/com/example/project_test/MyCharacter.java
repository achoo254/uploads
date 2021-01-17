package com.example.project_test;

import org.anddev.andengine.entity.sprite.AnimatedSprite;

public class MyCharacter implements MoveCharacter{
	float pX;
	float pY;
	AnimatedSprite animate;
	public static MyCharacter mMyCharacter;
	
	public MyCharacter(AnimatedSprite character) {
		animate = character;
		pX = animate.getX();
		pY = animate.getY();
	}
	
	@Override
	public void moveUp(float mX, float mY) {
		// TODO Auto-generated method stub
		//pX += mX;
		pY -= mY;
		animate.setPosition(pX, pY);
		animate.animate(new long[]{50, 50, 50}, 9, 11, true);
	}
	@Override
	public void moveDown(float mX, float mY) {
		// TODO Auto-generated method stub
		//pX -= mX;
		pY += mY;
		animate.setPosition(pX, pY);	
		animate.animate(new long[]{50, 50, 50}, 0, 2, true);
	}
	@Override
	public void moveLeft(float mX, float mY) {
		// TODO Auto-generated method stub
		pX -= mX;
		//pY += mY;
		animate.setPosition(pX, pY);	
		animate.animate(new long[]{50, 50, 50}, 3, 5, true);
	}
	@Override
	public void moveRight(float mX, float mY) {
		// TODO Auto-generated method stub
		pX += mX;
		//pY += mY;
		animate.setPosition(pX, pY);	
		animate.animate(new long[]{50, 50, 50}, 6, 8, true);
	}
	
	
}

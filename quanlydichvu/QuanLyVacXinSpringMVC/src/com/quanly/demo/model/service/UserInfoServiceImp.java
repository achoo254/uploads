package com.quanly.demo.model.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.quanly.demo.model.dao.UserInfoDao;
import com.quanly.demo.model.entity.UserInfo;

@Service
public class UserInfoServiceImp implements UserInfoService{
	@Autowired
	UserInfoDao userInfoDao;
	
	@Override
	public List<UserInfo> getAllUserInfo() {
		// TODO Auto-generated method stub
		return userInfoDao.getAllUserInfo();
	}

	@Override
	public boolean save(UserInfo user) {
		// TODO Auto-generated method stub
		return userInfoDao.save(user);
	}

	@Override
	public boolean merge(UserInfo user) {
		// TODO Auto-generated method stub
		return userInfoDao.merge(user);
	}

	@Override
	public boolean delete(int userId) {
		// TODO Auto-generated method stub
		return userInfoDao.delete(userId);
	}

	@Override
	public UserInfo getUserInfo(String token) {
		// TODO Auto-generated method stub
		return userInfoDao.getUserInfo(token);
	}

	@Override
	public UserInfo getUserInfoById(int id) {
		// TODO Auto-generated method stub
		return userInfoDao.getUserInfoById(id);
	}

}

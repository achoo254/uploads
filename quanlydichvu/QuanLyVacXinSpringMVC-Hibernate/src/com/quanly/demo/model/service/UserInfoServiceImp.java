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
		return false;
	}

	@Override
	public boolean merge(UserInfo user) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean delete(int userId) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public UserInfo getUserInfo(int userId) {
		// TODO Auto-generated method stub
		return null;
	}

}
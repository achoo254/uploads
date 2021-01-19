package com.quanly.demo.model.service;

import com.quanly.demo.model.dao.UserInfoDao;
import com.quanly.demo.model.entity.UserInfo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class UserInfoServiceImp implements UserInfoService{
	@Autowired
	UserInfoDao userInfoDao;
	
	@Override
	public List<UserInfo> getAllUserInfo(Integer offset, Integer maxResult) {
		// TODO Auto-generated method stub
		return userInfoDao.getAllUserInfo(offset, maxResult);
	}
	
	@Override
	public Long count() {
		// TODO Auto-generated method stub
		return userInfoDao.count();
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
	public UserInfo getUserInfoByTelephone(String telephone) {
		// TODO Auto-generated method stub
		return userInfoDao.getUserInfoByTelephone(telephone);
	}

	@Override
	public UserInfo getUserInfoById(int id) {
		// TODO Auto-generated method stub
		return userInfoDao.getUserInfoById(id);
	}

	@Override
	public List<UserInfo> getTop5UserInfo() {
		// TODO Auto-generated method stub
		return userInfoDao.getTop5UserInfo();
	}



}

package com.quanly.demo.model.dao;

import java.util.List;

import com.quanly.demo.model.entity.UserInfo;

public interface UserInfoDao {
	public List<UserInfo> getAllUserInfo();
	public boolean save(UserInfo user);
	public boolean merge(UserInfo user);
	public boolean delete(int userId);
	public UserInfo getUserInfoByTelephone(String telephone);
	public UserInfo getUserInfoById(int id);
}

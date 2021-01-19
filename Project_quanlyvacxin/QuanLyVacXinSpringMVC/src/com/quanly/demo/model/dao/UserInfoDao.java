package com.quanly.demo.model.dao;

import com.quanly.demo.model.entity.UserInfo;

import java.util.List;

public interface UserInfoDao {
	public List<UserInfo> getAllUserInfo(Integer offset, Integer maxResult);
	public boolean save(UserInfo user);
	public boolean merge(UserInfo user);
	public boolean delete(int userId);
	public UserInfo getUserInfoById(int id);
	public Long count();
	//Custom
	public UserInfo getUserInfoByTelephone(String telephone);
	public List<UserInfo> getTop5UserInfo();
}

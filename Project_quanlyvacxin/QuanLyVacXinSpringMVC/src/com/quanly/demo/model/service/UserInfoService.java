package com.quanly.demo.model.service;

import com.quanly.demo.model.entity.UserInfo;

import java.util.List;

public interface UserInfoService {
	public List<UserInfo> getAllUserInfo(Integer offset, Integer maxResult);
	public Long count();
	public boolean save(UserInfo user);
	public boolean merge(UserInfo user);
	public boolean delete(int userId);
	public UserInfo getUserInfoByTelephone(String telephone);
	public UserInfo getUserInfoById(int id);
	public List<UserInfo> getTop5UserInfo();
}

package com.quanly.demo.model.service;

import com.quanly.demo.model.dao.UserInfoDao;
import com.quanly.demo.model.entity.UserInfo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

@Service
public class MyUserDetailsService implements UserDetailsService{
	@Autowired
	UserInfoDao userInfoDao;
	
	@Override
	public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
		UserInfo user = userInfoDao.getUserInfoByTelephone(username);
		if(user == null) {

			return null;
		}
		  boolean enabled = true;
		    boolean accountNonExpired = true;
		    boolean credentialsNonExpired = true;
		    boolean accountNonLocked = true;
		    return new User(username, user.getPassword(), enabled, accountNonExpired, credentialsNonExpired,
		        accountNonLocked, user.getAuthorities());
	}

}

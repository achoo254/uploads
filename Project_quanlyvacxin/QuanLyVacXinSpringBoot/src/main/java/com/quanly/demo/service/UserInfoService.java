package com.quanly.demo.service;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.Customer;
import com.quanly.demo.model.UserInfo;
import com.quanly.demo.model.dto.CustomerDto;

@Repository
public interface UserInfoService extends JpaRepository<UserInfo, Integer> {
	UserInfo findTop1ByTelephone(String telephone);

	UserInfo findTop1ByEmail(String email);

	UserInfo findTop1ByToken(String token);
	
	UserInfo findTop1ByTelephoneAndRoles(String telephone, String roles);
	
	List<UserInfo> findByUserInfoId(int userInfoId);
	
	UserInfo findByListCustomer(Customer customer);
}

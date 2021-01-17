package com.quanly.demo.service;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;


import com.quanly.demo.model.Customer;
import com.quanly.demo.model.CustomerRoom;
import com.quanly.demo.model.UserInfo;


@Repository
public interface CustomerService  extends JpaRepository<Customer, Integer>{
	//@Query(nativeQuery = true, value ="SELECT TOP 1 customer_id from customer where user_info_id = :userInfoId")
	Customer findTop1ByCustomerUserInfo(UserInfo userInfo);
	
	Customer findByListCustomerRoom(CustomerRoom customerRoom);
	
	Customer findByCustomerId(int customerId);
}

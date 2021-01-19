package com.quanly.demo.model.service;

import com.quanly.demo.model.dao.OrdersDao;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class OrdersServiceImp implements OrdersService{
	@Autowired
	OrdersDao ordersDao;
	
	@Override
	public Long sumTotal() {
		// TODO Auto-generated method stub
		return ordersDao.sumTotal();
	}

}

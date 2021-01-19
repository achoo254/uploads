package com.quanly.demo.model.service;

import com.quanly.demo.model.dao.ProductDetailsDao;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ProductDetailsServiceImp implements ProductDetailsService{
	@Autowired
	ProductDetailsDao productDetailsDao;
	
	@Override
	public Double sumProductDetails() {
		// TODO Auto-generated method stub
		return productDetailsDao.sumProductDetails();
	}

}

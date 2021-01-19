package com.quanly.demo.model.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.quanly.demo.model.dao.ProductDetailsDao;

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

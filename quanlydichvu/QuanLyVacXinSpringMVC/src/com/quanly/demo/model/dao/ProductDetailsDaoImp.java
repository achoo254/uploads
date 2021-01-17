package com.quanly.demo.model.dao;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Projections;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.entity.Orders;
import com.quanly.demo.model.entity.ProductDetails;

@Repository
public class ProductDetailsDaoImp implements ProductDetailsDao{
	@Autowired
	private SessionFactory sessionFactory;
	
	@Override
	public Double sumProductDetails() {
        return (Double)sessionFactory.openSession().createQuery("select sum(pro.buy * pd.quantity) FROM ProductDetails as pd inner join Product as pro on pd.productDetailsProduct = pro.productId ").uniqueResult();
	}

}

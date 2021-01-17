package com.quanly.demo.model.dao;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Projections;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.entity.Orders;

@Repository
public class OrdersDaoImp implements OrdersDao{
	@Autowired
	private SessionFactory sessionFactory;
	
	@Override
	public Long sumTotal() {
        return (Long)sessionFactory.openSession()
                .createCriteria(Orders.class)
                .setProjection(Projections.sum("total"))
                .uniqueResult();
	}

}

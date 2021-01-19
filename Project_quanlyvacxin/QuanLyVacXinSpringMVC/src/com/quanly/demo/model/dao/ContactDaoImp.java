package com.quanly.demo.model.dao;

import java.util.List;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Projections;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.entity.Contact;
import com.quanly.demo.model.entity.Orders;

@Repository
public class ContactDaoImp implements ContactDao{
	@Autowired
	private SessionFactory sessionFactory;
	
	@SuppressWarnings("deprecation")
	@Override
	public Long countContact() {
		  return (Long)sessionFactory.openSession()
	       .createCriteria(Contact.class)
           .setProjection(Projections.count("contactId"))
           .uniqueResult();
	}

	@SuppressWarnings("unchecked")
	@Override
	public List<Contact> getAllContact(Integer offset, Integer maxResult) {
	       return sessionFactory.openSession()
	                .createCriteria(Contact.class)
	                .setFirstResult(offset!=null?offset:0)
	                .setMaxResults(maxResult!=null?maxResult:10)
	                .list();
	}

}

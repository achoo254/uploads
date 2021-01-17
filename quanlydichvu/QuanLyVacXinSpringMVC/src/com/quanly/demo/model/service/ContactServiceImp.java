package com.quanly.demo.model.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.quanly.demo.model.dao.ContactDao;
import com.quanly.demo.model.entity.Contact;

@Service
public class ContactServiceImp implements ContactService{
	@Autowired
	ContactDao contactDao;
	
	@Override
	public Long countContact() {
		// TODO Auto-generated method stub
		return contactDao.countContact();
	}

	@Override
	public List<Contact> getAllContact(Integer offset, Integer maxResult) {
		// TODO Auto-generated method stub
		return contactDao.getAllContact(offset, maxResult);
	}

}

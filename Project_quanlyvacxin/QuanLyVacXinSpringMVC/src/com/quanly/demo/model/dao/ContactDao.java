package com.quanly.demo.model.dao;

import com.quanly.demo.model.entity.Contact;

import java.util.List;

public interface ContactDao {
	public Long countContact();
	public List<Contact> getAllContact(Integer offset, Integer maxResult);
}

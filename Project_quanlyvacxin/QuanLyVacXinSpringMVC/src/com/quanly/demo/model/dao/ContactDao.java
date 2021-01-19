package com.quanly.demo.model.dao;

import java.util.List;

import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.entity.Contact;

public interface ContactDao {
	public Long countContact();
	public List<Contact> getAllContact(Integer offset, Integer maxResult);
}

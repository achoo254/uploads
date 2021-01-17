package com.quanly.demo.model.service;

import java.util.List;

import com.quanly.demo.model.entity.Contact;

public interface ContactService {
	public Long countContact();
	public List<Contact> getAllContact(Integer offset, Integer maxResult);
}

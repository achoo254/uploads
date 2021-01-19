package com.quanly.demo.model.service;

import com.quanly.demo.model.entity.Contact;

import java.util.List;

public interface ContactService {
	public Long countContact();
	public List<Contact> getAllContact(Integer offset, Integer maxResult);
}

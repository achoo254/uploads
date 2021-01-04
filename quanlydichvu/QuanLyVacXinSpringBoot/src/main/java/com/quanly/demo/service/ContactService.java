package com.quanly.demo.service;

import org.springframework.data.jpa.repository.JpaRepository;
import com.quanly.demo.model.Contact;

public interface ContactService extends JpaRepository<Contact, Integer> {

}

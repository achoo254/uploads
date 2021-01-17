package com.quanly.demo.service;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import com.quanly.demo.model.Notify;

@Repository
public interface NotifyService extends JpaRepository<Notify, Integer> {
	
}

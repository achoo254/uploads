package com.quanly.demo.service;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.Regimen;

@Repository
public interface RegimenService extends JpaRepository<Regimen, Integer>{
	//todo
}

package com.quanly.demo.service;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import org.springframework.stereotype.Repository;

import com.quanly.demo.model.Categories;
import com.quanly.demo.model.Product;

@Repository
public interface ProductService extends JpaRepository<Product, Integer>{
	
}

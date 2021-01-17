package com.quanly.demo.service;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.Categories;
import com.quanly.demo.model.ProductDetails;

@Repository
public interface ProductDetailsService  extends JpaRepository<ProductDetails, Integer>{
	List<ProductDetails> findByProductDetailsCategories(Categories categories);
}

package com.quanly.demo.model.dto;

import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.Categories;
import com.quanly.demo.model.OrderDetails;
import com.quanly.demo.model.ProductDetails;
import com.quanly.demo.model.RegimenDetails;

import lombok.Data;

@Data
public class ProductDto {
	private int productId;
	
	private String images;
	
	private String name;
	
	private String details;
	
	private float buy;
	
	private float sell;
	
	private String country;

	private List<ProductDetails> listProductDetails = new ArrayList<ProductDetails>();
	
}
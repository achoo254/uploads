package com.quanly.demo.model.dto;

import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.Product;
import com.quanly.demo.model.ProductDetails;

import lombok.Data;

@Data
public class CategoriesDto {
	private int categoriesId;
	private String name;
	private String details;
	private List<ProductDetails> listProductDetails = new ArrayList<ProductDetails>();
}
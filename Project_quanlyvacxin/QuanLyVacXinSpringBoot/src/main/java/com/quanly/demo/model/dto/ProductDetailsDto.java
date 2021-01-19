package com.quanly.demo.model.dto;

import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.Categories;
import com.quanly.demo.model.OrderDetails;
import com.quanly.demo.model.Product;
import com.quanly.demo.model.Regimen;
import com.quanly.demo.model.RegimenDetails;

import lombok.Data;

@Data
public class ProductDetailsDto {
	private int productDetailsId;
	private String lote;
	private Date date;
	private Float quantity;
	private ProductDto productDetailsProduct;
	private CategoriesDto productDetailsCategories;
	
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}

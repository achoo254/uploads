package com.quanly.demo.model.entity;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import java.util.ArrayList;
import java.util.List;

import lombok.Data;

@Data
@Entity
@Table(name = "Categories")
public class Categories {
	
	@Id
	@Column(name = "CategoriesId")	
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int categoriesId;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")	
	private String name;
	
	@Column(name = "Details", columnDefinition = "NTEXT")	
	private String details;
	
	@OneToMany(mappedBy = "productDetailsCategories", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<ProductDetails> listProductDetails = new ArrayList<ProductDetails>();
	
}
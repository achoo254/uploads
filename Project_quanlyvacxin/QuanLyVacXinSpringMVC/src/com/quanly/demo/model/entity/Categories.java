package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "Categories")
public class Categories {
	
	@Id
	@Column(name = "categories_id")	
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int categoriesId;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")	
	private String name;
	
	@Column(name = "Details", columnDefinition = "NTEXT")	
	private String details;
	
	@OneToMany(mappedBy = "productDetailsCategories", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<ProductDetails> listProductDetails = new ArrayList<ProductDetails>();
	
}

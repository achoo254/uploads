package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "product")
public class Product {

	@Id
	@Column(name = "product_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int productId;
	
	@Column(name = "Images", columnDefinition = "NVARCHAR(500)")
	private String images;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")
	private String name;
	
	@Column(name = "Details", columnDefinition = "TEXT")
	private String details;
	
	@Column(name = "Buy")
	private float buy;
	
	@Column(name = "Sell")
	private float sell;
	
	@Column(name = "Country", columnDefinition = "NVARCHAR(255)")
	private String country;

	@OneToMany(mappedBy = "productDetailsProduct", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<ProductDetails> listProductDetails = new ArrayList<ProductDetails>();

}

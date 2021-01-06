package com.quanly.demo.model.entity;

import java.util.ArrayList;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name = "Product")
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
package com.quanly.demo.model.entity;

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
import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

import org.springframework.format.annotation.DateTimeFormat;

import lombok.Data;

@Data
@Entity
@Table(name = "product_details")
public class ProductDetails {
	@Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int productDetailsId;
	
	@Column(name = "Lote", columnDefinition = "NVARCHAR(255)")	
	private String lote;
	
	@Column(name = "Date")	
	@DateTimeFormat(pattern = "dd-MM-yyyy")
	private Date date;
	
	@Column(name = "Quantity")	
	private Float quantity;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name="product_id")
	private Product productDetailsProduct;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "categories_id")
	private Categories productDetailsCategories;
	
	@OneToMany(mappedBy = "regimenDetailsProductDetails", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}

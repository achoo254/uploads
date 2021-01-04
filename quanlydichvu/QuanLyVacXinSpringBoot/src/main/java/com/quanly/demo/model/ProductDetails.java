package com.quanly.demo.model;

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

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import com.fasterxml.jackson.annotation.JsonProperty;

import lombok.Data;

@Data
@Entity
@Table(name = "ProductDetails")
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler"})
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
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name="productId")
	private Product productDetailsProduct;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "categoriesId")
	private Categories productDetailsCategories;
	
	@OneToMany(mappedBy = "regimenDetailsProductDetails", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}

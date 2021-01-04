package com.quanly.demo.model;

import java.sql.Date;
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

import org.springframework.format.annotation.DateTimeFormat;

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.quanly.demo.model.dto.OrderDetailsDto;

import lombok.Data;

@Data
@Entity
@Table(name = "RegimenDetails")
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler"})
public class RegimenDetails {
	
	@Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name = "RegimenDetailsId")	
	private int regimenDetailsId;
	
	@Column(name = "DateInject")
	@DateTimeFormat(pattern = "dd-MM-yyyy")
	private Date dateInject;
	
	@Column(name = "Quantity")	
	private Float quantity;
	
	@Column(name = "Inject")	
	private boolean inject;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "regimenId")
	private Regimen regimenDetailsRegimen;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "productDetailsId")
	private ProductDetails regimenDetailsProductDetails;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "customerId")
	private Customer regimenDetailsCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "userInfoId")
	private UserInfo regimenDetailsUserInfo;
	
	@OneToMany(mappedBy = "orderDetailsRegimenDetails", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<OrderDetails> listOrderDetails = new ArrayList<OrderDetails>();
	
}
package com.quanly.demo.model.entity;

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

import lombok.Data;

@Data
@Entity
@Table(name = "regimen_details")
public class RegimenDetails {
	
	@Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name = "regimen_details_id")	
	private int regimenDetailsId;
	
	@Column(name = "date_inject")
	@DateTimeFormat(pattern = "dd-MM-yyyy")
	private Date dateInject;
	
	@Column(name = "Quantity")	
	private Float quantity;
	
	@Column(name = "Inject")	
	private boolean inject;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "regimen_id")
	private Regimen regimenDetailsRegimen;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "product_details_id")
	private ProductDetails regimenDetailsProductDetails;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "customer_id")
	private Customer regimenDetailsCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "user_info_id")
	private UserInfo regimenDetailsUserInfo;
	
	@OneToMany(mappedBy = "orderDetailsRegimenDetails", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<OrderDetails> listOrderDetails = new ArrayList<OrderDetails>();
	
}

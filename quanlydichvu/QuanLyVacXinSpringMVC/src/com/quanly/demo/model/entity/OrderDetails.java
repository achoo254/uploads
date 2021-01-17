package com.quanly.demo.model.entity;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name = "order_details")
public class OrderDetails {
	@Id
	@Column(name = "order_details_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int orderDetailsId;
	
	@Column(name = "Quantity")
	private int quantity;
	
	@Column(name = "Price")
	private int price;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "order_id")
	private Orders orderDetailsOrder;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "regimen_details_id")
	private RegimenDetails orderDetailsRegimenDetails;
}

package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;

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

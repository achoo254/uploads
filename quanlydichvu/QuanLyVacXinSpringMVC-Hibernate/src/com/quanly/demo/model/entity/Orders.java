package com.quanly.demo.model.entity;

import java.util.ArrayList;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import org.springframework.format.annotation.DateTimeFormat;

import lombok.Data;

@Data
@Entity
@Table(name = "Orders")
public class Orders {
	@Id
	@Column(name = "OrderId")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int orderId;
	
	@Column(name = "DatePrinted")
	@Temporal(TemporalType.TIMESTAMP)
	private java.util.Date datePrinted;
	
	@Column(name = "Total")
	private int total;
	
	@OneToMany(mappedBy = "orderDetailsOrder", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<OrderDetails> listOrderDetails = new ArrayList<OrderDetails>();
}
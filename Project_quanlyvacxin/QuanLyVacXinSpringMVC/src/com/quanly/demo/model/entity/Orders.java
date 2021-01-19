package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "Orders")
public class Orders {
	@Id
	@Column(name = "order_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int orderId;
	
	@Column(name = "date_printed")
	@Temporal(TemporalType.TIMESTAMP)
	private java.util.Date datePrinted;
	
	@Column(name = "Total")
	private int total;
	
	@OneToMany(mappedBy = "orderDetailsOrder", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<OrderDetails> listOrderDetails = new ArrayList<OrderDetails>();
}

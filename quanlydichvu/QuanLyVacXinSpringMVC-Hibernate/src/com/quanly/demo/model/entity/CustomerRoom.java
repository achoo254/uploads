package com.quanly.demo.model.entity;

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
@Table(name = "CustomerRoom")
public class CustomerRoom {
	
	@Id
	@Column(name = "CustomerRoomId")	
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int customerRoomId;
	
	@Column(name = "Status", columnDefinition = "NVARCHAR(255)")	
	private String status;
	
	@Column(name = "OrderBy")	
	private int orderBy;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "customerId")
	private Customer customerRoomCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "roomId")
	private Room customerRoomRoom;
}

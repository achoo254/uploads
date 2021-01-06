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
@Table(name = "customer_room")
public class CustomerRoom {
	
	@Id
	@Column(name = "customer_room_id")	
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int customerRoomId;
	
	@Column(name = "Status", columnDefinition = "NVARCHAR(255)")	
	private String status;
	
	@Column(name = "order_by")	
	private int orderBy;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "customer_id")
	private Customer customerRoomCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "room_id")
	private Room customerRoomRoom;
}

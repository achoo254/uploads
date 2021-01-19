package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;

@Data
@Entity
@Table(name = "Notify")
public class Notify {
	@Id
	@Column(name = "notify_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int notifyId;
	
	@Column(name = "Details", columnDefinition = "NVARCHAR(255)")
	private String details;
	
	@Column(name = "Dates")
	@Temporal(TemporalType.TIMESTAMP)
	private java.util.Date dates;
	
	@Column(name = "Status", nullable = false)
	private boolean status;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "customer_id")
	private Customer notifyCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "room_id")
	private Room notifyRoom;
}

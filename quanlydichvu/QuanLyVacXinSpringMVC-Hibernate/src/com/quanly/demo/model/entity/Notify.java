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
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import org.springframework.format.annotation.DateTimeFormat;

import lombok.Data;

@Data
@Entity
@Table(name = "Notify")
public class Notify {
	@Id
	@Column(name = "NotifyId")
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
	@JoinColumn(name = "customerId")
	private Customer notifyCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "roomId")
	private Room notifyRoom;
}

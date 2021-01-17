package com.quanly.demo.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIdentityInfo;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.ObjectIdGenerators;

import lombok.Data;

@Data
@Entity
@Table(name = "CustomerRoom")
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler"})
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
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "customerId")
	private Customer customerRoomCustomer;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "roomId")
	private Room customerRoomRoom;
}

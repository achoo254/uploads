package com.quanly.demo.model;

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

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIdentityInfo;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.ObjectIdGenerators;

import lombok.Data;
import lombok.Getter;
import lombok.Setter;

@Data
@Entity
@Table(name = "Customer")
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler"})
public class Customer {
	
	@Id
	@Column(name = "CustomerId")	
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int customerId;
	
	@Column(name = "ContactName", columnDefinition = "NVARCHAR(255)")	
	private String contactName;
	
	@Column(name = "ContactPhone", columnDefinition = "NVARCHAR(255)")	
	private String contactPhone;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
	@JoinColumn(name = "userInfoId")
	private UserInfo customerUserInfo;
	
	@OneToMany(mappedBy = "customerRoomCustomer", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<CustomerRoom> listCustomerRoom = new ArrayList<CustomerRoom>();
	
	@OneToMany(mappedBy = "notifyCustomer", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<Notify> listNotify = new ArrayList<Notify>();
	
	@OneToMany(mappedBy = "regimenDetailsCustomer", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}
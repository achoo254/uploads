package com.quanly.demo.model.entity;

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

import lombok.Data;
import lombok.Getter;
import lombok.Setter;

@Data
@Entity
@Table(name = "Customer")
public class Customer {
	
	@Id
	@Column(name = "customer_id")	
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int customerId;
	
	@Column(name = "contact_name", columnDefinition = "NVARCHAR(255)")	
	private String contactName;
	
	@Column(name = "contact_phone", columnDefinition = "NVARCHAR(255)")	
	private String contactPhone;
	
	@ManyToOne(fetch = FetchType.LAZY, optional = false)
	@JoinColumn(name = "user_info_id")
	private UserInfo customerUserInfo;
	
	@OneToMany(mappedBy = "customerRoomCustomer", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<CustomerRoom> listCustomerRoom = new ArrayList<CustomerRoom>();
	
	@OneToMany(mappedBy = "notifyCustomer", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<Notify> listNotify = new ArrayList<Notify>();
	
	@OneToMany(mappedBy = "regimenDetailsCustomer", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}

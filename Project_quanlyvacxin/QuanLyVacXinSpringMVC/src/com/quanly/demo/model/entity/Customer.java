package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

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

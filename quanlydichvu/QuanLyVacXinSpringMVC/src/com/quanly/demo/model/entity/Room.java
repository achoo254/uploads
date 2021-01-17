package com.quanly.demo.model.entity;

import java.sql.Date;
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

@Data
@Entity
@Table(name = "Room")
public class Room {
	@Id
	@Column(name = "room_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int roomId;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")
	private String name;
	
	@Column(name = "Status")
	private boolean status;
	
	@Column(name = "Code", columnDefinition = "NVARCHAR(50)")
	private String code;

	@OneToMany(mappedBy = "customerRoomRoom", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<CustomerRoom> listCustomerRoom = new ArrayList<CustomerRoom>();

	@OneToMany(mappedBy = "notifyRoom", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<Notify> listNotify = new ArrayList<Notify>();
}

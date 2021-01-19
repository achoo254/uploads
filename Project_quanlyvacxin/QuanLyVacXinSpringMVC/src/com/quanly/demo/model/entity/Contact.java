package com.quanly.demo.model.entity;

import lombok.Data;

import javax.persistence.*;

@Data
@Entity
@Table(name = "Contact")
public class Contact {
	@Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name = "contact_id")	
	private int contactId;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")	
	private String name;
	
	@Column(name = "full_name", columnDefinition = "NVARCHAR(255)")	
	private String fullName;

	@Column(name = "Email", columnDefinition = "NVARCHAR(255)")	
	private String email;

	@Column(name = "Telephone", columnDefinition = "NVARCHAR(255)")	
	private String telephone;
	
	@Column(name = "Details", columnDefinition = "NTEXT")	
	private String details;
}

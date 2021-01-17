package com.quanly.demo.model;

import java.util.ArrayList;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import lombok.Data;

@Data
@Entity
@Table(name = "Contact")
@JsonIgnoreProperties({"hibernateLazyInitializer", "handler"})
public class Contact {
	@Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name = "ContactId")	
	private int contactId;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")	
	private String name;
	
	@Column(name = "FullName", columnDefinition = "NVARCHAR(255)")	
	private String fullName;

	@Column(name = "Email", columnDefinition = "NVARCHAR(255)")	
	private String email;

	@Column(name = "Telephone", columnDefinition = "NVARCHAR(255)")	
	private String telephone;
	
	@Column(name = "Details", columnDefinition = "NTEXT")	
	private String details;
}

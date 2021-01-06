package com.quanly.demo.model.entity;


import java.util.ArrayList;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name = "Regimen")
public class Regimen{
	@Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name = "regimen_id")	
	private int regimenId;
	
	@Column(name = "Name", columnDefinition = "NVARCHAR(255)")	
	private String name;
	
	@Column(name = "Details", columnDefinition = "NTEXT")	
	private String details;
	
	@OneToMany(mappedBy = "regimenDetailsRegimen", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}

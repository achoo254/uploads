package com.quanly.demo.model.dto;

import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.RegimenDetails;

import lombok.Data;

@Data
public class RegimenDto {
	private int regimenId;
	private String name;
	private String details;
	
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
}
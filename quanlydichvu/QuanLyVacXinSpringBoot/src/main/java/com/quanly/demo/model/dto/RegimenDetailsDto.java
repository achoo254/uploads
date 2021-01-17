package com.quanly.demo.model.dto;

import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.OrderDetails;
import com.quanly.demo.model.UserInfo;

import lombok.Data;

@Data
public class RegimenDetailsDto {
	private int regimenDetailsId;
	private Date dateInject;
	private Float quantity;
	private boolean inject;
	private RegimenDto regimenDetailsRegimen;
	private ProductDetailsDto regimenDetailsProductDetails;
	private CustomerDto regimenDetailsCustomer;
	private UserInfo regimenDetailsUserInfo;
	private List<OrderDetails> listOrderDetails = new ArrayList<OrderDetails>();
}

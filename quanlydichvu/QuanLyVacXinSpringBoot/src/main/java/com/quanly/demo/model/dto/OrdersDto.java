package com.quanly.demo.model.dto;

import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.OrderDetails;

import lombok.Data;

@Data
public class OrdersDto {
	private int orderId;
	private java.util.Date datePrinted;
	private int total;
	private List<OrderDetails> listOrderDetails = new ArrayList<OrderDetails>();
}

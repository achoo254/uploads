package com.quanly.demo.model.dto;

import com.quanly.demo.model.Customer;
import com.quanly.demo.model.Orders;
import com.quanly.demo.model.Product;

import lombok.Data;

@Data
public class OrderDetailsDto {
	private int orderDetailsId;
	private int quantity;
	private int price;
	private OrdersDto orderDetailsOrder;
	private RegimenDetailsDto orderDetailsRegimenDetails;
}

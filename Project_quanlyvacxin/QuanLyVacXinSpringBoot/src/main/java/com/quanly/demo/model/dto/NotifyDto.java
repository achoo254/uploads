package com.quanly.demo.model.dto;

import java.sql.Date;

import com.quanly.demo.model.Customer;
import com.quanly.demo.model.Room;
import com.quanly.demo.model.UserInfo;

import lombok.Data;

@Data
public class NotifyDto {
	private int notifyId;
	private String details;
	private java.util.Date dates;
	private boolean status;
	private CustomerDto notifyCustomer;
	private RoomDto notifyRoom;
}

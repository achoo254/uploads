package com.quanly.demo.model.dto;

import java.util.ArrayList;
import java.util.List;

import com.quanly.demo.model.CustomerRoom;
import com.quanly.demo.model.Notify;

import lombok.Data;

@Data
public class RoomDto {
	private int roomId;
	private String name;
	private boolean status;
	private String code;
	
	private List<CustomerRoom> listCustomerRoom = new ArrayList<CustomerRoom>();
}

package com.quanly.demo.api;

import java.util.List;

import javax.persistence.EntityNotFoundException;
import javax.validation.Valid;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.quanly.demo.mapper.MapperConvert;
import com.quanly.demo.model.OrderDetails;
import com.quanly.demo.model.Orders;
import com.quanly.demo.model.RegimenDetails;
import com.quanly.demo.model.Room;
import com.quanly.demo.model.dto.OrderDetailsDto;
import com.quanly.demo.model.dto.RegimenDetailsDto;
import com.quanly.demo.model.dto.RoomDto;
import com.quanly.demo.service.OrderDetailsService;
import com.quanly.demo.service.RegimenDetailsService;

@RestController
@CrossOrigin(origins = "*", allowedHeaders = "*")
@RequestMapping("/orderDetails")
public class OrderDetailsController {
	@Autowired
	OrderDetailsService orderDetailsService;
	
	@Autowired
	RegimenDetailsService regimenDetailsService;
	
	private final ModelMapper modelMapper = new ModelMapper();
	private final MapperConvert mapperConvert = new MapperConvert();
	
	@PostMapping(value = "/post/")
	public OrderDetails postOrderDetails(@Valid @RequestBody OrderDetails orderDetails) {
		return orderDetailsService.save(orderDetails);
	}
	
	@GetMapping(value = "/get/regimenDetailsId/{regimenDetailsId}")
	public boolean findById(@PathVariable("regimenDetailsId") int regimenDetailsId) {
		boolean checkExisted = false;
		RegimenDetails regimenDetails = regimenDetailsService.getOne(regimenDetailsId);
		OrderDetails orderDetails =  orderDetailsService.findByOrderDetailsRegimenDetails(regimenDetails);
		if(orderDetails != null) {
			checkExisted = true;	
		}
		return checkExisted;
	}
}

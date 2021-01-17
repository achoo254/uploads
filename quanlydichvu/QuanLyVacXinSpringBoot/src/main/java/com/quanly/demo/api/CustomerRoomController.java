package com.quanly.demo.api;

import java.util.List;

import javax.validation.Valid;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.quanly.demo.mapper.MapperConvert;
import com.quanly.demo.model.CustomerRoom;
import com.quanly.demo.model.Room;
import com.quanly.demo.model.UserInfo;
import com.quanly.demo.model.dto.CustomerRoomDto;
import com.quanly.demo.service.CustomerRoomService;
import com.quanly.demo.service.CustomerService;
import com.quanly.demo.service.RoomService;
import com.quanly.demo.service.UserInfoService;

@RestController
@CrossOrigin(origins = "*", allowedHeaders = "*")
@RequestMapping("/customerRoom")
public class CustomerRoomController {
	@Autowired
	CustomerRoomService customerRoomService;
	
	@Autowired
	RoomService roomService;
	
	@Autowired
	CustomerService customerService;
	
	@Autowired
	UserInfoService userInfoService;
	
	private final ModelMapper modelMapper = new ModelMapper();
	private final MapperConvert mapperConvert = new MapperConvert();
	
	@GetMapping(value = "/getAll/roomId/{roomId}")
	public ResponseEntity<List<CustomerRoomDto>> findByCustomerRoomRoom(@PathVariable("roomId") int roomId) {
		Room room = roomService.getOne(roomId);
		List<CustomerRoom> listCustomerRoom = customerRoomService.findByCustomerRoomRoom(room);
		if (listCustomerRoom.isEmpty()) {
			return new ResponseEntity(HttpStatus.NO_CONTENT);
		}
		//Mapped
		CustomerRoom customerRoom = new CustomerRoom(); 
		for (CustomerRoom item : listCustomerRoom) {
			customerRoom.setCustomerRoomCustomer(item.getCustomerRoomCustomer());
			customerRoom.getCustomerRoomCustomer().setCustomerUserInfo(item.getCustomerRoomCustomer().getCustomerUserInfo());
		}
		
		List<CustomerRoomDto> listCustomerRoomDto = mapperConvert.mapList(listCustomerRoom, CustomerRoomDto.class);
		for (CustomerRoomDto customerRoomDto : listCustomerRoomDto) {
			assert customerRoomDto.getCustomerRoomCustomer().equals(customerRoom.getCustomerRoomCustomer());
			assert customerRoomDto.getCustomerRoomCustomer().getCustomerUserInfo().equals(customerRoom.getCustomerRoomCustomer());
		}
		
		return new ResponseEntity<List<CustomerRoomDto>>(listCustomerRoomDto, HttpStatus.OK);
	}
	
	@GetMapping(value = "/getAll/")
	public ResponseEntity<List<CustomerRoomDto>> getAll() {
		List<CustomerRoom> listCustomerRoom = customerRoomService.findAll();
		if (listCustomerRoom.isEmpty()) {
			return new ResponseEntity(HttpStatus.NO_CONTENT);
		}
		List<CustomerRoomDto> listCustomerRoomDto = mapperConvert.mapList(listCustomerRoom, CustomerRoomDto.class);

		return new ResponseEntity<List<CustomerRoomDto>>(listCustomerRoomDto, HttpStatus.OK);
	}
	
	@GetMapping(value = "/get/{id}")
	public CustomerRoomDto getOne(@PathVariable("id") int id) {
		CustomerRoom customerRoom = customerRoomService.getOne(id);
		if (customerRoom == null) {
			ResponseEntity.notFound().build();
		}
		//Mapped
		CustomerRoomDto customerRoomDto = modelMapper.map(customerRoom, CustomerRoomDto.class);
		
		return customerRoomDto;
	}

	@GetMapping(value = "/get/orderBy/{room_id}")
	public int getOrderBy(@PathVariable("room_id") int room_id) {
		int customerRoom = customerRoomService.getOrderBy(room_id);
		return customerRoom;
	}

	@PostMapping(value = "/post/")
	public CustomerRoom postCustomerRoom(@Valid @RequestBody CustomerRoom customerRoom) {
		return customerRoomService.save(customerRoom);
	}
	
	@PutMapping(value = "/put/{customerRoomId}")
	public ResponseEntity<CustomerRoom> putCustomerRoom(@PathVariable(value = "customerRoomId") int customerRoomId,
			@Valid @RequestBody CustomerRoom customerRoomForm) {
		CustomerRoom customerRoom = customerRoomService.getOne(customerRoomId);

		if (customerRoom == null) {
			return ResponseEntity.notFound().build();
		}
		
		customerRoom.setStatus(customerRoomForm.getStatus());
		customerRoom.setOrderBy(customerRoomForm.getOrderBy());
		customerRoom.setCustomerRoomRoom(customerRoomForm.getCustomerRoomRoom());
		customerRoom.setCustomerRoomCustomer(customerRoomForm.getCustomerRoomCustomer());

		CustomerRoom updatedcustomerRoom = customerRoomService.save(customerRoom);
		return ResponseEntity.ok(updatedcustomerRoom);
	}
	
	//Hàm xóa tất cả khách hàng đang ở trong phòng nên cần kiểm tra người thực hiện
	@DeleteMapping(value = "/deleteAll/{token}")
	public boolean delete(@PathVariable(value = "token") String token) {
		boolean check;
		try {
			UserInfo user = userInfoService.findTop1ByToken(token);
			if (user == null) {
				check = false;
				ResponseEntity.notFound().build();
			}
			else {
				customerRoomService.deleteAll();
				check = true;	
			}
		} catch (Exception e) {
			check = false;
		}
		return check;
	}
}

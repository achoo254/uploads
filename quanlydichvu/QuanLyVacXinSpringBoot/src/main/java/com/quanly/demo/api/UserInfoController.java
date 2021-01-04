package com.quanly.demo.api;


import java.util.List;

import javax.validation.Valid;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.quanly.demo.mapper.MapperConvert;
import com.quanly.demo.model.Customer;
import com.quanly.demo.model.Room;
import com.quanly.demo.model.UserInfo;
import com.quanly.demo.model.dto.CustomerDto;
import com.quanly.demo.model.dto.RoomDto;
import com.quanly.demo.model.dto.UserInfoDto;
import com.quanly.demo.service.CustomerService;
import com.quanly.demo.service.UserInfoService;

import lombok.CustomLog;

@RestController
@CrossOrigin(origins = "*", allowedHeaders = "*")
@RequestMapping("/userInfo")
public class UserInfoController {
	@Autowired
	UserInfoService userInfoService;
	
	@Autowired
	CustomerService customerSerivce;
	
	private final ModelMapper modelMapper = new ModelMapper();
	private final MapperConvert mapperConvert = new MapperConvert();
	
	@GetMapping(value = "/getAll/")
	public ResponseEntity<List<UserInfoDto>> listUserInfo() {
		List<UserInfo> listUserInfo = userInfoService.findAll();
		if (listUserInfo.isEmpty()) {
			return new ResponseEntity(HttpStatus.NO_CONTENT);
		}
		//Mapped
		List<UserInfoDto> listUserInfoDto = mapperConvert.mapList(listUserInfo, UserInfoDto.class);
		
		return new ResponseEntity<List<UserInfoDto>>(listUserInfoDto, HttpStatus.OK);
	}
	
	@GetMapping(value = "/get/telephone/{telephone}")
	public boolean findByTelephone(@PathVariable("telephone") String telephone) {
		boolean isExist;
		UserInfo userInfo = userInfoService.findTop1ByTelephone(telephone);
		if (userInfo == null) {
			isExist = false;
			ResponseEntity.notFound().build();
		}
		else {
			isExist = true;
		}
		
		return isExist;
	}
	
	@GetMapping(value = "/get/email/{email}")
	public boolean findByEmail(@PathVariable("email") String email) {
		boolean isExist;
		UserInfo userInfo = userInfoService.findTop1ByEmail(email);
		if (userInfo == null) {
			isExist = false;
			ResponseEntity.notFound().build();
		}
		else {
			isExist = true;
		}
		
		return isExist;
	}

	@GetMapping(value = "/get/token/{token}")
	public UserInfoDto findByToken(@PathVariable("token") String token) {
		UserInfo userInfo = userInfoService.findTop1ByToken(token);
		UserInfoDto userInfoDto = null;
		if (userInfo == null) {
			ResponseEntity.notFound().build();
		}
		else {
			//Mapped
			userInfoDto = modelMapper.map(userInfo, UserInfoDto.class);	
		}

		return userInfoDto;
	}
	
	@GetMapping(value = "/get/token/{token}/roles/{roles}")
	public boolean findByTokenAndRoles(@PathVariable("token") String token, @PathVariable("roles") String roles) {
		boolean isExist;
		UserInfo userInfo = userInfoService.findTop1ByTokenAndRoles(token, roles);
		if (userInfo == null) {
			isExist = false;
			ResponseEntity.notFound().build();
		}
		else {
			isExist = true;
		}
		
		return isExist;
	}

	@GetMapping(value = "/get/{id}")
	public UserInfoDto getOne(@PathVariable("id") int id) {
		UserInfo userInfo = userInfoService.getOne(id);
		UserInfoDto userInfoDto = null;
		if (userInfo == null) {
			ResponseEntity.notFound().build();
		}
		else {
			//Mapped
			userInfoDto = modelMapper.map(userInfo, UserInfoDto.class);	
		}
		return userInfoDto;
	}

	@PostMapping(value = "/post/")
	public UserInfo postUserInfo(@Valid @RequestBody UserInfo userInfo) {
		return userInfoService.save(userInfo);
	}
	
	@PutMapping(value = "/put/{id}")
	public ResponseEntity<UserInfo> putUserInfo(@PathVariable(value = "id") int userInfoId, @Valid @RequestBody UserInfo form) {
		UserInfo userInfo = userInfoService.getOne(userInfoId);
		if (userInfo == null) {
			return ResponseEntity.notFound().build();
		}
		
		userInfo.setAddress(form.getAddress());
		userInfo.setAge(form.getAge());
		userInfo.setBirthday(form.getBirthday());
		userInfo.setFullName(form.getFullName());
		userInfo.setTelephone(form.getTelephone());

		UserInfo updatedUserInfo = userInfoService.save(userInfo);
		return ResponseEntity.ok(updatedUserInfo);
	}
	
	@PutMapping(value = "/put/password/{id}")
	public ResponseEntity<UserInfo> putPassword(@PathVariable(value = "id") int userInfoId, @Valid @RequestBody UserInfo form) {
		UserInfo userInfo = userInfoService.getOne(userInfoId);
		if (userInfo == null) {
			return ResponseEntity.notFound().build();
		}
		
		userInfo.setToken(form.getToken());
		userInfo.setPassword(form.getPassword());

		UserInfo updatedUserInfo = userInfoService.save(userInfo);
		return ResponseEntity.ok(updatedUserInfo);
	}
	
	@PutMapping(value = "/put/roles/{id}")
	public ResponseEntity<UserInfo> putRoles(@PathVariable(value = "id") int userInfoId, @Valid @RequestBody UserInfo form) {
		UserInfo userInfo = userInfoService.getOne(userInfoId);
		if (userInfo == null) {
			return ResponseEntity.notFound().build();
		}
		
		userInfo.setRoles(form.getRoles());

		UserInfo updatedUserInfo = userInfoService.save(userInfo);
		return ResponseEntity.ok(updatedUserInfo);
	}

//		@RequestMapping(value = "/userInfo/{id}", method = RequestMethod.DELETE)
//		public ResponseEntity<UserInfo> deleteuserInfo(@PathVariable(value = "id") int id) {
//			UserInfo userInfo = userInfoService.getOne(id);
//			if (userInfo == null) {
//				return ResponseEntity.notFound().build();
//			}
//
//			userInfoService.delete(userInfo);
//			return ResponseEntity.ok().build();
//		}
}
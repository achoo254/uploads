package com.quanly.demo.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;

@Controller
@RequestMapping(value="userInfoController")
public class UserInfoController {
	@Autowired
	private UserInfoService userInfoService;
	
	@GetMapping(value="initLogin.htm")
	public ModelAndView initLogin() {
		boolean check = false;
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("login");
		//Khai báo đối tượng object
		UserInfo userInfo = new UserInfo();
		//add doi tuong vao mav
		mav.addObject("userInfo", userInfo);
		return mav;
	}
	
	@GetMapping(value="login.htm")
	public String login(String token) {
		boolean check = false;
		//Goi sang service de lay doi tuong
		List<UserInfo> list = userInfoService.getAllUserInfo();
		for (UserInfo item : list) {
			if(item.getToken().equals(token)) {
				check = true;
				break;
			}
		}
		if(check) {
			return "redirect:index.htm";
		}
		else {
			return "trangloi";
		}
	}	
}

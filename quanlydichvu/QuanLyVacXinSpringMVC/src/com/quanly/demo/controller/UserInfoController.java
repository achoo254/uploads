package com.quanly.demo.controller;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;

@Controller
@RequestMapping(value="admin")
public class UserInfoController {
	@Autowired
	private UserInfoService userInfoService;
	
	@GetMapping(value="/userInfoDetails/{userInfoId}")//Private access
	public ModelAndView userInfoDetails(@PathVariable("userInfoId") int userInfoId) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		UserInfo user = userInfoService.getUserInfoById(userInfoId);
		if(user != null) {
			//Khai bao doi tuong mav
			mav = new ModelAndView("userinfodetails");
			//add doi tuong vao mav
			mav.addObject("userInfo",  user);	
		}
		else {
			mav = new ModelAndView("redirect:/errorController/error404");
		}
		return mav;
	}
	
	@PostMapping(value="/userInfoDetails/updateUserInfoDetails")
	public ModelAndView updateUserInfoDetails(@ModelAttribute("userInfo") UserInfo userInfo, HttpSession session) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		UserInfo user = userInfoService.getUserInfoById(userInfo.getUserInfoId());
		if(user != null) {
			//update (khong update pass, token)
			userInfo.setPassword(user.getPassword());
			userInfo.setToken(user.getToken());
			boolean check = userInfoService.merge(userInfo);
			if(check) {
				//Lấy lại thông tin sau khi update
				UserInfo userUpdate = userInfoService.getUserInfoById(user.getUserInfoId());
				//Reset lại fullName
				session.removeAttribute("fullName");
				session.setAttribute("fullName", userUpdate.getFullName());
				//Khai bao doi tuong mav
				mav = new ModelAndView("userinfodetails");
				//add doi tuong vao mav
				mav.addObject("userInfo",  userUpdate);					
			}
			else {
				mav = new ModelAndView("redirect:/errorController/error404");
			}
		}
		else {
			mav = new ModelAndView("redirect:/errorController/error404");
		}
		return mav;
	}	
}
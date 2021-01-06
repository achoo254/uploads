package com.quanly.demo.controller;

import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.util.Enumeration;
import java.util.List;

import javax.servlet.ServletContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.servlet.http.HttpSessionContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.SessionAttribute;
import org.springframework.web.bind.annotation.SessionAttributes;
import org.springframework.web.context.request.RequestAttributes;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;
import com.quanly.demo.ultis.GlobalFunctions;
import com.quanly.demo.ultis.MD5Utils;

@Controller
@RequestMapping(value="userInfoController")
public class UserInfoController {
	@Autowired
	private UserInfoService userInfoService;
	
	private UserInfo userInfo = null;
	
	@GetMapping(value="/initLogin")
	public ModelAndView initLogin() {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("login");
		//Khai báo đối tượng object
		userInfo = new UserInfo();
		//add doi tuong vao mav
		mav.addObject("userInfo", userInfo);
		return mav;
	}
	
	@PostMapping(value="/login")
	public ModelAndView login(@ModelAttribute("userInfo") UserInfo form, RedirectAttributes redirectAttributes, HttpSession session) {
		List<UserInfo> list = userInfoService.getAllUserInfo();
		boolean check = GlobalFunctions.checkLogin(list, form, session, redirectAttributes);
		if(check) {
			userInfo = userInfoService.getUserInfo(session.getAttribute("token").toString());
			//Gọi hàm globals để tạo 2 session lưu tên và id
			GlobalFunctions.getUserInfo(session, userInfo);
			return new ModelAndView("redirect:/mainController/index");
		}
		else {
			return new ModelAndView("redirect:/errorController/error404");
		}
	}
	
	@GetMapping(value="/userInfoDetails/{userInfoId}")
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
	public ModelAndView updateUserInfoDetails(@ModelAttribute("userInfo") UserInfo userInfo) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		UserInfo user = userInfoService.getUserInfoById(userInfo.getUserInfoId());
		if(user != null) {
			//update
			boolean check = userInfoService.merge(user);
			if(check) {
				//Lấy lại thông tin sau khi update
				UserInfo userUpdate = userInfoService.getUserInfoById(user.getUserInfoId());
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
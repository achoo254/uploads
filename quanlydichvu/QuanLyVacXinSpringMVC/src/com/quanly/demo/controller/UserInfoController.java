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
	
	@GetMapping(value="/initLogin")//Public access
	public ModelAndView initLogin() {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("login");
		//Khai báo đối tượng object
		UserInfo userInfo = new UserInfo();
		//add doi tuong vao mav
		mav.addObject("userInfo", userInfo);
		return mav;
	}
	
	@GetMapping(value="/logout")//Public access
	public ModelAndView logout(HttpSession session) {
		if(session != null) {
			session.invalidate();
		}
		return new ModelAndView("redirect:/userInfoController/initLogin");
	}	
	
	@PostMapping(value="/login")//Process login
	public ModelAndView login(@ModelAttribute("userInfo") UserInfo form, HttpSession session) {
		UserInfo user = userInfoService.getUserInfoByTelephone(form.getTelephone());
		if(user != null) {
			boolean check = GlobalFunctions.checkLogin(user, form, session);
			if(check) {
				//Gọi hàm globals để tạo 2 session lưu tên và id
				GlobalFunctions.getUserInfo(session, user);
				return new ModelAndView("redirect:/mainController/index");
			}
		}
		else {
			return new ModelAndView("redirect:/errorController/error404");
		}
		return new ModelAndView("redirect:/errorController/error404");
	}
	
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
	public ModelAndView updateUserInfoDetails(@ModelAttribute("userInfo") UserInfo userInfo) {
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
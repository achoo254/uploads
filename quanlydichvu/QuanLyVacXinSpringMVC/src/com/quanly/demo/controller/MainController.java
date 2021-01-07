package com.quanly.demo.controller;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;
import com.quanly.demo.ultis.GlobalFunctions;

@Controller
public class MainController {
	@Autowired
	UserInfoService userInfoService;
	
	@GetMapping(value="/initLogin")//Public access
	public ModelAndView initLogin(final Model model) {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("login");
		//Khai báo đối tượng object
		UserInfo userInfo = new UserInfo();
		//add doi tuong vao mav
		//mav.addObject("userInfo", userInfo);
		return mav;
	}
	
	@GetMapping(value="/logout")//Public access
	public ModelAndView logout(HttpSession session) {
		if(session != null) {
			session.invalidate();
		}
		return new ModelAndView("redirect:/initLogin");
	}	
	
	@GetMapping(value="/admin/index")//private access
	public ModelAndView index(HttpSession session) {
		Object principal = SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		String telephone = "";
		if (principal instanceof UserDetails) {
			telephone = ((UserDetails)principal).getUsername();
		} else {
			telephone = principal.toString();
		}
		//Lấy thông tin object từ principal
		UserInfo user = userInfoService.getUserInfoByTelephone(telephone);
		if(user != null) {
			session.setAttribute("fullName", user.getFullName());
			session.setAttribute("userInfoId", user.getUserInfoId());
		}
		return new ModelAndView("index");
	}
}

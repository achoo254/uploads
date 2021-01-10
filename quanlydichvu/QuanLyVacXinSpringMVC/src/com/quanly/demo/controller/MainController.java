package com.quanly.demo.controller;

import java.text.DecimalFormat;
import java.util.List;

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

import com.quanly.demo.model.dao.OrdersDao;
import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.entity.Contact;
import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.ContactService;
import com.quanly.demo.model.service.OrdersService;
import com.quanly.demo.model.service.ProductDetailsService;
import com.quanly.demo.model.service.UserInfoService;
import com.quanly.demo.ultis.GlobalFunctions;

@Controller
public class MainController {
	@Autowired
	UserInfoService userInfoService;
	
	@Autowired
	OrdersService ordersService;
	
	@Autowired
	ProductDetailsService productDetailsService;
	
	@Autowired
	ContactService contactService;
	
	@GetMapping(value="/initLogin")//Public access
	public ModelAndView initLogin(final Model model) {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("login");
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
	public ModelAndView index(HttpSession session, Integer offset, Integer maxResults) {
		ModelAndView mav = new ModelAndView("index");
		Object principal = SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		String telephone = "";
		DecimalFormat formatter = new DecimalFormat("###,###,###");
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
		//Lấy thông tin khách hàng online
		int countOnline = 0;
		List<UserInfo> listUserOnline = userInfoService.getAllUserInfo(null, null);
		for (UserInfo userOnline : listUserOnline) {
			if(userOnline.isStatus() == true) {
				countOnline++;
			}
			else {
				countOnline--;
			}
		}
		//Lấy tổng thu
		Long sumOrders = ordersService.sumTotal();
		//Lấy tổng chi
		Double sumProductDetails = productDetailsService.sumProductDetails();
		//Lấy góp ý
		Long countContact = contactService.countContact();
		//Lấy danh sách góp ý
		List<Contact> listContact = contactService.getAllContact(offset, maxResults);
		//Lấy danh sách tóp 5 đắng ký
		List<UserInfo> listUserInfo = userInfoService.getTop5UserInfo();
		
		mav.addObject("countOnline", countOnline);
		mav.addObject("sumOrders", formatter.format(sumOrders) + "VNĐ");
		mav.addObject("sumProductDetails", formatter.format(sumProductDetails) + "VNĐ");
		mav.addObject("countContact", countContact);
		mav.addObject("listContact", listContact);
		mav.addObject("listUserInfo",listUserInfo);
		return mav;
	}
}

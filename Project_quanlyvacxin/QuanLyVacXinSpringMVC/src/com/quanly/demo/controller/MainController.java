package com.quanly.demo.controller;

import com.quanly.demo.model.entity.Contact;
import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.ContactService;
import com.quanly.demo.model.service.OrdersService;
import com.quanly.demo.model.service.ProductDetailsService;
import com.quanly.demo.model.service.UserInfoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.servlet.ModelAndView;

import javax.servlet.http.HttpSession;
import java.text.DecimalFormat;
import java.util.List;

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
	

	BCryptPasswordEncoder passwordEncoder;
	
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
		//Lấy thông tin object từ principal
		Object principal = SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		String telephone = "";
		DecimalFormat formatter = new DecimalFormat("###,###,###");
		if (principal instanceof UserDetails) {
			telephone = ((UserDetails)principal).getUsername();
		} else {
			telephone = principal.toString();
		}
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
		Long sumOrders = (ordersService.sumTotal() != null) ? ordersService.sumTotal() : 0;
		//Lấy tổng chi
		Double sumProductDetails = (productDetailsService.sumProductDetails() != null) ? productDetailsService.sumProductDetails() : 0 ;
		//Lấy góp ý
		Long countContact = (contactService.countContact() != null) ? contactService.countContact() : 0;
		//Lấy danh sách góp ý
		List<Contact> listContact = contactService.getAllContact(offset, maxResults);
		//Lấy danh sách tóp 5 đắng ký
		List<UserInfo> listUserInfo = userInfoService.getTop5UserInfo();
		
		mav.addObject("countOnline", countOnline);
		mav.addObject("sumOrders", formatter.format(sumOrders));
		mav.addObject("sumProductDetails", formatter.format(sumProductDetails));
		mav.addObject("countContact", countContact);
		mav.addObject("listContact", listContact);
		mav.addObject("listUserInfo",listUserInfo);
		return mav;
	}
}

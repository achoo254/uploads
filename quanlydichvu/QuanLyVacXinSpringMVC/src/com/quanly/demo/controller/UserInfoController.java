package com.quanly.demo.controller;

import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.util.List;

import javax.servlet.http.HttpServletResponse;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;
import com.quanly.demo.ultis.MD5Utils;

@Controller
@RequestMapping(value="userInfoController")
public class UserInfoController {
	@Autowired
	private UserInfoService userInfoService;
	
    private static final Charset UTF_8 = StandardCharsets.UTF_8;
    private static final String OUTPUT_FORMAT = "%-20s:%s";	
	
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
	
	@PostMapping(value="login.htm")
	public String login(UserInfo form) {
		boolean check = false;
		//Goi sang service de lay doi tuong
		List<UserInfo> list = userInfoService.getAllUserInfo();
		for (UserInfo item : list) {
//			if(item.getToken().equals(token)) {
//				check = true;
//				break;
//			}
			byte[] md5InBytes = MD5Utils.digest(form.getPassword().getBytes(UTF_8));
			System.out.println("server:"+item.getTelephone());
			System.out.println("client:"+form.getTelephone());
			System.out.println("server:"+item.getPassword());
			System.out.println("client:"+MD5Utils.bytesToHex(md5InBytes));
			if(item.getTelephone().equals(form.getTelephone()) && item.getPassword().equals(MD5Utils.bytesToHex(md5InBytes))) {
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
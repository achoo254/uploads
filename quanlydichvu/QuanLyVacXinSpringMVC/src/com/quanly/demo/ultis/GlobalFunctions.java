package com.quanly.demo.ultis;

import java.util.List;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;

public class GlobalFunctions {

	public static boolean checkLogin(UserInfo user, UserInfo userInfo, HttpSession session) {
		boolean check = false;
		//Mã hóa mật khẩu
		String initConvertPass = MD5Utils.getMd5(userInfo.getPassword());
		//Convert sang token
		String token = MD5Utils.getMd5(initConvertPass + userInfo.getTelephone());
		if(user.getToken().equals(token)) {
			session.setAttribute("token", user.getToken());
			check = true;
		}
		return check;
	}
	
	public static void getUserInfo(HttpSession session, UserInfo user) {
		if(session != null) {
			if(session.getAttribute("token") != null) {
				session.setAttribute("fullName", user.getFullName());
				session.setAttribute("userInfoId", user.getUserInfoId());
			}
		}
	}
	
	public static void clearSession(HttpSession session) {
		if(session != null) {
			session.invalidate();
		}
	}
	
	public static String baseUrl() {
		final String baseUrl = ServletUriComponentsBuilder.fromCurrentContextPath().build().toUriString();
		return baseUrl;
	}
}

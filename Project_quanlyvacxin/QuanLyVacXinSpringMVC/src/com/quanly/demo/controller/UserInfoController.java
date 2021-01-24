package com.quanly.demo.controller;

import com.quanly.demo.model.entity.Regimen;
import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;
import com.quanly.demo.ultis.GlobalFunctions;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import javax.servlet.http.HttpSession;
import java.util.List;

@Controller
@RequestMapping(value="admin")//Private access
public class UserInfoController {
	@Autowired
	private UserInfoService userInfoService;
	
	@GetMapping(value="/userInfo")
	public ModelAndView userInfo(@ModelAttribute("isDeleteAdmin") String alert, @ModelAttribute("isDelete") String alert2, Integer offset, Integer maxResults) {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("userinfo");
		//Khai báo list đối tượng object
		List<UserInfo> listUserInfo = userInfoService.getAllUserInfo(offset, maxResults);
		//add doi tuong vao mav
		mav.addObject("listUserInfo", listUserInfo);
		mav.addObject("alert", alert);
		mav.addObject("alert2", alert2);
		//Phan trang
		mav.addObject("count", userInfoService.count());
		mav.addObject("offset", offset);
		return mav;
	}
	
	@GetMapping(value="/search", params = {"telephone"})
	public String searchUserInfo(@RequestParam(value="telephone") String telephone) {
		//Danh dau tim kiem
		boolean check;
		UserInfo user = userInfoService.getUserInfoByTelephone(telephone);
		if(user != null) {
			return "redirect:/admin/userInfoDetails/"+user.getUserInfoId();
		}
		return "redirect:/admin/userInfo";
	}
	
	@GetMapping(value="/delete", params = {"userInfoId"})
	public String deleteUserInfo(@RequestParam(value="userInfoId") int userInfoId, HttpSession session, RedirectAttributes ra) {
		//Chặn không cho xóa ROLE_ADMIN
		if(userInfoId != Integer.parseInt(session.getAttribute("userInfoId").toString())) {
			//Thực hiện xóa
			boolean check = userInfoService.delete(userInfoId);
			if(check) {
				//Tải lại trang
				return "redirect:/admin/userInfo";
			}
		}
		else {
			ra.addAttribute("isDeleteAdmin", GlobalFunctions.cancelDeleteAdmin);
			return "redirect:/admin/userInfo";
		}
		ra.addAttribute("isDelete", GlobalFunctions.cancelDelete);
		return "redirect:/admin/userInfo";
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
	
	@GetMapping(value="/changePassword/{userInfoId}")
	public ModelAndView changePassword(@PathVariable("userInfoId") int userInfoId, @ModelAttribute("wrongPassword") String alert) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		UserInfo user = userInfoService.getUserInfoById(userInfoId);
		if(user != null) {
			//Khai bao doi tuong mav
			mav = new ModelAndView("changepassword");
			//add doi tuong vao mav
			mav.addObject("userInfo",  user);	
			mav.addObject("alert", alert);
		}
		else {
			mav = new ModelAndView("redirect:/errorController/error404");
		}
		return mav;
	}
	
	@PostMapping(value="/changePassword/updatePassword")
	public ModelAndView updatePassword(@ModelAttribute("userInfo") UserInfo userInfo, HttpSession session, RedirectAttributes ra) {
		//Khai báo mới mav
		ModelAndView mav = null;
		BCryptPasswordEncoder passwordEncoder = new BCryptPasswordEncoder();
		//Kiểm tra trong CSDL có ID không
		UserInfo user = userInfoService.getUserInfoById(userInfo.getUserInfoId());
		if(user != null) {
			//Kiểm tra mật khẩu cũ hợp lệ không
			if(!passwordEncoder.matches(userInfo.getPassword(), user.getPassword())){
				ra.addAttribute("wrongPassword", GlobalFunctions.wrongPassword);
				return new ModelAndView("redirect:../changePassword/"+user.getUserInfoId());
			}
			else {
				//update (chỉ update password và token)
				user.setPassword(passwordEncoder.encode(userInfo.getToken()));
				user.setToken(passwordEncoder.encode(userInfo.getToken()));
				boolean check = userInfoService.merge(user);
				if(check) {
					//Lấy lại thông tin sau khi update
					UserInfo userUpdate = userInfoService.getUserInfoById(user.getUserInfoId());
					//Reset lại fullName
					session.removeAttribute("fullName");
					session.setAttribute("fullName", userUpdate.getFullName());
					//Khai bao doi tuong mav
					mav = new ModelAndView("changepassword");
					//add doi tuong vao mav
					mav.addObject("userInfo",  userUpdate);
				}
				else {
					mav = new ModelAndView("redirect:/errorController/error404");
				}	
			}
		}
		else {
			mav = new ModelAndView("redirect:/errorController/error404");
		}
		return mav;
	}
}
package com.quanly.demo.controller;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.quanly.demo.model.entity.UserInfo;

@Controller
@RequestMapping(value="mainController")
public class MainController {
	
	@GetMapping(value="/index")
	public ModelAndView index(@ModelAttribute("flashUserInfo") UserInfo userInfo, HttpSession session, Model model) {
		if(session.getAttribute("token")== null) {
			return new ModelAndView("redirect:/userInfoController/initLogin");
		}
		else {
			//model.addAttribute("flashUserInfo", userInfo);
			return new ModelAndView("index");
		}
	}
}

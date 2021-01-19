package com.quanly.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
@RequestMapping(value="errorController")
public class ErrorController {
	@GetMapping(value="/error404")
	public ModelAndView error404() {
		return new ModelAndView("404");
	}
}

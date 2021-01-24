package com.quanly.demo.controller;

import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.service.CategoriesService;
import com.quanly.demo.ultis.GlobalFunctions;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import java.util.List;

@Controller
@RequestMapping(value="admin")//Private access
public class CategoriesController {
	@Autowired
	private CategoriesService categoriesService;
	
	@GetMapping(value="/categories")
	public ModelAndView categories(@ModelAttribute("isDelete") String alert2, Integer offset, Integer maxResults) {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("categories");
		//Khai báo list đối tượng object
		List<Categories> list = categoriesService.getAllCategories(offset, maxResults);
		//add doi tuong vao mav
		mav.addObject("listCategories", list);
		mav.addObject("alert2", alert2);
		//Phan trang
		mav.addObject("count", categoriesService.count());
		mav.addObject("offset", offset);
		return mav;
	}
	
	@GetMapping(value="/searchCategories", params = {"name"})
	public String searchCategories(@RequestParam(value="name") String name) {
		//Danh dau tim kiem
		boolean check;
		Categories cate = categoriesService.findByName(name);
		if(cate != null) {
			return "redirect:/admin/categoriesDetails/"+cate.getCategoriesId();
		}
		return "redirect:/admin/categories";
	}
	
	@GetMapping(value="/deleteCategories", params = {"categoriesId"})
	public String deleteCategories(@RequestParam(value="categoriesId") int categoriesId, RedirectAttributes ra) {
		boolean check = categoriesService.delete(categoriesId);
		if(check) {
			//Tải lại trang
			return "redirect:/admin/categories";
		}
		else {
			ra.addAttribute("isDelete", GlobalFunctions.cancelDelete);
			return "redirect:/admin/categories";
		}
	}
	
	@GetMapping(value="/categoriesDetails/{categoriesId}")
	public ModelAndView categoriesDetails(@PathVariable("categoriesId") int categoriesId) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		Categories cate = categoriesService.getCategories(categoriesId);
		if(cate != null) {
			//Khai bao doi tuong mav
			mav = new ModelAndView("categoriesdetails");
			//add doi tuong vao mav
			mav.addObject("categories",  cate);	
		}
		else {
			mav = new ModelAndView("redirect:/errorController/error404");
		}
		return mav;
	}
	
	@PostMapping(value="/categoriesDetails/updateCategoriesDetails")
	public ModelAndView updateCategoriesDetails(@ModelAttribute("categories") Categories categories) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		Categories cate = categoriesService.getCategories(categories.getCategoriesId());
		if(cate != null) {
			//update
			cate.setName(categories.getName());
			cate.setDetails(categories.getDetails());
			boolean check = categoriesService.merge(cate);
			if(check) {
				//Lấy lại thông tin sau khi update
				Categories cateUpdate = categoriesService.getCategories(cate.getCategoriesId());
				//Khai bao doi tuong mav
				mav = new ModelAndView("categoriesdetails");
				//add doi tuong vao mav
				mav.addObject("categories",  cateUpdate);
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
	
	@PostMapping(value="/addCategories")
	public String addCategories(RedirectAttributes ra) {
		//Khai báo mới mav
		Categories cate = new Categories();
		boolean check = categoriesService.save(cate);
		if(check) {
			//Lấy lại thông tin sau khi add
			return "redirect:/admin/categoriesDetails/" + cate.getCategoriesId();
		}
		else {
			return "redirect:/errorController/error404";
		}
	}
}

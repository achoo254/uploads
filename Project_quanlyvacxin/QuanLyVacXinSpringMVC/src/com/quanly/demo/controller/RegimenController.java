package com.quanly.demo.controller;

import com.quanly.demo.model.entity.Regimen;
import com.quanly.demo.model.service.RegimenService;
import com.quanly.demo.ultis.GlobalFunctions;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import java.util.List;

@Controller
@RequestMapping(value="admin")//Private access
public class RegimenController {
	@Autowired
	private RegimenService regimenService;
	
	@GetMapping(value="/regimen")
	public ModelAndView regimen(@ModelAttribute("isDelete") String alert2, Integer offset, Integer maxResults) {
		//Khai bao doi tuong mav
		ModelAndView mav = new ModelAndView("regimen");
		//Khai báo list đối tượng object
		List<Regimen> list = regimenService.getAllRegimen(offset, maxResults);
		//add doi tuong vao mav
		mav.addObject("listRegimen", list);
		mav.addObject("alert2", alert2);
		//Phan trang
		mav.addObject("count", regimenService.count());
		mav.addObject("offset", offset);
		return mav;
	}
	
	@GetMapping(value="/searchRegimen", params = {"name"})
	public String searchRegimen(@RequestParam(value="name") String name) {
		//Danh dau tim kiem
		boolean check;
		Regimen regimen = regimenService.findByName(name);
		if(regimen != null) {
			return "redirect:/admin/regimenDetails/"+regimen.getRegimenId();
		}
		return "redirect:/admin/regimen";
	}
	
	@GetMapping(value="/deleteRegimen", params = {"regimenId"})
	public String deleteRegimen(@RequestParam(value="regimenId") int regimenId, RedirectAttributes ra) {
		boolean check = regimenService.delete(regimenId);
		if(check) {
			//Tải lại trang
			return "redirect:/admin/regimen";
		}
		else {
			ra.addAttribute("isDelete", GlobalFunctions.cancelDelete);
			return "redirect:/admin/regimen";
		}
	}
	
	@GetMapping(value="/regimenDetails/{regimenId}")
	public ModelAndView regimenDetails(@PathVariable("regimenId") int regimenId) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		Regimen regimen = regimenService.getRegimen(regimenId);
		if(regimen != null) {
			//Khai bao doi tuong mav
			mav = new ModelAndView("regimendetails");
			//add doi tuong vao mav
			mav.addObject("regimen",  regimen);	
		}
		else {
			mav = new ModelAndView("redirect:/errorController/error404");
		}
		return mav;
	}
	
	@PostMapping(value="/regimenDetails/updateRegimenDetails")
	public ModelAndView updateRegimenDetails(@ModelAttribute("regimen") Regimen obj) {
		//Khai báo mới mav
		ModelAndView mav = null;
		//Kiểm tra trong CSDL có ID không
		Regimen regimen = regimenService.getRegimen(obj.getRegimenId());
		if(regimen != null) {
			//update
			regimen.setName(obj.getName());
			regimen.setDetails(obj.getDetails());
			boolean check = regimenService.merge(regimen);
			if(check) {
				//Lấy lại thông tin sau khi update
				Regimen regimenUpdate = regimenService.getRegimen(regimen.getRegimenId());
				//Khai bao doi tuong mav
				mav = new ModelAndView("regimendetails");
				//add doi tuong vao mav
				mav.addObject("regimen",  regimenUpdate);
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
	
	@PostMapping(value="/addRegimen")
	public String addRegimen(RedirectAttributes ra) {
		//Khai báo mới mav
		Regimen regimen = new Regimen();
		boolean check = regimenService.save(regimen);
		if(check) {
			//Lấy lại thông tin sau khi add
			return "redirect:/admin/regimenDetails/" + regimen.getRegimenId();
		}
		else {
			return "redirect:/errorController/error404";
		}
	}
}

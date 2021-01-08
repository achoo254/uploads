package com.quanly.demo.ultis;

import java.util.List;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import com.quanly.demo.model.entity.UserInfo;
import com.quanly.demo.model.service.UserInfoService;

public class GlobalFunctions {
	public static String cancelDeleteAdmin = "Không thể xóa tài khoản có quyền Quản trị";
	public static String cancelDelete = "Không thể xóa vì thông tin đã được sử dụng";
	public static int totalPages = 0;
	public static int totalRecords = 0;
	public static List<Integer> navPages = null;
    public static int page = 1;
    public static int maxResult = 20;
    public static int maxNavigationResult = 10;
	public static String baseUrl() {
		final String baseUrl = ServletUriComponentsBuilder.fromCurrentContextPath().build().toUriString();
		return baseUrl;
	}
}

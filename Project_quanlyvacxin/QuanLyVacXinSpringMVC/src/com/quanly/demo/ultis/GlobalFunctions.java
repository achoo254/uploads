package com.quanly.demo.ultis;

import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import java.util.List;

public class GlobalFunctions {
	public static String cancelDeleteAdmin = "Không thể xóa tài khoản có quyền Quản trị";
	public static String cancelDelete = "Không thể xóa vì thông tin đã được sử dụng";
	public static String wrongPassword = "Mật khẩu không hợp lệ, vui lòng nhập lại";
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

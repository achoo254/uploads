<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>  
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>      
<!DOCTYPE html>
<div class="sidebar" data-color="purple" data-background-color="white" data-image="<%=GlobalFunctions.baseUrl() %>/resources/assets/img/sidebar-1.jpg">
      <!--
        Tip 1: You can change the color of the sidebar using: data-color="purple | azure | green | orange | danger"

        Tip 2: you can also add an image using data-image tag
    -->
      <div class="logo"><a href="<%=GlobalFunctions.baseUrl() %>" class="simple-text logo-normal">
          Quản lý dịch vụ vắc xin
        </a></div>
      <div class="sidebar-wrapper">
        <ul class="nav">
          <li class="nav-item active  ">
            <a class="nav-link" href="<%=GlobalFunctions.baseUrl() %>">
              <i class="material-icons">dashboard</i>
              <p>Trang chính</p>
            </a>
          </li>
          <li class="nav-item ">
            <a class="nav-link" href="<%=GlobalFunctions.baseUrl() %>/admin/userInfoDetails/<%=session.getAttribute("userInfoId") %>">
              <i class="material-icons">person</i>
              <p>Thông tin cá nhân</p>
            </a>
          </li>
          <li class="nav-item ">
            <a class="nav-link" href="<%=GlobalFunctions.baseUrl() %>/admin/userInfo">
              <i class="material-icons">content_paste</i>
              <p>Quản lý tài khoản</p>
            </a>
          </li>
          <li class="nav-item ">
            <a class="nav-link" href="<%=GlobalFunctions.baseUrl() %>/admin/categories">
              <i class="material-icons">library_books</i>
              <p>Quản lý danh mục</p>
            </a>
          </li>
          <li class="nav-item ">
            <a class="nav-link" href="<%=GlobalFunctions.baseUrl() %>/admin/regimen">
              <i class="material-icons">bubble_chart</i>
              <p>Quản lý phác đồ</p>
            </a>
          </li>
        </ul>
      </div>
    </div>
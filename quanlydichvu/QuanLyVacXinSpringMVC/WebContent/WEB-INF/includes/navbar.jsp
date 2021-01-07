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
    <div class="main-panel">
      <!-- Navbar -->
      <nav class="navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top ">
        <div class="container-fluid">
          <div class="navbar-wrapper">
          <% if(session.getAttribute("fullName") != null){ %>
             <a class="navbar-brand" href="javascript:;">Xin chào, <%=session.getAttribute("fullName") %></a>
             <%} %> 
          </div>
          <button class="navbar-toggler" type="button" data-toggle="collapse" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
            <span class="sr-only">Toggle navigation</span>
            <span class="navbar-toggler-icon icon-bar"></span>
            <span class="navbar-toggler-icon icon-bar"></span>
            <span class="navbar-toggler-icon icon-bar"></span>
          </button>
          <div class="collapse navbar-collapse justify-content-end">
            <form class="navbar-form">
              <div class="input-group no-border">
                <input type="text" value="" class="form-control" placeholder="Tìm kiếm tài khoản...">
                <button type="submit" class="btn btn-white btn-round btn-just-icon">
                  <i class="material-icons">search</i>
                  <div class="ripple-container"></div>
                </button>
              </div>
            </form>
            <ul class="navbar-nav">
              <li class="nav-item dropdown">
                <a class="nav-link" href="javascript:;" id="navbarDropdownProfile" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  <i class="material-icons">person</i>
                  <p class="d-lg-none d-md-block">
                    Account
                  </p>
                </a>
                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdownProfile">
                  <a class="dropdown-item" href="<%=GlobalFunctions.baseUrl() %>/admin/userInfoDetails/<%=session.getAttribute("userInfoId") %>">Thông tin cá nhân</a>
                  <a class="dropdown-item" href="<%=GlobalFunctions.baseUrl() %>/admin/userInfoDetails/changePassword/<%=session.getAttribute("userInfoId") %>">Đổi mật khẩu</a>
                  <div class="dropdown-divider"></div>
                  <a class="dropdown-item" href="<%=GlobalFunctions.baseUrl() %>/logout">Thoát</a> 
                </div>
              </li>
            </ul>
          </div>
        </div>
      </nav>
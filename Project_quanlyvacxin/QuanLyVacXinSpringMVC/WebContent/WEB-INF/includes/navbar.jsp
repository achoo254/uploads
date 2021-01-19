<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html>


<!-- Navbar -->
<nav
	class="navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top ">
	<div class="container-fluid">

		<div class="collapse navbar-collapse justify-content-end">
		<div class="navbar-wrapper">
			<% if(session.getAttribute("fullName") != null){ %>
			<a class="navbar-brand" href="javascript:;">Xin chào, <%=session.getAttribute("fullName") %></a>
			<%} %>
		</div>		
			<ul class="navbar-nav">
				<li class="nav-item dropdown"><a class="nav-link"
					href="javascript:;" id="navbarDropdownProfile"
					data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
						<i class="material-icons">person</i>
						<p class="d-lg-none d-md-block">Account</p>
				</a>
					<div class="dropdown-menu dropdown-menu-right"
						aria-labelledby="navbarDropdownProfile">
						<a class="dropdown-item"
							href="<%=GlobalFunctions.baseUrl() %>/admin/userInfoDetails/<%=session.getAttribute("userInfoId") %>">Thông
							tin cá nhân</a> <a class="dropdown-item"
							href="<%=GlobalFunctions.baseUrl() %>/admin/changePassword/<%=session.getAttribute("userInfoId") %>">Đổi
							mật khẩu</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item"
							href="<%=GlobalFunctions.baseUrl() %>/logout">Thoát</a>
					</div></li>
			</ul>
		</div>
	</div>
</nav>
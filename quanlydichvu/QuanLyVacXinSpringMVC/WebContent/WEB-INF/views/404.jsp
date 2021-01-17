<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en">
<head>
  <title>
    Quản lý dịch vụ vắc xin
  </title>
<jsp:include page="/WEB-INF/includes/meta.jsp"></jsp:include>
<link href="<%=GlobalFunctions.baseUrl() %>/resources/css/sb-admin-2.min.css" rel="stylesheet">  
</head>
<!-- BODY -->
<body class="">
<!-- Begin Page Content -->
<div class="content">
	<div class="container-fluid">
	  <!-- 404 Error Text -->
	  <div class="text-center">
	    <div class="error mx-auto" data-text="404">404</div>
	    <p class="lead text-gray-800 mb-5">Không tìm thấy trang</p>
	    <p class="text-gray-500 mb-0">Yêu cầu truy cập trang này của bạn không hợp lệ...</p>
	    <a href="<%=GlobalFunctions.baseUrl() %>">&larr; Quay trở về trang chính</a>
	  </div>
	  
	</div>
</div>
    <!-- INCLUDES FOOTER -->
    <jsp:include page="/WEB-INF/includes/footer.jsp"></jsp:include>
<!-- /.container-fluid -->
</body>
</html>
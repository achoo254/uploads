<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>   
<%@taglib uri="http://www.springframework.org/tags/form" prefix="f" %> 
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>  
<!DOCTYPE html>
<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Quản lý dịch vụ vắc xin</title>

    <!-- Custom fonts for this template-->
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="<%=GlobalFunctions.baseUrl() %>/resources/css/sb-admin-2.min.css" rel="stylesheet">

</head>

<body class="bg-gradient-primary">

    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-password-image"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-2">Trang quản lý dịch vụ vắc xin</h1>
                                        <p class="mb-4">Sử dụng số điện thoại và mật khẩu để đăng nhập</p>
                                    </div>
                                    <form class="user" action="<c:url value='/j_spring_security_login'/>" method="post">
                                        <div class="form-group">
                                            <input type="text" class="form-control form-control-user"
                                                name="telephone"
                                                placeholder="Nhập số điện thoại..." />
                                        </div>
                                       <div class="form-group">
                                            <input type="password" class="form-control form-control-user"
                                                name="password"
                                                placeholder="Nhập mật khẩu..." />
                                        </div>                                        
                                        <button class="btn btn-primary form-control" type="submit" >Đăng nhập</button>
                                        <input type="hidden" name="${_csrf.parameterName }" value="${_csrf.token }">
                                    </form>
                                    <hr>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

</body>

</html>
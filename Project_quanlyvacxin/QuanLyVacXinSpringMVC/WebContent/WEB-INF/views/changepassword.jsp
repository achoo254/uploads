<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="f"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<!DOCTYPE html>
<html lang="en">
<head>
<title>Đổi mật khẩu theo tài khoản</title>
<jsp:include page="/WEB-INF/includes/meta.jsp"></jsp:include>
</head>
<!-- BODY -->
<body class="">
	<div class="wrapper ">
		<jsp:include page="/WEB-INF/includes/leftbar.jsp"></jsp:include>
		<div class="main-panel">
			<jsp:include page="/WEB-INF/includes/navbar.jsp"></jsp:include>
			<!-- End Navbar -->
			<div class="content">
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-8">
							<div class="card">
								<div class="card-header card-header-primary">
									<h4 class="card-title">Đổi mật khẩu theo tài khoản</h4>
									<p class="card-category">Tùy chỉnh thông tin bên dưới</p>
								</div>
								<div class="card-body">
									<f:form action="updatePassword" modelAttribute="userInfo"
										method="post">
										<div class="row">
											<div class="col-md-5">
												<div class="form-group">
													<label class="bmd-label-floating">Id (khóa)</label>
													<f:input path="userInfoId" type="text" class="form-control"
														readonly="true" />
												</div>
											</div>
											<div class="col-md-3">
												<div class="form-group">
													<label class="bmd-label-floating">Số điện thoại
														(khóa)</label>
													<f:input path="telephone" type="text" class="form-control"
														readonly="true" />
												</div>
											</div>
											<div class="col-md-4">
												<div class="form-group">
													<label class="bmd-label-floating">Địa chỉ email
														(khóa)</label>
													<f:input path="email" type="email" class="form-control" 
														readonly="true" />
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-12">
												<div class="form-group">
													<label class="bmd-label-floating">Mật khẩu cũ</label>
													<f:password showPassword="false" path="password" required="required"
														class="form-control" />
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-12">
												<div class="form-group">
													<label class="bmd-label-floating">Mật khẩu mới</label>
													<f:password showPassword="false" path="token" required="required"
														class="form-control" />
												</div>
											</div>
										</div>
										<!-- SHOW VALIDATOR -->
										<c:if test="${not empty alert}">
											<div class="alert alert-danger">${alert}</div>
										</c:if>
										<!-- END -->
										<button type="submit" class="btn btn-primary pull-right">Cập
											nhật</button>
										<div class="clearfix"></div>
									</f:form>
								</div>
							</div>
						</div>
						<div class="col-md-4">
							<jsp:include page="/WEB-INF/includes/info.jsp"></jsp:include>
						</div>
					</div>
				</div>
			</div>
			<!-- INCLUDES FOOTER -->
			<jsp:include page="/WEB-INF/includes/footer.jsp"></jsp:include>
		</div>
	</div>
</body>
<!-- END -->
</html>
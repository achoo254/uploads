<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="f"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<!DOCTYPE html>
<html lang="en">
<head>
<title>Thông tin cá nhân</title>
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
									<h4 class="card-title">Thông tin cá nhân</h4>
									<p class="card-category">Tùy chỉnh thông tin bên dưới</p>
								</div>
								<div class="card-body">
									<f:form action="updateUserInfoDetails"
										modelAttribute="userInfo" method="post">
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
											<div class="col-md-6">
												<div class="form-group">
													<label class="bmd-label-floating">Họ và tên</label>
													<f:input path="fullName" type="text" class="form-control" />
												</div>
											</div>
											<div class="col-md-6">
												<div class="form-group">
													<label class="bmd-label-floating">Ngày sinh</label>
													<f:input path="birthday" type="date" class="form-control" />
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-12">
												<div class="form-group">
													<label class="bmd-label-floating">Địa chỉ</label>
													<f:input path="address" type="text" class="form-control" />
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-4">
												<div class="form-group">
													<label class="bmd-label-floating">Tuổi</label>
													<f:input path="age" type="text" class="form-control" />
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-4">
												<div class="form-group">
													<label for="selectRoles">Phân quyền</label>
													<f:select path="roles" itemValue="${userInfo.roles}"
														class="form-control" id="selectRoles">
														<f:option value="ROLE_ADMIN">Quản trị</f:option>
														<f:option value="ROLE_MOD">Quản lý</f:option>
														<f:option value="Bác sĩ">Bác sĩ</f:option>
														<f:option value="Tiếp tân">Tiếp tân</f:option>
														<f:option value="Thu ngân">Thu ngân</f:option>
														<f:option value="Điều dưỡng">Điều dưỡng</f:option>
														<f:option value="Khách hàng">Khách hàng</f:option>
													</f:select>
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-4">
												<div class="form-check form-check-radio">
													<label class="form-check-label"> <f:radiobutton
															path="status" class="form-check-input" value="1" /> Kích
														hoạt <span class="circle"> <span class="check"></span>
													</span>
													</label>
												</div>
											</div>
											<div class="col-md-4">
												<div class="form-check form-check-radio">
													<label class="form-check-label"> <f:radiobutton
															path="status" class="form-check-input" value="0" />
														Không kích hoạt <span class="circle"> <span
															class="check"></span>
													</span>
													</label>
												</div>
											</div>
										</div>
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
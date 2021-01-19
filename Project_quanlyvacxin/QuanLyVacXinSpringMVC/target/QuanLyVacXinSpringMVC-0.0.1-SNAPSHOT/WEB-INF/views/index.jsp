
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<%@ taglib prefix="tag" uri="/WEB-INF/taglibs/customTaglib.tld"%>
<!DOCTYPE html>
<html lang="en">
<head>
<title>Quản lý dịch vụ vắc xin</title>
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
						<div class="col-lg-3 col-md-6 col-sm-6">
							<div class="card card-stats">
								<div class="card-header card-header-warning card-header-icon">
									<div class="card-icon">
										<i class="material-icons">content_copy</i>
									</div>
									<p class="card-category">Đang online</p>
									<h3 class="card-title">
										<br> ${countOnline} <small>online</small>
									</h3>
								</div>
								<div class="card-footer">
									<div class="stats">
										<!--<i class="material-icons text-danger">warning</i>
                     <a href="javascript:;">Get More Space...</a> -->
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-3 col-md-6 col-sm-6">
							<div class="card card-stats">
								<div class="card-header card-header-success card-header-icon">
									<div class="card-icon">
										<i class="material-icons">store</i>
									</div>
									<p class="card-category">Tổng thu</p>
									<h3 class="card-title">
										<br> ${sumOrders}
									</h3>
								</div>
								<div class="card-footer">
									<div class="stats">
										<!-- <i class="material-icons">date_range</i> Last 24 Hours -->
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-3 col-md-6 col-sm-6">
							<div class="card card-stats">
								<div class="card-header card-header-danger card-header-icon">
									<div class="card-icon">
										<i class="material-icons">info_outline</i>
									</div>
									<p class="card-category">Tổng chi</p>
									<h3 class="card-title">
										<br> ${sumProductDetails}
									</h3>
								</div>
								<div class="card-footer">
									<div class="stats">
										<!-- <i class="material-icons">local_offer</i> Tracked from Github -->
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-3 col-md-6 col-sm-6">
							<div class="card card-stats">
								<div class="card-header card-header-info card-header-icon">
									<div class="card-icon">
										<i class="fa fa-twitter"></i>
									</div>
									<p class="card-category">Góp ý</p>
									<h3 class="card-title">
										<br> ${countContact}
									</h3>
								</div>
								<div class="card-footer">
									<div class="stats">
										<!--  <i class="material-icons">update</i> Just Updated-->
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="col-lg-6 col-md-12">
							<div class="card">
								<div class="card-header card-header-tabs card-header-primary">
									<div class="nav-tabs-navigation">
										<div class="nav-tabs-wrapper">
											<span class="nav-tabs-title">Liên hệ:</span>
											<ul class="nav nav-tabs" data-tabs="tabs">
												<li class="nav-item"><a class="nav-link active"
													href="#profile" data-toggle="tab"> <i
														class="material-icons">bug_report</i> Góp ý
														<div class="ripple-container"></div>
												</a></li>
											</ul>
										</div>
									</div>
								</div>
								<div class="card-body">
									<div class="tab-content">
										<div class="tab-pane active" id="profile">
											<table class="table">
												<tbody>
													<c:forEach items="${listContact}" var="contact">
														<tr>
															<td class="text-truncate"
																style="max-width: 400px; height: 100px;">${contact.details}</td>
															<td class="td-actions text-right">
																<button type="button" rel="tooltip" title="Xem chi tiết"
																	data-toggle="modal"
																	data-target="#contactdetails${contact.contactId}"
																	class="btn btn-primary btn-link btn-sm">
																	<i class="material-icons">remove_red_eye</i>
																</button>
																<button type="button" rel="tooltip" title="Xóa"
																	class="btn btn-danger btn-link btn-sm">
																	<i class="material-icons">close</i>
																</button>
															</td>
														</tr>
														<!-- Modal -->
														<div class="modal fade"
															id="contactdetails${contact.contactId}" tabindex="-1"
															role="dialog" aria-labelledby="exampleModalLongTitle"
															aria-hidden="true">
															<div class="modal-dialog" role="document"
																style="overflow-y: initial !important;">
																<div class="modal-content">
																	<div class="modal-header">
																		<h5 class="modal-title" id="exampleModalLongTitle">Được gửi từ SĐT: ${contact.telephone }</h5>
																		<button type="button" class="close"
																			data-dismiss="modal" aria-label="Close">
																			<span aria-hidden="true">&times;</span>
																		</button>
																	</div>
																	<div class="modal-body"
																		style="height: 80vh; overflow-y: auto;">${contact.details }</div>
																	<div class="modal-footer">
																		<button type="button" class="btn btn-secondary"
																			data-dismiss="modal">Đóng</button>
																		<button type="button" class="btn btn-danger">Xóa</button>
																	</div>
																</div>
															</div>
														</div>
													</c:forEach>
												</tbody>
											</table>
											<tag:paginate max="10" offset="${offset}" count="${count}"
												uri="../admin/index/contact" next="&raquo;"
												previous="&laquo;" />
											<!-- SHOW VALIDATOR -->
											<c:if test="${not empty alert2}">
												<div class="alert alert-danger">${alert2}</div>
											</c:if>
											<!-- END -->
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-6 col-md-12">
							<div class="card">
								<div class="card-header card-header-info">
									<h4 class="card-title">Khách hàng mới</h4>
									<p class="card-category">5 khách hàng đăng ký tài khoản gần
										nhất</p>
								</div>
								<div class="card-body table-responsive">
									<table class="table table-hover">
										<thead class="text-info">
											<tr>
												<th>ID</th>
												<th>Họ tên</th>
												<th>Số điện thoại</th>
												<th>Email</th>
											</tr>
										</thead>
										<tbody>
											<c:forEach items="${listUserInfo}" var="userInfo">
												<tr>
													<td>${userInfo.userInfoId }</td>
													<td>${userInfo.fullName }</td>
													<td>${userInfo.telephone }</td>
													<td>${userInfo.email }</td>
												</tr>
											</c:forEach>
										</tbody>
									</table>
								</div>
							</div>
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
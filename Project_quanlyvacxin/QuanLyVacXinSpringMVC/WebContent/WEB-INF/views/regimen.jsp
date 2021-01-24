<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="f"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<%@ taglib prefix="tag" uri="/WEB-INF/taglibs/customTaglib.tld"%>
<!DOCTYPE html>
<html lang="en">
<head>
<title>Danh sách phác đồ</title>
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
						<div class="col-md-12">
							<div class="card">
								<div class="card-header card-header-primary">
									<h4 class="card-title ">Danh sách phác đồ</h4>
									<p class="card-category">Thông tin chi tiết</p>
								</div>
								<div class="card-body">
									<div class="table-responsive">
										<f:form action="searchRegimen" class="navbar-form" method="get">
											<div class="input-group no-border">
												<input type="text" value="" class="form-control" name="name"
													style="bottom: -10px;"
													placeholder="Tìm kiếm theo tên phác đồ...">
												<button type="submit"
													class="btn btn-white btn-round btn-just-icon">
													<i class="material-icons">search</i>
													<div class="ripple-container"></div>
												</button>
												<a class="btn btn-primary btn-round text-light"
													data-toggle="modal" data-target=".bd-addnew-sm"> <i
													class="material-icons">add</i> Thêm mới
												</a>
											</div>
										</f:form>
										<!-- POPUP ADD NEW -->
										<f:form action="addRegimen" method="post">
											<div class="modal fade bd-addnew-sm" tabindex="-1"
												role="dialog" aria-labelledby="mySmallModalLabel"
												aria-hidden="true">
												<div class="modal-dialog modal-sm">
													<div class="modal-content">
														<div class="modal-header">
															<h5 class="modal-title">Thông báo</h5>
															<button type="button" class="close" data-dismiss="modal"
																aria-label="Close">
																<span aria-hidden="true">&times;</span>
															</button>
														</div>
														<div class="modal-body">
															<p>Bạn chắc chắn muốn thêm mới?</p>
														</div>
														<div class="modal-footer">
															<button type="submit" class="btn btn-primary">Thêm</button>
															<button type="button" class="btn btn-secondary"
																data-dismiss="modal">Không thêm</button>
														</div>
													</div>
												</div>
											</div>
										</f:form>
										<!-- END -->
										<table class="table" id="datatableCategories">
											<thead class=" text-primary">
												<tr>
													<th>ID</th>
													<th>Tên</th>
										
													<th class="text-right">Nghiệp vụ</th>
												</tr>
											</thead>
											<tbody>
												<f:form action="deleteRegimen" method="get">
													<c:forEach items="${listRegimen}" var="regimen">
														<tr>
															<td class="text-primary">${regimen.regimenId}</td>
															<td class="text-truncate"
																style="max-width: 200px; height: 100px;">${regimen.name}</td>
															<td class="td-actions text-right"><a
																class="text-primary btn-round"
																href="<%=GlobalFunctions.baseUrl()%>/admin/regimenDetails/${regimen.regimenId}">
																	<i class="material-icons">edit</i> Sửa
															</a> | <a class="text-primary btn-round" data-toggle="modal"
																data-target=".bd-example-modal-sm${regimen.regimenId}"
																href=""> <i class="material-icons">delete_forever</i>
																	Xóa
															</a></td>
														</tr>
														<div
															class="modal fade bd-example-modal-sm${regimen.regimenId}"
															tabindex="-1" role="dialog"
															aria-labelledby="mySmallModalLabel" aria-hidden="true">
															<div class="modal-dialog modal-sm">
																<div class="modal-content">
																	<div class="modal-header">
																		<h5 class="modal-title">Thông báo</h5>
																		<button type="button" class="close"
																			data-dismiss="modal" aria-label="Close">
																			<span aria-hidden="true">&times;</span>
																		</button>
																	</div>
																	<div class="modal-body">
																		<p>Bạn chắc chắn muốn xóa?</p>
																	</div>
																	<div class="modal-footer">
																		<button type="submit" class="btn btn-primary"
																			name="regimenId"
																			value="${regimen.regimenId}">Xóa</button>
																		<button type="button" class="btn btn-secondary"
																			data-dismiss="modal">Không xóa</button>
																	</div>
																</div>
															</div>
														</div>
													</c:forEach>
												</f:form>
											</tbody>
										</table>
										<tag:paginate max="10" offset="${offset}" count="${count}"
											uri="../admin/regimen" next="&raquo;" previous="&laquo;" />
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
				</div>
			</div>
			<!-- INCLUDES FOOTER -->
			<jsp:include page="/WEB-INF/includes/footer.jsp"></jsp:include>
		</div>
	</div>

</body>
<!-- END -->
</html>
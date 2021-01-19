<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="f"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@page import="com.quanly.demo.ultis.GlobalFunctions"%>
<!DOCTYPE html>
<html lang="en">
<head>
<title>Thông tin phác đồ</title>
<jsp:include page="/WEB-INF/includes/meta.jsp"></jsp:include>
<!-- CUSTOM -->
<script
	src='https://cdn.tiny.cloud/1/fgax6j7vzmbll9j27bpfg6ya8hz5578skc7a0tqyt3hpquyn/tinymce/5/tinymce.min.js'
	referrerpolicy="origin">
	
</script>
<script>
	tinymce
			.init({
				selector : '#mytextarea',
				plugins : 'a11ychecker advcode casechange formatpainter linkchecker autolink lists checklist media mediaembed pageembed permanentpen powerpaste table advtable tinycomments tinymcespellchecker',
				toolbar : 'a11ycheck addcomment showcomments casechange checklist code formatpainter pageembed permanentpen table',
				toolbar_mode : 'floating',
				tinycomments_mode : 'embedded',
				tinycomments_author : 'Trịnh Quốc Hoàn Đạt',
				height : 500
			});
</script>
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
									<h4 class="card-title">Thông tin phác đồ</h4>
									<p class="card-category">Tùy chỉnh thông tin bên dưới</p>
								</div>
								<div class="card-body">
									<f:form action="updateRegimenDetails"
										modelAttribute="regimen" method="post">
										<div class="row">
											<div class="col-md-5">
												<div class="form-group">
													<label class="bmd-label-floating">Id (khóa)</label>
													<f:input path="regimenId" type="text"
														class="form-control" readonly="true" />
												</div>
											</div>
											<div class="col-md-7">
												<div class="form-group">
													<label class="bmd-label-floating">Tên</label>
													<f:input path="name" type="text" class="form-control" />
												</div>
											</div>
										</div>
										<div class="row">
											<div class="col-md-12">
												<div class="form-group">
													<label>Chi tiết</label>
													<div class="form-group bmd-form-group">
														<label class="bmd-label-floating">Nhập nội dung
															bên dưới</label>
														<f:textarea path="details" class="form-control"
															id="mytextarea" name="mytextarea"></f:textarea>
													</div>
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
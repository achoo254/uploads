<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a class="navbar-brand" href="#">Navbar</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="../redirect.jsp">Trang chính <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="../productsController/getAllProducts.htm">Tất cả sản phẩm</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="../categoriesController/getAllCategories.htm">Tất cả danh mục</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="">Tất cả đơn hàng</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="">Tất cả đơn hàng chi tiết</a>
      </li>                  
      <li class="nav-item">
        <a class="nav-link" href="../customerController/getAllCustomer.htm">Tất cả khách hàng</a>
      </li>
      <li class="nav-item">
        <a class="nav-link disabled" href="#">Giỏ hàng</a>
      </li>
    </ul>
  </div>
</nav>
package com.quanly.demo.model.service;

import java.util.List;

import com.quanly.demo.model.entity.Categories;

public interface CategoriesService {
	public List<Categories> getAllCategories(Integer offset, Integer maxResult);
	public boolean save(Categories cate);
	public boolean merge(Categories cate);
	public boolean delete(int categoriesId);
	public Categories getCategories(int categoriesId);
	public Long count();
	public Categories findByName(String name);
}

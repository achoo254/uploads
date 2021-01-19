package com.quanly.demo.model.dao;

import com.quanly.demo.model.entity.Categories;

import java.util.List;

public interface CategoriesDao {
	public List<Categories> getAllCategories(Integer offset, Integer maxResult);
	public boolean save(Categories cate);
	public boolean merge(Categories cate);
	public boolean delete(int categoriesId);
	public Categories getCategories(int categoriesId);
	public Long count();
	public Categories findByName(String name);
}

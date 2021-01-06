package com.quanly.demo.model.dao;

import java.util.List;

import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.entity.UserInfo;

public interface CategoriesDao {
	public List<Categories> getAllCategories();
	public boolean save(Categories cate);
	public boolean merge(Categories cate);
	public boolean delete(int categoriesId);
	public Categories getCategories(int categoriesId);
}

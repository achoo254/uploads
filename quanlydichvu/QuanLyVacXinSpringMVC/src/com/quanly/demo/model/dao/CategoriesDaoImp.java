package com.quanly.demo.model.dao;

import java.util.List;

import org.springframework.stereotype.Repository;

import com.quanly.demo.model.entity.Categories;

@Repository
public class CategoriesDaoImp implements CategoriesDao{

	@Override
	public List<Categories> getAllCategories() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean save(Categories cate) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean merge(Categories cate) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean delete(int categoriesId) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public Categories getCategories(int categoriesId) {
		// TODO Auto-generated method stub
		return null;
	}

}

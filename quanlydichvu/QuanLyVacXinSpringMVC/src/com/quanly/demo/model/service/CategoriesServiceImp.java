package com.quanly.demo.model.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.stereotype.Service;

import com.quanly.demo.model.dao.CategoriesDao;
import com.quanly.demo.model.entity.Categories;

@Service
public class CategoriesServiceImp implements CategoriesService{
	@Autowired
	CategoriesDao categoriesDao;
	
	@Override
	public List<Categories> getAllCategories() {
		return categoriesDao.getAllCategories();
	}

	@Override
	public boolean save(Categories cate) {
		// TODO Auto-generated method stub
		return categoriesDao.save(cate);
	}

	@Override
	public boolean merge(Categories cate) {
		// TODO Auto-generated method stub
		return categoriesDao.merge(cate);
	}

	@Override
	public boolean delete(int categoriesId) {
		// TODO Auto-generated method stub
		return categoriesDao.delete(categoriesId);
	}

	@Override
	public Categories getCategories(int categoriesId) {
		// TODO Auto-generated method stub
		return categoriesDao.getCategories(categoriesId);
	}

}
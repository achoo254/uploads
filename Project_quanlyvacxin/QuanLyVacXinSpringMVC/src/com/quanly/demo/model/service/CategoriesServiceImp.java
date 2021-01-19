package com.quanly.demo.model.service;

import com.quanly.demo.model.dao.CategoriesDao;
import com.quanly.demo.model.entity.Categories;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class CategoriesServiceImp implements CategoriesService{
	@Autowired
	CategoriesDao categoriesDao;
	
	@Override
	public List<Categories> getAllCategories(Integer offset, Integer maxResult) {
		return categoriesDao.getAllCategories(offset, maxResult);
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

	@Override
	public Long count() {
		// TODO Auto-generated method stub
		return categoriesDao.count();
	}

	@Override
	public Categories findByName(String name) {
		// TODO Auto-generated method stub
		return categoriesDao.findByName(name);
	}

}

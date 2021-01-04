package com.quanly.demo.service;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.Categories;

@Repository
public interface CategoriesService extends JpaRepository<Categories, Integer>{

}

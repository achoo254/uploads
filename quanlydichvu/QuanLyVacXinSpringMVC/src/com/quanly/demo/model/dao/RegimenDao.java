package com.quanly.demo.model.dao;

import java.util.List;

import com.quanly.demo.model.entity.Categories;
import com.quanly.demo.model.entity.Regimen;

public interface RegimenDao {
	public List<Regimen> getAllRegimen();
	public boolean save(Regimen regimen);
	public boolean merge(Regimen regimen);
	public boolean delete(int regimenId);
	public Regimen getRegimen(int regimenId);
}

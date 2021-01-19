package com.quanly.demo.model.service;

import com.quanly.demo.model.entity.Regimen;

import java.util.List;

public interface RegimenService {
	public List<Regimen> getAllRegimen(Integer offset, Integer maxResult);
	public boolean save(Regimen regimen);
	public boolean merge(Regimen regimen);
	public boolean delete(int regimenId);
	public Regimen getRegimen(int regimenId);
	public Long count();
	public Regimen findByName(String name);
}

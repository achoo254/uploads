package com.quanly.demo.model.dao;

import java.util.List;

import org.springframework.stereotype.Repository;

import com.quanly.demo.model.entity.Regimen;
@Repository
public class RegimenDaoImp implements RegimenDao{

	@Override
	public List<Regimen> getAllRegimen() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean save(Regimen regimen) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean merge(Regimen regimen) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean delete(int regimenId) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public Regimen getRegimen(int regimenId) {
		// TODO Auto-generated method stub
		return null;
	}

}

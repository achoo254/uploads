package com.quanly.demo.model.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.quanly.demo.model.dao.RegimenDao;
import com.quanly.demo.model.entity.Regimen;

@Service
public class RegimenServiceImp implements RegimenService{
	@Autowired
	RegimenDao regimenDao;
	
	@Override
	public List<Regimen> getAllRegimen() {
		// TODO Auto-generated method stub
		return regimenDao.getAllRegimen();
	}

	@Override
	public boolean save(Regimen regimen) {
		// TODO Auto-generated method stub
		return regimenDao.save(regimen);
	}

	@Override
	public boolean merge(Regimen regimen) {
		// TODO Auto-generated method stub
		return regimenDao.merge(regimen);
	}

	@Override
	public boolean delete(int regimenId) {
		// TODO Auto-generated method stub
		return regimenDao.delete(regimenId);
	}

	@Override
	public Regimen getRegimen(int regimenId) {
		// TODO Auto-generated method stub
		return regimenDao.getRegimen(regimenId);
	}

}

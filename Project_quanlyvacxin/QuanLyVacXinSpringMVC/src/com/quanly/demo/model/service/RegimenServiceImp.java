package com.quanly.demo.model.service;

import com.quanly.demo.model.dao.RegimenDao;
import com.quanly.demo.model.entity.Regimen;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class RegimenServiceImp implements RegimenService{
	@Autowired
	RegimenDao regimenDao;

	@Override
	public List<Regimen> getAllRegimen(Integer offset, Integer maxResult) {
		// TODO Auto-generated method stub
		return regimenDao.getAllRegimen(offset, maxResult);
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

	@Override
	public Long count() {
		// TODO Auto-generated method stub
		return regimenDao.count();
	}

	@Override
	public Regimen findByName(String name) {
		// TODO Auto-generated method stub
		return regimenDao.findByName(name);
	}
	

}

package com.quanly.demo.model.dao;

import java.util.List;


import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.quanly.demo.model.entity.UserInfo;

@Repository
public class UserInfoDaoImp implements UserInfoDao{
	@Autowired
	private SessionFactory sessionFactory;
	
	@Override
	public List<UserInfo> getAllUserInfo() {
		Session session = null;
		Transaction transaction = null;
		List<UserInfo> listUserInfo = null;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			listUserInfo = session.createQuery("from UserInfo").list();
			transaction.commit();
		} catch (Exception e) {
			e.printStackTrace();
			transaction.rollback();
		} finally {
			if (transaction != null) {
				session.close();
			}
		}
		return listUserInfo;
	}

	@Override
	public boolean save(UserInfo user) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean merge(UserInfo user) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean delete(int userId) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public UserInfo getUserInfo(int userId) {
		// TODO Auto-generated method stub
		return null;
	}

}

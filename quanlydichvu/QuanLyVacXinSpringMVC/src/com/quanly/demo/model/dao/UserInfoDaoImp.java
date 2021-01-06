package com.quanly.demo.model.dao;

import java.sql.Date;
import java.text.SimpleDateFormat;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Query;
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
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien update			
			session.merge(user);
			transaction.commit();
			check = true;
		} catch (Exception e) {
			e.printStackTrace();
			transaction.rollback();
		} finally {
			if (transaction != null) {
				session.close();
			}
		}
		return check;
	}

	@Override
	public boolean delete(int userId) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public UserInfo getUserInfoByTelephone(String telephone) {
		Session session = null;
		Transaction transaction = null;
		UserInfo user = null;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			//Criteria criteria = session.createCriteria(UserInfo.class);
			Query query = session.createQuery("from UserInfo where telephone = :telephone");
			query.setParameter("telephone", telephone);
			user = (UserInfo) query.uniqueResult();
			if(user != null) {
				transaction.commit();
			}
			//user = new UserInfo(1, "hoan dat", "123", "full name");
			
		} catch (Exception e) {
			e.printStackTrace();
			transaction.rollback();
		} finally {
			if (transaction != null) {
				session.close();
			}
		}
		return user;
	}
	
	

	@Override
	public UserInfo getUserInfoById(int id) {
		Session session = null;
		Transaction transaction = null;
		UserInfo user = null;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			//Criteria criteria = session.createCriteria(UserInfo.class);
			Query query = session.createQuery("from UserInfo where userInfoId = :userInfoId");
			query.setParameter("userInfoId", id);
			user = (UserInfo) query.uniqueResult();
			if(user != null) {
				transaction.commit();
			}
			//user = new UserInfo(1, "hoan dat", "123", "full name");
			
		} catch (Exception e) {
			e.printStackTrace();
			transaction.rollback();
		} finally {
			if (transaction != null) {
				session.close();
			}
		}
		return user;
	}

}

package com.quanly.demo.model.dao;

import com.quanly.demo.model.entity.Regimen;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.criterion.Projections;
import org.hibernate.criterion.Restrictions;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import java.util.List;
@Repository
public class RegimenDaoImp implements RegimenDao{
	@Autowired
	private SessionFactory sessionFactory;
	
	@SuppressWarnings("unchecked")
	@Override
	public List<Regimen> getAllRegimen(Integer offset, Integer maxResult) {
	       return sessionFactory.openSession()
	                .createCriteria(Regimen.class)
	                .setFirstResult(offset!=null?offset:0)
	                .setMaxResults(maxResult!=null?maxResult:10)
	                .list();
	}

	@Override
	public boolean save(Regimen regimen) {
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien save
			session.save(regimen);
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
	public boolean merge(Regimen regimen) {
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien update			
			session.merge(regimen);
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
	public boolean delete(int regimenId) {
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien delete			
			javax.persistence.Query query = session.createQuery("delete Regimen where regimenId = :regimenId");
			query.setParameter("regimenId", regimenId);
			int result = query.executeUpdate();
			if (result > 0) {
				check = true;
				transaction.commit();
			}
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
	public Regimen getRegimen(int regimenId) {
	      return (Regimen) sessionFactory.openSession()
	                .createCriteria(Regimen.class).add(Restrictions.eq("regimenId", regimenId))
	                .uniqueResult();
	}

	@Override
	public Long count() {
        return (Long)sessionFactory.openSession()
                .createCriteria(Regimen.class)
                .setProjection(Projections.rowCount())
                .uniqueResult();
	}

	@Override
	public Regimen findByName(String name) {
	    return (Regimen) sessionFactory.openSession()
                .createCriteria(Regimen.class).add(Restrictions.eq("name", name))
                .uniqueResult();
	}

}

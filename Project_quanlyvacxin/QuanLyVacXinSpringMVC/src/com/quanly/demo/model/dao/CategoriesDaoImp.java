package com.quanly.demo.model.dao;

import com.quanly.demo.model.entity.Categories;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.criterion.Projections;
import org.hibernate.criterion.Restrictions;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class CategoriesDaoImp implements CategoriesDao{
	@Autowired
	private SessionFactory sessionFactory;
	
	@SuppressWarnings("unchecked")
	@Override
	public List<Categories> getAllCategories(Integer offset, Integer maxResult) {
	       return sessionFactory.openSession()
	                .createCriteria(Categories.class)
	                .setFirstResult(offset!=null?offset:0)
	                .setMaxResults(maxResult!=null?maxResult:10)
	                .list();
	}
	
    @SuppressWarnings("unchecked")
    public Long count() {
        return (Long)sessionFactory.openSession()
                .createCriteria(Categories.class)
                .setProjection(Projections.rowCount())
                .uniqueResult();
    }

	@Override
	public boolean save(Categories cate) {
		// TODO Auto-generated method stub
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien save
			session.save(cate);
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
	public boolean merge(Categories cate) {
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien update			
			session.merge(cate);
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
	public boolean delete(int categoriesId) {
		Session session = null;
		Transaction transaction = null;
		boolean check = false;
		try {
			// Khoi tao session lam viec voi ObjectJava
			session = sessionFactory.openSession();
			// Tu session, khoi tao transaction de lam viec
			transaction = session.beginTransaction();
			// Thuc hien delete			
			javax.persistence.Query query = session.createQuery("delete Categories where categoriesId = :categoriesId");
			query.setParameter("categoriesId", categoriesId);
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
	public Categories getCategories(int categoriesId) {
       return (Categories) sessionFactory.openSession()
                .createCriteria(Categories.class).add(Restrictions.eq("categoriesId", categoriesId))
                .uniqueResult();
	}

	@Override
	public Categories findByName(String name) {
	    return (Categories) sessionFactory.openSession()
                .createCriteria(Categories.class).add(Restrictions.eq("name", name))
                .uniqueResult();
	}

}

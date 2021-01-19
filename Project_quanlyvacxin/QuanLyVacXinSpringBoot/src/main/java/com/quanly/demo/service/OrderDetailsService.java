package com.quanly.demo.service;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import com.quanly.demo.model.OrderDetails;
import com.quanly.demo.model.RegimenDetails;

@Repository
public interface OrderDetailsService extends JpaRepository<OrderDetails, Integer> {
	//List<OrderDetails> findByOrderDetailsRegimenDetails(RegimenDetails regimenDetails);
	OrderDetails findByOrderDetailsRegimenDetails(RegimenDetails regimenDetails);
}
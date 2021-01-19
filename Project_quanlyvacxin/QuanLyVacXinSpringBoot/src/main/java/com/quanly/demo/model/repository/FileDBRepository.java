package com.quanly.demo.model.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import com.quanly.demo.model.FileDb;

@Repository
public interface FileDBRepository extends JpaRepository<FileDb, String>{

}
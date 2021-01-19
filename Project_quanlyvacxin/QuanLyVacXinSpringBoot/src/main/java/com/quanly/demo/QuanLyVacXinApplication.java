package com.quanly.demo;

import javax.annotation.Resource;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import com.quanly.demo.service.FilesStorageService;



@SpringBootApplication(scanBasePackages={"com.quanly.demo"})
public class QuanLyVacXinApplication{
	public static void main(String[] args) {
	
		SpringApplication.run(QuanLyVacXinApplication.class, args);
	}
	
}




package com.quanly.demo.model.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Lob;
import javax.persistence.Table;

import org.hibernate.annotations.GenericGenerator;

import lombok.Data;

@Data
@Entity
@Table(name = "Files")
public class FileDb {

   @Id
   @GeneratedValue(generator = "uuid")
   @GenericGenerator(name = "uuid", strategy = "uuid2")
	private String fileDbId;
	private String name;

	private String type;

	@Lob
	private byte[] data;
	
	public FileDb() {
		
	}
	
	public FileDb(String fileName, String contentType, byte[] bytes) {
		  this.name = fileName;
		    this.type = contentType;
		    this.data = bytes;
	}
	
	
}

package com.quanly.demo.service;

import java.io.IOException;
import java.net.MalformedURLException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.stream.Stream;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.io.Resource;
import org.springframework.core.io.UrlResource;
import org.springframework.stereotype.Service;
import org.springframework.util.FileSystemUtils;
import org.springframework.util.StringUtils;
import org.springframework.web.multipart.MultipartFile;

import com.quanly.demo.model.FileDb;
import com.quanly.demo.model.repository.FileDBRepository;

@Service
public class FilesStorageService{

	  @Autowired
	  private FileDBRepository fileDBRepository;

	  public FileDb store(MultipartFile file) throws IOException {
	    String fileName = StringUtils.cleanPath(file.getOriginalFilename());
	    FileDb FileDb = new FileDb(fileName, file.getContentType(), file.getBytes());

	    return fileDBRepository.save(FileDb);
	  }

	  public FileDb getFile(String id) {
	    return fileDBRepository.findById(id).get();
	  }
	  
	  public Stream<FileDb> getAllFiles() {
	    return fileDBRepository.findAll().stream();
	  }

}

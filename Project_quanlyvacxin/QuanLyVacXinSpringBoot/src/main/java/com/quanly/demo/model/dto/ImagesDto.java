package com.quanly.demo.model.dto;

import javax.persistence.Column;

import lombok.Data;

@Data
public class ImagesDto {
	private int imagesId;
	private String name;
	private String url;
    private String keys;
}

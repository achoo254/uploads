package com.quanly.demo.api;

import java.io.File;
import java.io.FileOutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.validation.Valid;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.multipart.MultipartFile;

import com.quanly.demo.mapper.MapperConvert;
import com.quanly.demo.model.Categories;
import com.quanly.demo.model.Product;
import com.quanly.demo.model.ProductDetails;
import com.quanly.demo.model.UserInfo;
import com.quanly.demo.model.dto.ProductDto;
import com.quanly.demo.service.CategoriesService;
import com.quanly.demo.service.ProductService;

@RestController
@CrossOrigin(origins = "*", allowedHeaders = "*")
@RequestMapping("/product")
public class ProductController {
	@Autowired
	ProductService productService;
	
	@Autowired
	CategoriesService categoriesService;
	
	private final ModelMapper modelMapper = new ModelMapper();
	private final MapperConvert mapperConvert = new MapperConvert();
	
	@PostMapping(value = "/post/")
	public Product postProduct(@Valid @RequestBody Product product) {
		return productService.save(product);
	}
	
	@PutMapping(value = "/put/{id}")
	public ResponseEntity<Product> putProductDetails(@PathVariable(value = "id") int productId,
			@Valid @RequestBody Product form) {
		Product product = productService.getOne(productId);
		if (product == null) {
			return ResponseEntity.notFound().build();
		}
		
		product.setBuy(form.getBuy());
		product.setCountry(form.getCountry());
		product.setDetails(form.getDetails());
		product.setImages(form.getImages());
		product.setName(form.getName());
		product.setSell(form.getSell());

		Product updatedproduct = productService.save(product);
		return ResponseEntity.ok(updatedproduct);
	}
	
	@GetMapping(value = "/getAll/")
	public ResponseEntity<List<ProductDto>> findAll() {
		List<Product> listproduct = productService.findAll();
		if (listproduct.isEmpty()) {
			return new ResponseEntity(HttpStatus.NO_CONTENT);
		}
		//Mapped
		List<ProductDto> listProductDto = mapperConvert.mapList(listproduct, ProductDto.class);
		
		return new ResponseEntity<List<ProductDto>>(listProductDto, HttpStatus.OK);
	}

	@GetMapping(value = "/get/{id}")
	public ProductDto getOne(@PathVariable("id") int id) {
		Product product = productService.getOne(id);
		if (product == null) {
			ResponseEntity.notFound().build();
		}
		//Mapped
		ProductDto productDto = modelMapper.map(product, ProductDto.class);
		
		return productDto;
	}
}

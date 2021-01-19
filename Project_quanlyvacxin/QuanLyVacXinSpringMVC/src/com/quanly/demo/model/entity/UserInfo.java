package com.quanly.demo.model.entity;

import lombok.Data;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "user_info")
public class UserInfo {
	@Id
	@Column(name = "user_info_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int userInfoId;
	
	@Column(name = "full_name", columnDefinition = "NVARCHAR(500)")
	private String fullName;
	
	@Column(name = "address", columnDefinition = "NVARCHAR(500)")
	private String address;
	
	@Column(name = "age")
	private int age;
	
	@Column(name = "email", columnDefinition = "NVARCHAR(255)")
	private String email;
	
	@Column(name = "telephone", columnDefinition = "NVARCHAR(255)")
	private String telephone;
	
	@Column(name = "birthday")
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private java.util.Date birthday;
	
	@Column(name = "Password", columnDefinition = "NVARCHAR(255)")
	private String password;
	
	@Column(name = "Roles", columnDefinition = "NVARCHAR(255)")
	private String roles;
	
	@Column(name = "Status", columnDefinition = "BIT")
	private boolean status;
	
	@Column(name = "Token", columnDefinition = "NVARCHAR(255)")
	private String token;
	
	@OneToMany(mappedBy = "customerUserInfo", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<Customer> listCustomer = new ArrayList<Customer>();
	
	@OneToMany(mappedBy = "regimenDetailsUserInfo", cascade = {CascadeType.PERSIST,CascadeType.MERGE})
	private List<RegimenDetails> listRegimenDetails = new ArrayList<RegimenDetails>();
	
    @Transient
    public List<GrantedAuthority> getAuthorities() {
    List<GrantedAuthority> authorities = new ArrayList<GrantedAuthority>();
    authorities.add(new SimpleGrantedAuthority(this.roles));
    return authorities;
   }
}

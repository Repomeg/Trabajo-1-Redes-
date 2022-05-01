package com.example.demo.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;

import com.example.demo.models.rut;
import com.example.demo.services.rutService;

@RestController
@CrossOrigin(origins = "*", allowedHeaders = "*")
@RequestMapping("/rut")
public class rutController {
	@Autowired
	rutService rutService;
	
	private rut rut1;
	@GetMapping()
	public rut obtenerRut(){
		return rut1;
	}
	@PostMapping()
	public rut guardarRut(@RequestBody rut x) {
		this.rutService.verifyRut(x);
		this.rut1 = x;
		return this.rut1;
	}
	
}

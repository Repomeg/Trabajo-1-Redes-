package com.example.demo.models;

public class rut{


	private int rutValue;
	private String verifyCode;
	private boolean validate;
	

	public int getRut() {
		return rutValue;
	}
	public void setRut(int Rut) {
		this.rutValue = Rut;
	}
	public String getVerifyCode() {
		return verifyCode;
	}
	
	public void setVerifyCode(String VerifyCode) {
		this.verifyCode = VerifyCode;
	}
	public boolean getValidate() {
		return validate;
	}
	public void setValidate(boolean validate) {
		this.validate = validate;
	}
}

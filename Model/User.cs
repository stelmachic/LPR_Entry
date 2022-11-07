using System;
using Interfaces;
using DAO;
using DTO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
 
namespace Model;
public class User
{
    protected String name;
    protected DateTime date_of_birth;
    protected String phone;
    protected String edv;
    protected String admin;
    public string Name{get;set; }
    public string Date_of_birth{get;set;}
    public string Phone{get;set;}
    public string Edv{get;set;}
    public string Admin{get;set;}
}

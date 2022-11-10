using System;
using Interfaces;
using DAO;
using DTO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
 
namespace Model;
public class User
{
    public String name{get;set; }
    public DateTime date_of_birth{get;set; }
    public String phone{get;set; }
    public String edv{get;set; }
    public String admin{get;set; }
}

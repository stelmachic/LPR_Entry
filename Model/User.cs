using System;
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
    
    public void setName(String name)
    {
        this.name = name;
    }
    public void setDate_of_birth(DateTime date_of_birth)
    {
        this.date_of_birth = date_of_birth;
    }
    public void setPhone(String phone)
    {
        this.phone = phone;
    }
    public void setEdv(String edv)
    {
        this.edv = edv;
    }
}

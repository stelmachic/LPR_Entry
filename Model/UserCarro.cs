using System;
using DAO;
using DTO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
 
namespace Model;

public class UserCarro
{
    public User User { get; set; }
    public Carro Carro { get; set; }
}
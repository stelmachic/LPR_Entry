using System;
using DAO;
using DTO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
 
namespace Model;

public class Carro
{
    public String Placa { get; set; }

    public Carro(String placa)
    {
        Placa = placa;
    }
}
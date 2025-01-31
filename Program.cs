using System;
using System.Linq;
using Blog_entityframework.Data;
using Blog_entityframework.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog_entityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();
            
        }
    }
}
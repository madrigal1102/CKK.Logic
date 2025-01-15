﻿using CKK.DB.Interfaces;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CKK.DB.Repositary
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public ProductRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }
        public int Add(Product entity)
        {
            var sql = "INSERT INTO Products (Price,Quantity,Name, ImagePath) VALUES (@Price,@Quantity,@Name, @ImagePath)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }

        public int Delete(int id)
        {
            var sql = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Id = id });
                return result;
            }
        }

        public List<Product> GetAll()
        {
            var sql = "SELECT * FROM Products";
            using (var connection = _connectionFactory.GetConnection)
            {
                var result = connection.Query<Product>(sql).ToList();
                return result;
            }
        }

        public Product GetById(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault<Product>(sql, new { Id = id });
                return result;
            }
        }

        public List<Product> GetByName(string name)
        {
            var sql = "SELECT * FROM Products WHERE Name = @Name";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault<List<Product>>(sql, new { Name = name });
                return result;
            };
        }

        public int Update(Product entity)
        {
            var sql = "UPDATE Products SET Price=@Price, Quantity=@Quantity, Name=@Name, ImagePath=@ImagePath WHERE Id=@Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }
    }
}

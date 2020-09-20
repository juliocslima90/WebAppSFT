using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SFT.ApplicationCore.Entity;

namespace SFT.Infrasctructure.Data
{
    public static class DBInitializer
    {
        public static void Initialize(FinanceiroContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "João da Silva",
                    CPF = "11111111111",
                    Endereco = "Rua de cima",
                    Numero = "1",
                    Bairro = "Centro",
                    Cidade = "Aracaju",
                    Email = "joaosilva@sft.com.br",
                    Limite = 100
                },
                new Cliente
                {
                    Nome = "Maria da Silva",
                    CPF = "01010101010",
                    Endereco = "Rua de baixo",
                    Numero = "21",
                    Bairro = "Orla",
                    Cidade = "Aracaju",
                    Email = "mariasilva@sft.com.br",
                    Limite = 5000
                }
            };

            context.AddRange(clientes);

            var produtos = new Produto[]
            {
                new Produto
                {
                    Descricao = "Macarrão ao alho e óleo",
                    CodBarra = 789010001,
                    Valor = 15,
                    Quantidade = 10
                },
                new Produto
                {
                    Descricao = "Churrasco de toscana",
                    CodBarra = 789010002,
                    Valor = 18,
                    Quantidade = 14
                }
            };

            context.AddRange(produtos);

            context.SaveChanges();
        }
    }
}

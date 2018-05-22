using AutoMapper;
using DDDArquitetura.Domain.Entities;
using DDDArquitetura.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDDArquitetura.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Cliente, ClienteViewModel>();
                x.CreateMap<ClienteViewModel, Cliente>();
                x.CreateMap<Produto, ProdutoViewModel>();
            });
        }
    }
}
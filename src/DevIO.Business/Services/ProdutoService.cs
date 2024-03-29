﻿using DevIO.App.Interfaces;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository,
                              INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }
    }

}

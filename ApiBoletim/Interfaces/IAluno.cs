﻿using ApiBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBoletim.Interfaces
{
    interface IAluno
    {
        Aluno cadastrar(Aluno a);
        List<Aluno> LerTodos();
        Aluno BuscarPorId(int id);
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);
    }
}

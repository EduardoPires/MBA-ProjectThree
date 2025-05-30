﻿
using BuildingBlocks.Results;
using MediatR;

namespace AlunoContext.Application.Commands.EditarAluno;

public class EditarAlunoComando : IRequest<Result>
{
    public Guid Id { get; }
    public string Nome { get; }
    public string Email { get; }

    public EditarAlunoComando(Guid id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        Email = email;
    }
}

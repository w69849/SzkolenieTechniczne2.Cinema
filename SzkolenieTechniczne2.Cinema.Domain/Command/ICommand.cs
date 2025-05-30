﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Domain.Command
{
    public interface ICommand<TResult> : IRequest<TResult>
    {

    }
}

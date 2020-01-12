﻿using Core.Application.Command;
using System;

namespace Test.Application.Commands.CreateTest
{
    public class CreateTestCommand : ICommand
    {
        public CreateTestCommand(string name)
        {
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
    }
}

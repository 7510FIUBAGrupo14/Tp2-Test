﻿using System;
using System.IO;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Output
{
    public class DuoComponent : IOutputComponent
    {
        private ConsoleComponent _console;
        private FileComponent _file;
        public DuoComponent()
        {
            _console = new ConsoleComponent();
            _file = new FileComponent();
        }
        public void PrintTestCase(ReportDto dto)
        {
            _console.PrintTestCase(dto);
            _file.PrintTestCase(dto);
        }

        public void PrintTestSuite(ReportDto dto)
        {
            _console.PrintTestSuite(dto);
            _file.PrintTestSuite(dto);
        }

    }
}

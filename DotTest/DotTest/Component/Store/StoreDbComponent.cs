using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using DotTest.Component.Db.DataSetTableAdapters;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;

namespace DotTest.Component.Store
{
    /// <summary> 
    /// Prints on plain file all tests' run.
    /// </summary>
    
    public class StoreDbComponent : IInpOutComponent
    {
        private StoreTableAdapter table;

        public void PrintTestCase(CaseDto dto)
        {
            if (dto.Result == ResultType.Ok)
            {
                if (table.Existe(dto.FullName) != 1)
                {
                    table.InsertTestResult(dto.FullName, true);
                }
                else
                {
                    table.UpdateTestResult(true, dto.FullName);
                }
            }

        }

        public void PrintTestSuite(SuiteDto dto)
        {
        }

        public void PrintSummary()
        {
        }

        public bool SkipeCase(CaseDto dto)
        {
            return table.SkipCase(dto.FullName) == 1;
        }

        public StoreDbComponent()
        {
            table = new StoreTableAdapter();
        }

    }
}

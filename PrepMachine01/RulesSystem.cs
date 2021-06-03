using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRule
    {

    }

    public interface IConditionRule
    {

    }

    public interface IActionRule
    {

    }

    public enum LabelType
    {
        OPERATOR_SOURCE_NAME, 
        FIRST_PASS_INITIALIZED, 
        FIRST_PASS_PASSED,
        SECOND_PASS_INITIALIZED,
        SECOND_PASS_PASSED,
        THIRD_INITIALIZED,
        THIRD_PASSED,
        PARSING_HEAD_OF_XLSX,
        PARCING_BODY_TABLE_OF_XLSX,
        PARCING_HEAD_OF_XLSX_INITIALIZED,
        PARCING_HEAD_OF_XLSX_PASSED,
        PARCING_BODY_TABLE_OF_XLSX_INITIALIZED,
        PARCING_BODY_TABLE_OF_XLSX_PASSED
    }
}

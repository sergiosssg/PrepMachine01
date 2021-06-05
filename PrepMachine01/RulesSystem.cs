﻿using System;
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


    public interface ILabelOfPrecessing
    {
        public LabelType getThisLabelType();
        public string getValueAsString();
        public long getValueAsLong();
        public int getValueAsInt();
        public DateTime getValueAsDate();
        public decimal getValueAsDecimal();
        public bool getValueAsBool();
        public bool isLabelActive();
        public void setAsPassive();

    }

    
    public enum ComparisonOperatorType
    {
        GT,
        LT,
        GE,
        LE,
        EQ,
        NE
    }

    public enum OperandComparisonType
    {
        INT,
        LONG,
        DATE,
        DECIMAL,
        STRING,
        BOOL
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
        PARCING_BODY_TABLE_OF_XLSX_PASSED,
        INVOICE_DATE,
        RAW_DOCUMENT_NUMBER_ROW,
        RAW_DOCUMENT_NUMBER_COLUMN,
        RAW_ROW_SPLITTED_INTO_CELLS
    }
}

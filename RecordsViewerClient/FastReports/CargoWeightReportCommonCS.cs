using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FastReport;
using FastReport.Data;
using FastReport.Dialog;
using FastReport.Barcode;
using FastReport.Table;
using FastReport.Utils;

namespace RecordsViewerClient.FastReports
{
  public class CargoWeightReportCommonCS : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.DataBand Data1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.ReportSummaryBand ReportSummary1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text20;
    public FastReport.TextObject Text23;
    public FastReport.TextObject Text25;
    public FastReport.TextObject Text26;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text30;
    public FastReport.TextObject Text31;
    public FastReport.TextObject Text32;
    public FastReport.TextObject Text34;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text44;
    public FastReport.TextObject Text45;
    public FastReport.TextObject Text46;
    public FastReport.TextObject Text47;
    public FastReport.TextObject TextOperationTypeHeader;
    public FastReport.TextObject TextOperationTypeValue;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\CommonCargoWeightFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\CommonCargoWeightFastReport.xml";
      return null;
    }

    private SByte Abs(SByte value)
    {
      return System.Math.Abs(value);
    }

    private Int16 Abs(Int16 value)
    {
      return System.Math.Abs(value);
    }

    private Int32 Abs(Int32 value)
    {
      return System.Math.Abs(value);
    }

    private Int64 Abs(Int64 value)
    {
      return System.Math.Abs(value);
    }

    private Single Abs(Single value)
    {
      return System.Math.Abs(value);
    }

    private Double Abs(Double value)
    {
      return System.Math.Abs(value);
    }

    private Decimal Abs(Decimal value)
    {
      return System.Math.Abs(value);
    }

    private Double Acos(Double d)
    {
      return System.Math.Acos(d);
    }

    private Double Asin(Double d)
    {
      return System.Math.Asin(d);
    }

    private Double Atan(Double d)
    {
      return System.Math.Atan(d);
    }

    private Double Ceiling(Double a)
    {
      return System.Math.Ceiling(a);
    }

    private Decimal Ceiling(Decimal d)
    {
      return System.Math.Ceiling(d);
    }

    private Double Cos(Double d)
    {
      return System.Math.Cos(d);
    }

    private Double Exp(Double d)
    {
      return System.Math.Exp(d);
    }

    private Double Floor(Double d)
    {
      return System.Math.Floor(d);
    }

    private Decimal Floor(Decimal d)
    {
      return System.Math.Floor(d);
    }

    private Double Log(Double d)
    {
      return System.Math.Log(d);
    }

    private Int32 Maximum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int64 Maximum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Single Maximum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Double Maximum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Decimal Maximum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int32 Minimum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int64 Minimum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Single Minimum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Minimum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Decimal Minimum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Round(Double a)
    {
      return System.Math.Round(a);
    }

    private Decimal Round(Decimal d)
    {
      return System.Math.Round(d);
    }

    private Double Round(Double value, Int32 digits)
    {
      return System.Math.Round(value, digits);
    }

    private Decimal Round(Decimal d, Int32 decimals)
    {
      return System.Math.Round(d, decimals);
    }

    private Double Sin(Double a)
    {
      return System.Math.Sin(a);
    }

    private Double Sqrt(Double d)
    {
      return System.Math.Sqrt(d);
    }

    private Double Tan(Double a)
    {
      return System.Math.Tan(a);
    }

    private Double Truncate(Double d)
    {
      return System.Math.Truncate(d);
    }

    private Decimal Truncate(Decimal d)
    {
      return System.Math.Truncate(d);
    }

    private Int32 Asc(Char c)
    {
      return FastReport.Functions.StdFunctions.Asc(c);
    }

    private Char Chr(Int32 i)
    {
      return FastReport.Functions.StdFunctions.Chr(i);
    }

    private String Insert(String s, Int32 startIndex, String value)
    {
      return FastReport.Functions.StdFunctions.Insert(s, startIndex, value);
    }

    private Int32 Length(String s)
    {
      return FastReport.Functions.StdFunctions.Length(s);
    }

    private String LowerCase(String s)
    {
      return FastReport.Functions.StdFunctions.LowerCase(s);
    }

    private String PadLeft(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth);
    }

    private String PadLeft(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth, paddingChar);
    }

    private String PadRight(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth);
    }

    private String PadRight(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth, paddingChar);
    }

    private String Remove(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex);
    }

    private String Remove(String s, Int32 startIndex, Int32 count)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex, count);
    }

    private String Replace(String s, String oldValue, String newValue)
    {
      return FastReport.Functions.StdFunctions.Replace(s, oldValue, newValue);
    }

    private String Substring(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex);
    }

    private String Substring(String s, Int32 startIndex, Int32 length)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex, length);
    }

    private String TitleCase(String s)
    {
      return FastReport.Functions.StdFunctions.TitleCase(s);
    }

    private String Trim(String s)
    {
      return FastReport.Functions.StdFunctions.Trim(s);
    }

    private String UpperCase(String s)
    {
      return FastReport.Functions.StdFunctions.UpperCase(s);
    }

    private DateTime AddDays(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddDays(date, value);
    }

    private DateTime AddHours(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddHours(date, value);
    }

    private DateTime AddMinutes(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddMinutes(date, value);
    }

    private DateTime AddMonths(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddMonths(date, value);
    }

    private DateTime AddSeconds(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddSeconds(date, value);
    }

    private DateTime AddYears(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddYears(date, value);
    }

    private TimeSpan DateDiff(DateTime date1, DateTime date2)
    {
      return FastReport.Functions.StdFunctions.DateDiff(date1, date2);
    }

    private DateTime DateSerial(Int32 year, Int32 month, Int32 day)
    {
      return FastReport.Functions.StdFunctions.DateSerial(year, month, day);
    }

    private Int32 Day(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Day(date);
    }

    private String DayOfWeek(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfWeek(date);
    }

    private Int32 DayOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfYear(date);
    }

    private Int32 DaysInMonth(Int32 year, Int32 month)
    {
      return FastReport.Functions.StdFunctions.DaysInMonth(year, month);
    }

    private Int32 Hour(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Hour(date);
    }

    private Int32 Minute(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Minute(date);
    }

    private Int32 Month(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Month(date);
    }

    private String MonthName(Int32 month)
    {
      return FastReport.Functions.StdFunctions.MonthName(month);
    }

    private Int32 Second(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Second(date);
    }

    private Int32 WeekOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.WeekOfYear(date);
    }

    private Int32 Year(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Year(date);
    }

    private String Format(String format, params Object[] args)
    {
      return FastReport.Functions.StdFunctions.Format(format, args);
    }

    private String FormatCurrency(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value);
    }

    private String FormatCurrency(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value, decimalDigits);
    }

    private String FormatDateTime(DateTime value)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value);
    }

    private String FormatDateTime(DateTime value, String format)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value, format);
    }

    private String FormatNumber(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value);
    }

    private String FormatNumber(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value, decimalDigits);
    }

    private String FormatPercent(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value);
    }

    private String FormatPercent(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value, decimalDigits);
    }

    private Boolean ToBoolean(Object value)
    {
      return System.Convert.ToBoolean(value);
    }

    private Byte ToByte(Object value)
    {
      return System.Convert.ToByte(value);
    }

    private Char ToChar(Object value)
    {
      return System.Convert.ToChar(value);
    }

    private DateTime ToDateTime(Object value)
    {
      return System.Convert.ToDateTime(value);
    }

    private Decimal ToDecimal(Object value)
    {
      return System.Convert.ToDecimal(value);
    }

    private Double ToDouble(Object value)
    {
      return System.Convert.ToDouble(value);
    }

    private Int32 ToInt32(Object value)
    {
      return System.Convert.ToInt32(value);
    }

    private String ToRoman(Object value)
    {
      return FastReport.Functions.StdFunctions.ToRoman(value);
    }

    private Single ToSingle(Object value)
    {
      return System.Convert.ToSingle(value);
    }

    private String ToString(Object value)
    {
      return System.Convert.ToString(value);
    }

    private String ToWords(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWords(value);
    }

    private String ToWords(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName);
    }

    private String ToWords(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many);
    }

    private String ToWordsEnGb(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value);
    }

    private String ToWordsEnGb(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName);
    }

    private String ToWordsEnGb(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many);
    }

    private String ToWordsEs(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value);
    }

    private String ToWordsEs(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName);
    }

    private String ToWordsEs(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many);
    }

    private String ToWordsRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value);
    }

    private String ToWordsRu(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many);
    }

    private Object Choose(Double index, params Object[] choice)
    {
      return FastReport.Functions.StdFunctions.Choose(index, choice);
    }

    private Object IIf(Boolean expression, Object truePart, Object falsePart)
    {
      return FastReport.Functions.StdFunctions.IIf(expression, truePart, falsePart);
    }

    private Object Switch(params Object[] expressions)
    {
      return FastReport.Functions.StdFunctions.Switch(expressions);
    }

    private Boolean IsNull(String name)
    {
      return FastReport.Functions.StdFunctions.IsNull(Report, name);
    }

    private void InitializeComponent()
    {
      string reportString = 
        "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ScriptLanguage=\"CSharp\" ReportI" +
        "nfo.Created=\"05/30/2019 13:03:21\" ReportInfo.Modified=\"06/14/2019 08:11:09\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\CommonCargoWeightFastReport.xml\">\r\n      <TableDataSource Name=\"dircargoC" +
        "ommon\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"dircargoCommon\">\r\n     " +
        "   <Column Name=\"Cargo\" DataType=\"System.String\"/>\r\n        <Column Name=\"Icomin" +
        "gWeight\" DataType=\"System.Double\"/>\r\n        <Column Name=\"OutcomingWeight\" Data" +
        "Type=\"System.Double\"/>\r\n      </TableDataSource>\r\n    </XmlDataConnection>\r\n    " +
        "<Parameter Name=\"StartDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"E" +
        "ndDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"CounterpartyName\" Dat" +
        "aType=\"System.String\"/>\r\n    <Parameter Name=\"CarrierName\" DataType=\"System.Stri" +
        "ng\"/>\r\n    <Parameter Name=\"Connect_String\" DataType=\"System.String\"/>\r\n    <Tot";
      reportString += "al Name=\"TotalIncoming\" Expression=\"[dircargoCommon.IcomingWeight]\" Evaluator=\"D" +
        "ata1\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalOutcoming\" Expression=\"[" +
        "dircargoCommon.OutcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"ReportSummary1\"/>\r\n " +
        " </Dictionary>\r\n  <ReportPage Name=\"Page1\" PaperWidth=\"297\">\r\n    <ReportTitleBa" +
        "nd Name=\"ReportTitle1\" Width=\"1047.06\" Height=\"75.6\">\r\n      <TextObject Name=\"T" +
        "ext1\" Left=\"9.45\" Top=\"9.45\" Width=\"321.3\" Height=\"18.9\" Text=\"Общий отчет по гр" +
        "узам\" Font=\"Arial, 12pt, style=Bold\"/>\r\n      <TextObject Name=\"Text2\" Left=\"9.4" +
        "5\" Top=\"28.35\" Width=\"85.05\" Height=\"18.9\" Text=\"За период с\"/>\r\n      <TextObje" +
        "ct Name=\"Text12\" Left=\"94.5\" Top=\"28.35\" Width=\"207.9\" Height=\"18.9\" Text=\"[Star" +
        "tDate]\" Format=\"Date\" Format.Format=\"F\"/>\r\n      <TextObject Name=\"Text35\" Left=" +
        "\"340.2\" Top=\"28.35\" Width=\"226.8\" Height=\"18.9\" Text=\"[EndDate]\" Format=\"Date\" F" +
        "ormat.Format=\"F\"/>\r\n      <TextObject Name=\"Text44\" Left=\"302.4\" Top=\"28.35\" Wid";
      reportString += "th=\"37.8\" Height=\"18.9\" Text=\" по \"/>\r\n      <TextObject Name=\"TextOperationType" +
        "Header\" Left=\"9.45\" Top=\"47.25\" Width=\"113.4\" Height=\"18.9\" Text=\"Контрагент:\" V" +
        "ertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"TextO" +
        "perationTypeValue\" Left=\"122.85\" Top=\"47.25\" Width=\"226.8\" Height=\"18.9\" Border." +
        "Lines=\"Bottom\" Text=\"[CounterpartyName]\" VertAlign=\"Center\" Font=\"Arial, 9pt\"/>\r" +
        "\n      <TextObject Name=\"Text46\" Left=\"349.65\" Top=\"47.25\" Width=\"113.4\" Height=" +
        "\"18.9\" Text=\"Перевозчик:\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n  " +
        "    <TextObject Name=\"Text47\" Left=\"463.05\" Top=\"47.25\" Width=\"226.8\" Height=\"18" +
        ".9\" Border.Lines=\"Bottom\" Text=\"[CarrierName]\" VertAlign=\"Center\" Font=\"Arial, 9" +
        "pt\"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top=\"79.6\"" +
        " Width=\"1047.06\" Height=\"37.8\">\r\n      <TextObject Name=\"Text3\" Width=\"47.25\" He" +
        "ight=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"№ п/п\" HorzAlign=\"Center";
      reportString += "\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Te" +
        "xt11\" Left=\"47.25\" Width=\"576.45\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=" +
        "\"1.5\" Text=\"Наименование груза\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Aria" +
        "l, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text14\" Left=\"926.1\" Width=\"113.4" +
        "\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Снято, т (% сорн.)\" " +
        "HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <Te" +
        "xtObject Name=\"Text30\" Left=\"623.7\" Width=\"151.2\" Height=\"37.8\" Border.Lines=\"Al" +
        "l\" Border.Width=\"1.5\" Text=\"Отгружено, т\" HorzAlign=\"Center\" VertAlign=\"Center\" " +
        "Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text32\" Left=\"774.9\" Wi" +
        "dth=\"151.2\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Принято, т" +
        "\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    </P" +
        "ageHeaderBand>\r\n    <DataBand Name=\"Data1\" Top=\"121.4\" Width=\"1047.06\" Height=\"3";
      reportString += "7.8\" DataSource=\"dircargoCommon\">\r\n      <TextObject Name=\"Text15\" Width=\"47.25\"" +
        " Height=\"37.8\" Border.Lines=\"All\" Text=\"[AbsRow#]\" HorzAlign=\"Center\" VertAlign=" +
        "\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text20\" Left=\"47.25\" Wi" +
        "dth=\"576.45\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircargoCommon.Cargo]\" Horz" +
        "Align=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name" +
        "=\"Text23\" Left=\"926.1\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" HorzAlign=" +
        "\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text" +
        "31\" Left=\"623.7\" Width=\"151.2\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircargoC" +
        "ommon.OutcomingWeight]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalD" +
        "igits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativeP" +
        "attern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <" +
        "TextObject Name=\"Text34\" Left=\"774.9\" Width=\"151.2\" Height=\"37.8\" Border.Lines=\"";
      reportString += "All\" Text=\"[dircargoCommon.IcomingWeight]\" Format=\"Number\" Format.UseLocale=\"fal" +
        "se\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\"" +
        " \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial," +
        " 8.25pt\"/>\r\n    </DataBand>\r\n    <ReportSummaryBand Name=\"ReportSummary1\" Top=\"1" +
        "63.2\" Width=\"1047.06\" Height=\"28.35\">\r\n      <TextObject Name=\"Text25\" Width=\"62" +
        "3.7\" Height=\"28.35\" Border.Lines=\"All\" Text=\"ИТОГ ОБЩИЙ\" VertAlign=\"Center\" Font" +
        "=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text26\" Left=\"774.9\" Width=" +
        "\"151.2\" Height=\"28.35\" Border.Lines=\"All\" Text=\"[TotalIncoming]\" Format=\"Number\"" +
        " Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" F" +
        "ormat.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign" +
        "=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text27\" Left=" +
        "\"926.1\" Width=\"113.4\" Height=\"28.35\" Border.Lines=\"All\" HorzAlign=\"Center\" VertA";
      reportString += "lign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text45\" Left=\"623." +
        "7\" Width=\"151.2\" Height=\"28.35\" Border.Lines=\"All\" Text=\"[TotalOutcoming]\" Forma" +
        "t=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSepar" +
        "ator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\"" +
        " VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    </ReportSummaryBand>\r\n " +
        "   <PageFooterBand Name=\"PageFooter1\" Top=\"195.55\" Width=\"1047.06\" Height=\"37.8\"" +
        ">\r\n      <TextObject Name=\"Text29\" Left=\"888.3\" Top=\"18.9\" Width=\"151.2\" Height=" +
        "\"18.9\" Text=\"[PageNofM]\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"Arial, 8.25p" +
        "t\"/>\r\n      <TextObject Name=\"Text28\" Top=\"18.9\" Width=\"321.3\" Height=\"18.9\" Tex" +
        "t=\"Дата формирования отчета [Date]\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n " +
        "   </PageFooterBand>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public CargoWeightReportCommonCS()
    {
      InitializeComponent();
    }
  }
}

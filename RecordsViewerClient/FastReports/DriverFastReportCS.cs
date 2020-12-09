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
  public class DriverFastReportCS : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.DataBand Data1;
    public FastReport.GroupFooterBand GroupFooter1;
    public FastReport.GroupFooterBand GroupFooter2;
    public FastReport.GroupFooterBand GroupFooter3;
    public FastReport.GroupHeaderBand GroupHeader1;
    public FastReport.GroupHeaderBand GroupHeader2;
    public FastReport.GroupHeaderBand GroupHeader3;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.ReportSummaryBand ReportSummary1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text10;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text13;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text16;
    public FastReport.TextObject Text17;
    public FastReport.TextObject Text18;
    public FastReport.TextObject Text19;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text20;
    public FastReport.TextObject Text21;
    public FastReport.TextObject Text22;
    public FastReport.TextObject Text25;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text30;
    public FastReport.TextObject Text32;
    public FastReport.TextObject Text33;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text37;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text44;
    public FastReport.TextObject Text45;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text58;
    public FastReport.TextObject Text59;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text60;
    public FastReport.TextObject Text61;
    public FastReport.TextObject Text62;
    public FastReport.TextObject Text64;
    public FastReport.TextObject Text65;
    public FastReport.TextObject Text66;
    public FastReport.TextObject Text67;
    public FastReport.TextObject Text68;
    public FastReport.TextObject Text69;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text70;
    public FastReport.TextObject Text71;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "IIf([dirdriver.Counterparty]==\"\", \"Не указан\", [dirdriver.Counterparty])")
        return IIf(((String)Report.GetColumnValue("dirdriver.Counterparty"))=="", "Не указан", ((String)Report.GetColumnValue("dirdriver.Counterparty")));
      if (expression == "IIf([dirdriver.Driver] != \"\", [dirdriver.Driver], \"Не указан\")")
        return IIf(((String)Report.GetColumnValue("dirdriver.Driver")) != "", ((String)Report.GetColumnValue("dirdriver.Driver")), "Не указан");
      if (expression == "IIf([dirdriver.Driver]==\"\", \"Итого\", \"Итого по \" + [dirdriver.Driver])")
        return IIf(((String)Report.GetColumnValue("dirdriver.Driver"))=="", "Итого", "Итого по " + ((String)Report.GetColumnValue("dirdriver.Driver")));
      if (expression == "IIf([dirdriver.Counterparty]==\"\", \"Итого\", \"Итого по \" + [dirdriver.Counterparty])")
        return IIf(((String)Report.GetColumnValue("dirdriver.Counterparty"))=="", "Итого", "Итого по " + ((String)Report.GetColumnValue("dirdriver.Counterparty")));
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\DriverFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\DriverFastReport.xml";
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
        "nfo.Created=\"05/31/2019 14:54:09\" ReportInfo.Modified=\"06/14/2019 08:16:39\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\DriverFastReport.xml\">\r\n      <TableDataSource Name=\"dirdriver\" DataType=" +
        "\"System.Int32\" Enabled=\"true\" TableName=\"dirdriver\">\r\n        <Column Name=\"id\" " +
        "DataType=\"System.Int64\"/>\r\n        <Column Name=\"DateWeightShort\" DataType=\"Syst" +
        "em.DateTime\"/>\r\n        <Column Name=\"DateTimeSecondWeight\" DataType=\"System.Dat" +
        "eTime\"/>\r\n        <Column Name=\"TransportNumber\" DataType=\"System.String\"/>\r\n   " +
        "     <Column Name=\"TypeOfTransport\" DataType=\"System.String\"/>\r\n        <Column " +
        "Name=\"Invoice\" DataType=\"System.String\"/>\r\n        <Column Name=\"Cargo\" DataType" +
        "=\"System.String\"/>\r\n        <Column Name=\"Carrier\" DataType=\"System.String\"/>\r\n " +
        "       <Column Name=\"Counterparty\" DataType=\"System.String\"/>\r\n        <Column N";
      reportString += "ame=\"Driver\" DataType=\"System.String\"/>\r\n        <Column Name=\"TypeOfOperation\" " +
        "DataType=\"System.String\"/>\r\n        <Column Name=\"Netto\" DataType=\"System.Double" +
        "\"/>\r\n      </TableDataSource>\r\n    </XmlDataConnection>\r\n    <Parameter Name=\"St" +
        "artDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"EndDate\" DataType=\"S" +
        "ystem.DateTime\"/>\r\n    <Parameter Name=\"Connect_String\" DataType=\"System.String\"" +
        "/>\r\n    <Total Name=\"TotalNetto\" Expression=\"[dirdriver.Netto]\" Evaluator=\"Data1" +
        "\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalNettoCounterparty\" Expressio" +
        "n=\"[dirdriver.Netto]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter1\"/>\r\n    <Total Nam" +
        "e=\"TotalNettoCounterpartyDriver\" Expression=\"[dirdriver.Netto]\" Evaluator=\"Data1" +
        "\" PrintOn=\"GroupFooter2\"/>\r\n    <Total Name=\"TotalNettoCounterpartyDriverCargo\" " +
        "Expression=\"[dirdriver.Netto]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter3\"/>\r\n    <" +
        "Total Name=\"TotalCount\" TotalType=\"Count\" Evaluator=\"Data1\" PrintOn=\"ReportSumma";
      reportString += "ry1\"/>\r\n    <Total Name=\"TotalCountCounterparty\" TotalType=\"Count\" Evaluator=\"Da" +
        "ta1\" PrintOn=\"GroupFooter1\"/>\r\n    <Total Name=\"TotalCountCounterpartyDriver\" To" +
        "talType=\"Count\" Evaluator=\"Data1\" PrintOn=\"GroupFooter2\"/>\r\n    <Total Name=\"Tot" +
        "alCountCounterpartyDriverCargo\" TotalType=\"Count\" Evaluator=\"Data1\" PrintOn=\"Gro" +
        "upFooter3\"/>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\" PaperWidth=\"297\">\r\n   " +
        " <ReportTitleBand Name=\"ReportTitle1\" Width=\"1047.06\" Height=\"37.8\">\r\n      <Tex" +
        "tObject Name=\"Text1\" Width=\"321.3\" Height=\"18.9\" Text=\"Отчет по водителям\" Font=" +
        "\"Arial, 12pt, style=Bold\"/>\r\n      <TextObject Name=\"Text2\" Top=\"18.9\" Width=\"85" +
        ".05\" Height=\"18.9\" Text=\"За период с\"/>\r\n      <TextObject Name=\"Text12\" Left=\"8" +
        "5.05\" Top=\"18.9\" Width=\"236.25\" Height=\"18.9\" Text=\"[StartDate]\" Format=\"Date\" F" +
        "ormat.Format=\"F\"/>\r\n      <TextObject Name=\"Text35\" Left=\"359.1\" Top=\"18.9\" Widt" +
        "h=\"245.7\" Height=\"18.9\" Text=\"[EndDate]\" Format=\"Date\" Format.Format=\"F\"/>\r\n    ";
      reportString += "  <TextObject Name=\"Text44\" Left=\"321.3\" Top=\"18.9\" Width=\"37.8\" Height=\"18.9\" T" +
        "ext=\" по \"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top" +
        "=\"41.8\" Width=\"1047.06\" Height=\"37.8\">\r\n      <TextObject Name=\"Text6\" Left=\"113" +
        ".4\" Top=\"18.9\" Width=\"75.6\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" " +
        "Text=\"Номер\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"" +
        "/>\r\n      <TextObject Name=\"Text7\" Left=\"189\" Top=\"18.9\" Width=\"75.6\" Height=\"18" +
        ".9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тип\" HorzAlign=\"Center\" VertAlig" +
        "n=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text9\" Left=" +
        "\"264.6\" Top=\"18.9\" Width=\"113.4\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"" +
        "1.5\" Text=\"Номер, дата\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, " +
        "style=Bold\"/>\r\n      <TextObject Name=\"Text3\" Width=\"37.8\" Height=\"37.8\" Border." +
        "Lines=\"All\" Border.Width=\"1.5\" Text=\"№ п/п\" HorzAlign=\"Center\" VertAlign=\"Center";
      reportString += "\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text4\" Left=\"37.8\" Wi" +
        "dth=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Время\" Horz" +
        "Align=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextOb" +
        "ject Name=\"Text5\" Left=\"113.4\" Width=\"151.2\" Height=\"18.9\" Border.Lines=\"All\" Bo" +
        "rder.Width=\"1.5\" Text=\"Транспорт\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar" +
        "ial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text8\" Left=\"264.6\" Width=\"113." +
        "4\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Накладная\" HorzAlig" +
        "n=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject" +
        " Name=\"Text10\" Left=\"378\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" Border." +
        "Width=\"1.5\" Text=\"Груз\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, " +
        "style=Bold\"/>\r\n      <TextObject Name=\"Text11\" Left=\"633.15\" Width=\"141.75\" Heig" +
        "ht=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Контрагент\" HorzAlign=\"Cen";
      reportString += "ter\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=" +
        "\"Text13\" Left=\"954.45\" Width=\"85.05\" Height=\"37.8\" Border.Lines=\"All\" Border.Wid" +
        "th=\"1.5\" Text=\"Перевезено, т\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial," +
        " 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text30\" Left=\"491.4\" Width=\"141.75\"" +
        " Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Перевозчик\" HorzAlign" +
        "=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject " +
        "Name=\"Text32\" Left=\"888.3\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Border" +
        ".Width=\"1.5\" Text=\"Кол-во рейсов\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar" +
        "ial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text33\" Left=\"774.9\" Width=\"113" +
        ".4\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тип операции\" Horz" +
        "Align=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    </PageHea" +
        "derBand>\r\n    <GroupHeaderBand Name=\"GroupHeader1\" Top=\"83.6\" Width=\"1047.06\" He";
      reportString += "ight=\"28.35\" Condition=\"[dirdriver.Counterparty]\">\r\n      <TextObject Name=\"Text" +
        "37\" Width=\"1039.5\" Height=\"28.35\" Border.Lines=\"All\" Text=\"Контрагент: [IIf([dir" +
        "driver.Counterparty]==&quot;&quot;, &quot;Не указан&quot;, [dirdriver.Counterpar" +
        "ty])]\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <GroupHeaderBan" +
        "d Name=\"GroupHeader2\" Top=\"115.95\" Width=\"1047.06\" Height=\"28.35\" Condition=\"[di" +
        "rdriver.Driver]\">\r\n        <TextObject Name=\"Text62\" Width=\"1039.5\" Height=\"28.3" +
        "5\" Border.Lines=\"All\" Text=\"Водитель: \" VertAlign=\"Center\" Font=\"Arial, 9pt, sty" +
        "le=Bold\"/>\r\n        <TextObject Name=\"Text14\" Left=\"66.15\" Width=\"359.1\" Height=" +
        "\"28.35\" Text=\"[IIf([dirdriver.Driver] != &quot;&quot;, [dirdriver.Driver], &quot" +
        ";Не указан&quot;)]\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n        " +
        "<GroupHeaderBand Name=\"GroupHeader3\" Top=\"148.3\" Width=\"1047.06\" Condition=\"[dir" +
        "driver.Cargo]\">\r\n          <DataBand Name=\"Data1\" Top=\"152.3\" Width=\"1047.06\" He";
      reportString += "ight=\"37.8\" DataSource=\"dirdriver\">\r\n            <TextObject Name=\"Text15\" Width" +
        "=\"37.8\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[AbsRow#]\" HorzAlign=\"Center\" Ver" +
        "tAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text16\" Le" +
        "ft=\"37.8\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirdriver.DateTim" +
        "eSecondWeight]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n  " +
        "          <TextObject Name=\"Text17\" Left=\"113.4\" Width=\"75.6\" Height=\"37.8\" Bord" +
        "er.Lines=\"All\" Text=\"[dirdriver.TransportNumber]\" HorzAlign=\"Center\" VertAlign=\"" +
        "Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text18\" Left=\"189\"" +
        " Width=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirdriver.TypeOfTransport]" +
        "\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <Tex" +
        "tObject Name=\"Text19\" Left=\"264.6\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All" +
        "\" Text=\"[dirdriver.Invoice]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, ";
      reportString += "8.25pt\"/>\r\n            <TextObject Name=\"Text20\" Left=\"378\" Width=\"113.4\" Height" +
        "=\"37.8\" Border.Lines=\"All\" Text=\"[dirdriver.Cargo]\" HorzAlign=\"Center\" VertAlign" +
        "=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text59\" Left=\"49" +
        "1.4\" Width=\"141.75\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirdriver.Carrier]\" " +
        "HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextO" +
        "bject Name=\"Text21\" Left=\"633.15\" Width=\"141.75\" Height=\"37.8\" Border.Lines=\"All" +
        "\" Text=\"[dirdriver.Counterparty]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar" +
        "ial, 8.25pt\"/>\r\n            <TextObject Name=\"Text22\" Left=\"774.9\" Width=\"113.4\"" +
        " Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirdriver.TypeOfOperation]\" HorzAlign=\"" +
        "Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=" +
        "\"Text60\" Left=\"888.3\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Text=\"1\" Ho" +
        "rzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObj";
      reportString += "ect Name=\"Text61\" Left=\"954.45\" Width=\"85.05\" Height=\"37.8\" Border.Lines=\"All\" T" +
        "ext=\"[dirdriver.Netto]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalD" +
        "igits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativeP" +
        "attern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n       " +
        "   </DataBand>\r\n          <GroupFooterBand Name=\"GroupFooter3\" Top=\"194.1\" Width" +
        "=\"1047.06\" Height=\"28.35\">\r\n            <TextObject Name=\"Text45\" Width=\"888.3\" " +
        "Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"Итого" +
        " по [dirdriver.Cargo]:\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n " +
        "           <TextObject Name=\"Text66\" Left=\"888.3\" Width=\"66.15\" Height=\"28.35\" B" +
        "order.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCountCounterpar" +
        "tyDriverCargo]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style" +
        "=Bold\"/>\r\n            <TextObject Name=\"Text71\" Left=\"954.45\" Width=\"85.05\" Heig";
      reportString += "ht=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalNet" +
        "toCounterpartyDriverCargo]\" Format=\"Number\" Format.UseLocale=\"false\" Format.Deci" +
        "malDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.Negat" +
        "ivePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=" +
        "Bold\"/>\r\n          </GroupFooterBand>\r\n        </GroupHeaderBand>\r\n        <Grou" +
        "pFooterBand Name=\"GroupFooter2\" Top=\"226.45\" Width=\"1047.06\" Height=\"28.35\">\r\n  " +
        "        <TextObject Name=\"Text64\" Width=\"888.3\" Height=\"28.35\" Border.Lines=\"All" +
        "\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[IIf([dirdriv" +
        "er.Driver]==&quot;&quot;, &quot;Итого&quot;, &quot;Итого по &quot; + [dirdriver." +
        "Driver])]:\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n          <TextO" +
        "bject Name=\"Text67\" Left=\"888.3\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\"" +
        " Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCountCou";
      reportString += "nterpartyDriver]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=" +
        "Bold\"/>\r\n          <TextObject Name=\"Text70\" Left=\"954.45\" Width=\"85.05\" Height=" +
        "\"28.35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"" +
        "true\" Text=\"[TotalNettoCounterpartyDriver]\" Format=\"Number\" Format.UseLocale=\"fa" +
        "lse\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=" +
        "\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial" +
        ", 9pt, style=Bold\"/>\r\n        </GroupFooterBand>\r\n      </GroupHeaderBand>\r\n    " +
        "  <GroupFooterBand Name=\"GroupFooter1\" Top=\"258.8\" Width=\"1047.06\" Height=\"28.35" +
        "\">\r\n        <TextObject Name=\"Text65\" Width=\"888.3\" Height=\"28.35\" Border.Lines=" +
        "\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[IIf([dird" +
        "river.Counterparty]==&quot;&quot;, &quot;Итого&quot;, &quot;Итого по &quot; + [d" +
        "irdriver.Counterparty])]:\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n ";
      reportString += "       <TextObject Name=\"Text68\" Left=\"888.3\" Width=\"66.15\" Height=\"28.35\" Borde" +
        "r.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[T" +
        "otalCountCounterparty]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, " +
        "style=Bold\"/>\r\n        <TextObject Name=\"Text69\" Left=\"954.45\" Width=\"85.05\" Hei" +
        "ght=\"28.35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBotto" +
        "m=\"true\" Text=\"[TotalNettoCounterparty]\" Format=\"Number\" Format.UseLocale=\"false" +
        "\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \"" +
        " Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9" +
        "pt, style=Bold\"/>\r\n      </GroupFooterBand>\r\n    </GroupHeaderBand>\r\n    <Report" +
        "SummaryBand Name=\"ReportSummary1\" Top=\"291.15\" Width=\"1047.06\" Height=\"28.35\">\r\n" +
        "      <TextObject Name=\"Text25\" Width=\"888.3\" Height=\"28.35\" Border.Lines=\"All\" " +
        "CanGrow=\"true\" GrowToBottom=\"true\" Text=\"ИТОГ ОБЩИЙ\" VertAlign=\"Center\" Font=\"Ar";
      reportString += "ial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text27\" Left=\"888.3\" Width=\"66." +
        "15\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[" +
        "TotalCount]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"" +
        "/>\r\n      <TextObject Name=\"Text58\" Left=\"954.45\" Width=\"85.05\" Height=\"28.35\" B" +
        "order.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalNetto]\" Format=" +
        "\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparat" +
        "or=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" V" +
        "ertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    </ReportSummaryBand>\r\n   " +
        " <PageFooterBand Name=\"PageFooter1\" Top=\"323.5\" Width=\"1047.06\" Height=\"28.35\">\r" +
        "\n      <TextObject Name=\"Text29\" Left=\"888.3\" Top=\"9.45\" Width=\"151.2\" Height=\"1" +
        "8.9\" Text=\"[PageNofM]\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"" +
        "/>\r\n      <TextObject Name=\"Text28\" Top=\"9.45\" Width=\"321.3\" Height=\"18.9\" Text=";
      reportString += "\"Дата формирования отчета [Date]\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n   " +
        " </PageFooterBand>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public DriverFastReportCS()
    {
      InitializeComponent();
    }
  }
}

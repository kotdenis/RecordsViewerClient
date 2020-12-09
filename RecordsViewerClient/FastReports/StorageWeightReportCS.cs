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
  public class StorageWeightReportCS : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.DataBand Data1;
    public FastReport.GroupFooterBand GroupFooter1;
    public FastReport.GroupFooterBand GroupFooter2;
    public FastReport.GroupHeaderBand GroupHeader1;
    public FastReport.GroupHeaderBand GroupHeader2;
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
    public FastReport.TextObject Text23;
    public FastReport.TextObject Text24;
    public FastReport.TextObject Text25;
    public FastReport.TextObject Text26;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text30;
    public FastReport.TextObject Text31;
    public FastReport.TextObject Text33;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text44;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text50;
    public FastReport.TextObject Text52;
    public FastReport.TextObject Text53;
    public FastReport.TextObject Text54;
    public FastReport.TextObject Text55;
    public FastReport.TextObject Text56;
    public FastReport.TextObject Text57;
    public FastReport.TextObject Text58;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\StorageFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\StorageFastReport.xml";
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
        "nfo.Created=\"05/31/2019 13:53:20\" ReportInfo.Modified=\"06/14/2019 08:17:38\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\StorageFastReport.xml\">\r\n      <TableDataSource Name=\"dirstorage\" DataTyp" +
        "e=\"System.Int32\" Enabled=\"true\" TableName=\"dirstorage\">\r\n        <Column Name=\"i" +
        "d\" DataType=\"System.Int64\"/>\r\n        <Column Name=\"DateWeightShort\" DataType=\"S" +
        "ystem.DateTime\"/>\r\n        <Column Name=\"DateTimeSecondWeight\" DataType=\"System." +
        "DateTime\"/>\r\n        <Column Name=\"TransportNumber\" DataType=\"System.String\"/>\r\n" +
        "        <Column Name=\"TypeOfTransport\" DataType=\"System.String\"/>\r\n        <Colu" +
        "mn Name=\"Invoice\" DataType=\"System.String\"/>\r\n        <Column Name=\"Cargo\" DataT" +
        "ype=\"System.String\"/>\r\n        <Column Name=\"StorageInfo\" DataType=\"System.Strin" +
        "g\"/>\r\n        <Column Name=\"Carrier\" DataType=\"System.String\"/>\r\n        <Column";
      reportString += " Name=\"TypeOfOperation\" DataType=\"System.String\"/>\r\n        <Column Name=\"Netto\"" +
        " DataType=\"System.Double\"/>\r\n      </TableDataSource>\r\n    </XmlDataConnection>\r" +
        "\n    <Parameter Name=\"StartDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Na" +
        "me=\"EndDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"Connect_String\" " +
        "DataType=\"System.String\"/>\r\n    <Total Name=\"Total\" Expression=\"[dirstorage.Nett" +
        "o]\" Evaluator=\"Data1\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalTypeOfOp" +
        "eration\" Expression=\"[dirstorage.Netto]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter1" +
        "\"/>\r\n    <Total Name=\"TotalTypeOfOperationDate\" Expression=\"[dirstorage.Netto]\" " +
        "Evaluator=\"Data1\" PrintOn=\"GroupFooter2\"/>\r\n  </Dictionary>\r\n  <ReportPage Name=" +
        "\"Page1\" PaperWidth=\"297\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"1047." +
        "06\" Height=\"66.15\">\r\n      <TextObject Name=\"Text1\" Left=\"18.9\" Top=\"9.45\" Width" +
        "=\"311.85\" Height=\"18.9\" Text=\"Взвешивания по складам\" Font=\"Arial, 12pt, style=B";
      reportString += "old\"/>\r\n      <TextObject Name=\"Text2\" Left=\"18.9\" Top=\"28.35\" Width=\"85.05\" Hei" +
        "ght=\"18.9\" Text=\"За период с\"/>\r\n      <TextObject Name=\"Text12\" Left=\"103.95\" T" +
        "op=\"28.35\" Width=\"226.8\" Height=\"18.9\" Text=\"[StartDate]\" Format=\"Date\" Format.F" +
        "ormat=\"F\"/>\r\n      <TextObject Name=\"Text35\" Left=\"378\" Top=\"28.35\" Width=\"255.1" +
        "5\" Height=\"18.9\" Text=\"[EndDate]\" Format=\"Date\" Format.Format=\"F\"/>\r\n      <Text" +
        "Object Name=\"Text44\" Left=\"340.2\" Top=\"28.35\" Width=\"37.8\" Height=\"18.9\" Text=\" " +
        "по \"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top=\"70.1" +
        "5\" Width=\"1047.06\" Height=\"47.25\">\r\n      <TextObject Name=\"Text6\" Left=\"113.4\" " +
        "Top=\"28.35\" Width=\"75.6\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Tex" +
        "t=\"Номер\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r" +
        "\n      <TextObject Name=\"Text7\" Left=\"189\" Top=\"28.35\" Width=\"75.6\" Height=\"18.9" +
        "\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тип\" HorzAlign=\"Center\" VertAlign=";
      reportString += "\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text9\" Left=\"2" +
        "64.6\" Top=\"28.35\" Width=\"113.4\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1" +
        ".5\" Text=\"Номер, дата\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, s" +
        "tyle=Bold\"/>\r\n      <TextObject Name=\"Text3\" Width=\"37.8\" Height=\"47.25\" Border." +
        "Lines=\"All\" Border.Width=\"1.5\" Text=\"№ п/п\" HorzAlign=\"Center\" VertAlign=\"Center" +
        "\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text4\" Left=\"37.8\" Wi" +
        "dth=\"75.6\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Время\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextO" +
        "bject Name=\"Text5\" Left=\"113.4\" Width=\"151.2\" Height=\"28.35\" Border.Lines=\"All\" " +
        "Border.Width=\"1.5\" Text=\"Транспорт\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"" +
        "Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text8\" Left=\"264.6\" Width=\"11" +
        "3.4\" Height=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Накладная\" HorzA";
      reportString += "lign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObj" +
        "ect Name=\"Text10\" Left=\"378\" Width=\"226.8\" Height=\"47.25\" Border.Lines=\"All\" Bor" +
        "der.Width=\"1.5\" Text=\"Склад (место размещения)&#13;&#10;Склад назначения (место " +
        "размещения)\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"" +
        "/>\r\n      <TextObject Name=\"Text11\" Left=\"604.8\" Width=\"151.2\" Height=\"47.25\" Bo" +
        "rder.Lines=\"All\" Border.Width=\"1.5\" Text=\"Груз\" HorzAlign=\"Center\" VertAlign=\"Ce" +
        "nter\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text13\" Left=\"907" +
        ".2\" Width=\"75.6\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Масс" +
        "а, т\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n   " +
        "   <TextObject Name=\"Text14\" Left=\"982.8\" Width=\"56.7\" Height=\"47.25\" Border.Lin" +
        "es=\"All\" Border.Width=\"1.5\" Text=\"Снято, т (%сорн)\" HorzAlign=\"Center\" VertAlign" +
        "=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text33\" Left=";
      reportString += "\"756\" Width=\"151.2\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"П" +
        "еревозчик\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>" +
        "\r\n    </PageHeaderBand>\r\n    <GroupHeaderBand Name=\"GroupHeader1\" Top=\"121.4\" Wi" +
        "dth=\"1047.06\" Height=\"28.35\" Condition=\"[dirstorage.TypeOfOperation]\">\r\n      <T" +
        "extObject Name=\"Text30\" Width=\"1039.5\" Height=\"28.35\" Border.Lines=\"All\" Text=\"[" +
        "[dirstorage.TypeOfOperation]]\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/" +
        ">\r\n      <GroupHeaderBand Name=\"GroupHeader2\" Top=\"153.75\" Width=\"1047.06\" Condi" +
        "tion=\"[dirstorage.DateWeightShort]\">\r\n        <DataBand Name=\"Data1\" Top=\"157.75" +
        "\" Width=\"1047.06\" Height=\"37.8\" DataSource=\"dirstorage\">\r\n          <TextObject " +
        "Name=\"Text15\" Width=\"37.8\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[AbsRow#]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n          <TextObject" +
        " Name=\"Text16\" Left=\"37.8\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[";
      reportString += "dirstorage.DateTimeSecondWeight]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar" +
        "ial, 8.25pt\"/>\r\n          <TextObject Name=\"Text17\" Left=\"113.4\" Width=\"75.6\" He" +
        "ight=\"37.8\" Border.Lines=\"All\" Text=\"[dirstorage.TransportNumber]\" HorzAlign=\"Ce" +
        "nter\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n          <TextObject Name=\"Tex" +
        "t18\" Left=\"189\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirstorage." +
        "TypeOfTransport]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n" +
        "          <TextObject Name=\"Text19\" Left=\"264.6\" Width=\"113.4\" Height=\"37.8\" Bor" +
        "der.Lines=\"All\" Text=\"[dirstorage.Invoice]\" HorzAlign=\"Center\" VertAlign=\"Center" +
        "\" Font=\"Arial, 8.25pt\"/>\r\n          <TextObject Name=\"Text20\" Left=\"378\" Width=\"" +
        "226.8\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirstorage.StorageInfo]\" HorzAlig" +
        "n=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n          <TextObject Name" +
        "=\"Text21\" Left=\"604.8\" Width=\"151.2\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dir";
      reportString += "storage.Cargo]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n  " +
        "        <TextObject Name=\"Text22\" Left=\"756\" Width=\"151.2\" Height=\"37.8\" Border." +
        "Lines=\"All\" Text=\"[dirstorage.Carrier]\" HorzAlign=\"Center\" VertAlign=\"Center\" Fo" +
        "nt=\"Arial, 8.25pt\"/>\r\n          <TextObject Name=\"Text23\" Left=\"907.2\" Width=\"75" +
        ".6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dirstorage.Netto]\" Format=\"Number\" F" +
        "ormat.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" For" +
        "mat.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"" +
        "Center\" Font=\"Arial, 8.25pt\"/>\r\n          <TextObject Name=\"Text24\" Left=\"982.8\"" +
        " Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" HorzAlign=\"Center\" VertAlign=\"Cen" +
        "ter\" Font=\"Arial, 8.25pt\"/>\r\n        </DataBand>\r\n        <GroupFooterBand Name=" +
        "\"GroupFooter2\" Top=\"199.55\" Width=\"1047.06\" Height=\"28.35\">\r\n          <TextObje" +
        "ct Name=\"Text50\" Width=\"907.2\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" ";
      reportString += "GrowToBottom=\"true\" Text=\"Всего за \" VertAlign=\"Center\" Font=\"Arial, 8.25pt, sty" +
        "le=Bold\"/>\r\n          <TextObject Name=\"Text52\" Left=\"907.2\" Width=\"75.6\" Height" +
        "=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalTypeO" +
        "fOperationDate]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"" +
        "3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=" +
        "\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n  " +
        "        <TextObject Name=\"Text53\" Left=\"982.8\" Width=\"56.7\" Height=\"28.35\" Borde" +
        "r.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" HorzAlign=\"Center\" VertAlign=\"C" +
        "enter\" Font=\"Arial, 8.25pt\"/>\r\n          <TextObject Name=\"Text39\" Left=\"56.7\" W" +
        "idth=\"179.55\" Height=\"28.35\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[dirstorag" +
        "e.DateWeightShort]\" Format=\"Date\" Format.Format=\"d\" VertAlign=\"Center\" Font=\"Ari" +
        "al, 8.25pt, style=Bold\"/>\r\n        </GroupFooterBand>\r\n      </GroupHeaderBand>\r";
      reportString += "\n      <GroupFooterBand Name=\"GroupFooter1\" Top=\"231.9\" Width=\"1047.06\" Height=\"" +
        "28.35\">\r\n        <TextObject Name=\"Text54\" Left=\"907.2\" Width=\"75.6\" Height=\"28." +
        "35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"true" +
        "\" Text=\"[TotalTypeOfOperation]\" Format=\"Number\" Format.UseLocale=\"false\" Format." +
        "DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.N" +
        "egativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style" +
        "=Bold\"/>\r\n        <TextObject Name=\"Text55\" Left=\"982.8\" Width=\"56.7\" Height=\"28" +
        ".35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"tru" +
        "e\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n        <TextOb" +
        "ject Name=\"Text31\" Width=\"907.2\" Height=\"28.35\" Border.Lines=\"All\" Fill.Color=\"W" +
        "hiteSmoke\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"Итого по [[dirstorage.TypeOf" +
        "Operation]]\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      </GroupFo";
      reportString += "oterBand>\r\n    </GroupHeaderBand>\r\n    <ReportSummaryBand Name=\"ReportSummary1\" " +
        "Top=\"264.25\" Width=\"1047.06\" Height=\"28.35\">\r\n      <TextObject Name=\"Text25\" Le" +
        "ft=\"-9.45\" Width=\"18.9\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Te" +
        "xt=\"ИТОГ ОБЩИЙ\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextO" +
        "bject Name=\"Text26\" Left=\"897.75\" Width=\"18.9\" Border.Lines=\"All\" CanGrow=\"true\"" +
        " GrowToBottom=\"true\" Text=\"[Total]\" Format=\"Number\" Format.UseLocale=\"false\" For" +
        "mat.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Form" +
        "at.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, s" +
        "tyle=Bold\"/>\r\n      <TextObject Name=\"Text27\" Left=\"973.35\" Width=\"18.9\" Border." +
        "Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" HorzAlign=\"Center\" VertAlign=\"Cen" +
        "ter\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text56\" Width=\"907.2\" Heigh" +
        "t=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"ИТОГ ОБЩИЙ";
      reportString += "\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Te" +
        "xt57\" Left=\"907.2\" Width=\"75.6\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\"" +
        " GrowToBottom=\"true\" Text=\"[Total]\" Format=\"Number\" Format.UseLocale=\"false\" For" +
        "mat.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Form" +
        "at.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, s" +
        "tyle=Bold\"/>\r\n      <TextObject Name=\"Text58\" Left=\"982.8\" Width=\"56.7\" Height=\"" +
        "28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" HorzAlign=\"Center\" " +
        "VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n    </ReportSummaryBand>\r\n    <PageFo" +
        "oterBand Name=\"PageFooter1\" Top=\"296.6\" Width=\"1047.06\" Height=\"37.8\">\r\n      <T" +
        "extObject Name=\"Text29\" Left=\"888.3\" Top=\"18.9\" Width=\"151.2\" Height=\"18.9\" Text" +
        "=\"[PageNofM]\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n     " +
        " <TextObject Name=\"Text28\" Top=\"18.9\" Width=\"340.2\" Height=\"18.9\" Text=\"Дата фор";
      reportString += "мирования отчета [Date]\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n    </PageFo" +
        "oterBand>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public StorageWeightReportCS()
    {
      InitializeComponent();
    }
  }
}

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
  public class AuditWeightReportCS : Report
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
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text34;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text54;
    public FastReport.TextObject Text62;
    public FastReport.TextObject Text63;
    public FastReport.TextObject Text70;
    public FastReport.TextObject Text71;
    public FastReport.TextObject Text72;
    public FastReport.TextObject Text73;
    public FastReport.TextObject Text74;
    public FastReport.TextObject Text75;
    public FastReport.TextObject Text76;
    public FastReport.TextObject Text78;
    public FastReport.TextObject Text79;
    public FastReport.TextObject Text80;
    public FastReport.TextObject Text81;
    public FastReport.TextObject Text83;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\AuditJournalFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\AuditJournalFastReport.xml";
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
        "nfo.Created=\"06/05/2019 11:44:47\" ReportInfo.Modified=\"06/14/2019 08:08:42\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\AuditJournalFastReport.xml\">\r\n      <TableDataSource Name=\"auditJournal\" " +
        "DataType=\"System.Int32\" Enabled=\"true\" TableName=\"auditJournal\">\r\n        <Colum" +
        "n Name=\"id\" DataType=\"System.Int64\"/>\r\n        <Column Name=\"AuditWeight\" DataTy" +
        "pe=\"System.Double\"/>\r\n        <Column Name=\"CreatedByUserId\" DataType=\"System.In" +
        "t64\"/>\r\n        <Column Name=\"CreatedDate\" DataType=\"System.DateTime\"/>\r\n       " +
        " <Column Name=\"Time\" DataType=\"System.String\"/>\r\n        <Column Name=\"PlatformN" +
        "umber\" DataType=\"System.Int64\"/>\r\n        <Column Name=\"id_dir_WeightRoom\" DataT" +
        "ype=\"System.Int64\"/>\r\n        <Column Name=\"Name\" DataType=\"System.String\"/>\r\n  " +
        "    </TableDataSource>\r\n    </XmlDataConnection>\r\n    <Parameter Name=\"StartDate";
      reportString += "\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"EndDate\" DataType=\"System.D" +
        "ateTime\"/>\r\n    <Parameter Name=\"Connect_String\" DataType=\"System.String\"/>\r\n   " +
        " <Total Name=\"TotalAuditWeight\" Expression=\"[auditJournal.AuditWeight]\" Evaluato" +
        "r=\"Data1\"/>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\">\r\n    <ReportTitleBand " +
        "Name=\"ReportTitle1\" Width=\"718.2\" Height=\"37.8\">\r\n      <TextObject Name=\"Text29" +
        "\" Left=\"9.45\" Width=\"1047.06\" Height=\"18.9\" Text=\"Журнал аудита\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 12pt, style=Bold\"/>\r\n      <TextObject Name=\"Text71\" Left=\"9.45" +
        "\" Top=\"18.9\" Width=\"92.61\" Height=\"18.9\" Text=\"За период с \" VertAlign=\"Center\"/" +
        ">\r\n      <TextObject Name=\"Text34\" Left=\"103.95\" Top=\"18.9\" Width=\"179.55\" Heigh" +
        "t=\"18.9\" Text=\"[StartDate]\"/>\r\n      <TextObject Name=\"Text35\" Left=\"283.5\" Top=" +
        "\"18.9\" Width=\"28.35\" Height=\"18.9\" Text=\"по \"/>\r\n      <TextObject Name=\"Text39\"" +
        " Left=\"311.85\" Top=\"18.9\" Width=\"198.45\" Height=\"18.9\" Text=\"[EndDate]\"/>\r\n    <";
      reportString += "/ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top=\"41.8\" Width=\"718." +
        "2\" Height=\"75.6\">\r\n      <TextObject Name=\"Text3\" Left=\"9.45\" Width=\"538.65\" Hei" +
        "ght=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Взвешивание\" HorzAlign=\"" +
        "Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Na" +
        "me=\"Text4\" Left=\"9.45\" Top=\"28.35\" Width=\"85.05\" Height=\"47.25\" Border.Lines=\"Al" +
        "l\" Border.Width=\"1.5\" Text=\"Дата\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar" +
        "ial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text72\" Left=\"94.5\" Top=\"28.35\"" +
        " Width=\"56.7\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Время\" " +
        "HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <Te" +
        "xtObject Name=\"Text73\" Left=\"151.2\" Top=\"28.35\" Width=\"94.5\" Height=\"47.25\" Bord" +
        "er.Lines=\"All\" Border.Width=\"1.5\" Text=\"Платформа\" HorzAlign=\"Center\" VertAlign=" +
        "\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text74\" Left=\"";
      reportString += "245.7\" Top=\"28.35\" Width=\"94.5\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"" +
        "1.5\" Text=\"Весовая\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, styl" +
        "e=Bold\"/>\r\n      <TextObject Name=\"Text75\" Left=\"340.2\" Top=\"28.35\" Width=\"75.6\"" +
        " Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Вес\" HorzAlign=\"Cent" +
        "er\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"" +
        "Text76\" Left=\"415.8\" Top=\"28.35\" Width=\"132.3\" Height=\"47.25\" Border.Lines=\"All\"" +
        " Border.Width=\"1.5\" Text=\"Оператор\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"" +
        "Arial, 9pt, style=Bold\"/>\r\n    </PageHeaderBand>\r\n    <DataBand Name=\"Data1\" Top" +
        "=\"121.4\" Width=\"718.2\" Height=\"37.8\" DataSource=\"auditJournal\">\r\n      <TextObje" +
        "ct Name=\"Text54\" Left=\"9.45\" Width=\"85.05\" Height=\"37.8\" Border.Lines=\"All\" Bord" +
        "er.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[auditJournal.CreatedDate]\" Format=\"" +
        "Date\" Format.Format=\"d\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25p";
      reportString += "t\"/>\r\n      <TextObject Name=\"Text78\" Left=\"151.2\" Width=\"94.5\" Height=\"37.8\" Bo" +
        "rder.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[auditJournal.P" +
        "latformNumber]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n  " +
        "    <TextObject Name=\"Text79\" Left=\"245.7\" Width=\"94.5\" Height=\"37.8\" Border.Lin" +
        "es=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[auditJournal.id_dir_We" +
        "ightRoom]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <" +
        "TextObject Name=\"Text80\" Left=\"340.2\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"A" +
        "ll\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[auditJournal.AuditWeight]\" " +
        "Format=\"Number\" Format.UseLocale=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" Fo" +
        "nt=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text81\" Left=\"415.8\" Width=\"132.3\"" +
        " Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text" +
        "=\"[auditJournal.Name]\" Format=\"Date\" Format.Format=\"d\" HorzAlign=\"Center\" VertAl";
      reportString += "ign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text83\" Left=\"94.5\"" +
        " Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGro" +
        "w=\"true\" Text=\"[auditJournal.Time]\" Format=\"Date\" Format.Format=\"d\" HorzAlign=\"C" +
        "enter\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n    </DataBand>\r\n    <ReportSu" +
        "mmaryBand Name=\"ReportSummary1\" Top=\"163.2\" Width=\"718.2\" Height=\"56.7\">\r\n      " +
        "<TextObject Name=\"Text70\" Left=\"9.45\" Width=\"330.75\" Height=\"28.35\" Border.Lines" +
        "=\"All\" Border.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"ИТОГО:\" HorzA" +
        "lign=\"Right\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObje" +
        "ct Name=\"Text63\" Left=\"340.2\" Width=\"75.6\" Height=\"28.35\" Border.Lines=\"All\" Bor" +
        "der.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalAuditWeight]\" For" +
        "mat=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSep" +
        "arator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Cente";
      reportString += "r\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n    </ReportSummaryBan" +
        "d>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"223.9\" Width=\"718.2\" Height=\"28." +
        "35\">\r\n      <TextObject Name=\"Text62\" Left=\"9.45\" Width=\"453.6\" Height=\"18.9\" Te" +
        "xt=\"Дата формирования отчета: [Date]&#13;&#10;\" VertAlign=\"Center\" Font=\"Arial, " +
        "9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text1\" Left=\"585.9\" Width=\"122.85\" H" +
        "eight=\"18.9\" Text=\"[PageNofM]\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"Arial," +
        " 9pt, style=Bold\"/>\r\n    </PageFooterBand>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public AuditWeightReportCS()
    {
      InitializeComponent();
    }
  }
}

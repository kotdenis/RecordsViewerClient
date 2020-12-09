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
  public class WeightFullReportCS : Report
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
    public FastReport.TextObject Text100;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text30;
    public FastReport.TextObject Text31;
    public FastReport.TextObject Text32;
    public FastReport.TextObject Text33;
    public FastReport.TextObject Text34;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text36;
    public FastReport.TextObject Text37;
    public FastReport.TextObject Text38;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text40;
    public FastReport.TextObject Text42;
    public FastReport.TextObject Text43;
    public FastReport.TextObject Text44;
    public FastReport.TextObject Text48;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text50;
    public FastReport.TextObject Text51;
    public FastReport.TextObject Text52;
    public FastReport.TextObject Text53;
    public FastReport.TextObject Text54;
    public FastReport.TextObject Text55;
    public FastReport.TextObject Text56;
    public FastReport.TextObject Text57;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text60;
    public FastReport.TextObject Text61;
    public FastReport.TextObject Text62;
    public FastReport.TextObject Text63;
    public FastReport.TextObject Text64;
    public FastReport.TextObject Text66;
    public FastReport.TextObject Text67;
    public FastReport.TextObject Text68;
    public FastReport.TextObject Text69;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text70;
    public FastReport.TextObject Text71;
    public FastReport.TextObject Text76;
    public FastReport.TextObject Text77;
    public FastReport.TextObject Text78;
    public FastReport.TextObject Text79;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text80;
    public FastReport.TextObject Text81;
    public FastReport.TextObject Text82;
    public FastReport.TextObject Text83;
    public FastReport.TextObject Text84;
    public FastReport.TextObject Text85;
    public FastReport.TextObject Text86;
    public FastReport.TextObject Text87;
    public FastReport.TextObject Text88;
    public FastReport.TextObject Text89;
    public FastReport.TextObject Text90;
    public FastReport.TextObject Text91;
    public FastReport.TextObject Text92;
    public FastReport.TextObject Text93;
    public FastReport.TextObject Text94;
    public FastReport.TextObject Text95;
    public FastReport.TextObject Text96;
    public FastReport.TextObject Text97;
    public FastReport.TextObject Text98;
    public FastReport.TextObject Text99;
    public FastReport.TextObject TextOperationTypeHeader;
    public FastReport.TextObject TextOperationTypeValue;
    public FastReport.TextObject TextTSNumHeader;
    public FastReport.TextObject TextTSNumValue;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "FormatNumber([weightJournal.SecondWeight], 3)")
        return FormatNumber(((Double)Report.GetColumnValue("weightJournal.SecondWeight")), 3);
      if (expression == "FormatDateTime([weightJournal.DateInvoice],\"Short Date\")")
        return FormatDateTime(((DateTime)Report.GetColumnValue("weightJournal.DateInvoice")),"Short Date");
      if (expression == "IIf([weightJournal.StorageRec] != \"\" && [weightJournal.fund] != \"\",  \" / \", \"\")")
        return IIf(((String)Report.GetColumnValue("weightJournal.StorageRec")) != "" && ((String)Report.GetColumnValue("weightJournal.fund")) != "",  " / ", "");
      if (expression == "Maximum([weightJournal.FirstWeight], [weightJournal.SecondWeight])")
        return Maximum(((Double)Report.GetColumnValue("weightJournal.FirstWeight")), ((Double)Report.GetColumnValue("weightJournal.SecondWeight")));
      if (expression == "Minimum([weightJournal.FirstWeight], [weightJournal.SecondWeight])")
        return Minimum(((Double)Report.GetColumnValue("weightJournal.FirstWeight")), ((Double)Report.GetColumnValue("weightJournal.SecondWeight")));
      if (expression == "FormatNumber([weightJournal.FirstWeight],3)")
        return FormatNumber(((Double)Report.GetColumnValue("weightJournal.FirstWeight")),3);
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\WeightJournalFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\WeightJournalFastReport.xml";
      if (expression == "Maximum([weightJournal.FirstWeight],[weightJournal.SecondWeight])")
        return Maximum(((Double)Report.GetColumnValue("weightJournal.FirstWeight")),((Double)Report.GetColumnValue("weightJournal.SecondWeight")));
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
        "nfo.Created=\"06/03/2019 13:42:28\" ReportInfo.Modified=\"06/14/2019 08:18:24\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\WeightJournalFastReport.xml\">\r\n      <TableDataSource Name=\"weightJournal" +
        "\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"weightJournal\">\r\n        <Co" +
        "lumn Name=\"id\" DataType=\"System.Int64\"/>\r\n        <Column Name=\"FirstWeight\" Dat" +
        "aType=\"System.Double\"/>\r\n        <Column Name=\"SecondWeight\" DataType=\"System.Do" +
        "uble\"/>\r\n        <Column Name=\"UserFirstWeight\" DataType=\"System.String\"/>\r\n    " +
        "    <Column Name=\"UserSecondWeight\" DataType=\"System.String\"/>\r\n        <Column " +
        "Name=\"DateFirstWeight\" DataType=\"System.DateTime\"/>\r\n        <Column Name=\"TimeF" +
        "irstWeight\" DataType=\"System.String\"/>\r\n        <Column Name=\"IcomingWeight\" Dat" +
        "aType=\"System.Double\"/>\r\n        <Column Name=\"OutcomingWeight\" DataType=\"System";
      reportString += ".Double\"/>\r\n        <Column Name=\"Netto\" DataType=\"System.Double\"/>\r\n        <Co" +
        "lumn Name=\"DateSecondWeight\" DataType=\"System.DateTime\"/>\r\n        <Column Name=" +
        "\"TimeSecondWeight\" DataType=\"System.String\"/>\r\n        <Column Name=\"TransportNu" +
        "mber\" DataType=\"System.String\"/>\r\n        <Column Name=\"TrailerNumber\" DataType=" +
        "\"System.String\"/>\r\n        <Column Name=\"TypeTrans\" DataType=\"System.String\"/>\r\n" +
        "        <Column Name=\"TypeTrailer\" DataType=\"System.String\"/>\r\n        <Column N" +
        "ame=\"Driver\" DataType=\"System.String\"/>\r\n        <Column Name=\"InvoiceNumber\" Da" +
        "taType=\"System.String\"/>\r\n        <Column Name=\"DateInvoice\" DataType=\"System.Da" +
        "teTime\"/>\r\n        <Column Name=\"Time\" DataType=\"System.String\"/>\r\n        <Colu" +
        "mn Name=\"fund\" DataType=\"System.String\"/>\r\n        <Column Name=\"Doc_tara\" DataT" +
        "ype=\"System.String\"/>\r\n        <Column Name=\"Doc_netto\" DataType=\"System.String\"" +
        "/>\r\n        <Column Name=\"Doc_brutto\" DataType=\"System.String\"/>\r\n        <Colum";
      reportString += "n Name=\"TypeOfOperation\" DataType=\"System.String\"/>\r\n        <Column Name=\"Count" +
        "erparty\" DataType=\"System.String\"/>\r\n        <Column Name=\"Carrier\" DataType=\"Sy" +
        "stem.String\"/>\r\n        <Column Name=\"Cargo\" DataType=\"System.String\"/>\r\n       " +
        " <Column Name=\"StoragePlacement\" DataType=\"System.String\"/>\r\n        <Column Nam" +
        "e=\"StorageRec\" DataType=\"System.String\"/>\r\n      </TableDataSource>\r\n    </XmlDa" +
        "taConnection>\r\n    <Parameter Name=\"StartDate\" DataType=\"System.DateTime\"/>\r\n   " +
        " <Parameter Name=\"EndDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"Op" +
        "erationTypeName\" DataType=\"System.String\"/>\r\n    <Parameter Name=\"TSNumber\" Data" +
        "Type=\"System.String\"/>\r\n    <Parameter Name=\"HandleWeight\" DataType=\"System.Bool" +
        "ean\"/>\r\n    <Parameter Name=\"Connect_String\" DataType=\"System.String\"/>\r\n    <To" +
        "tal Name=\"TotalNetto\" Expression=\"[weightJournal.Netto]\" Evaluator=\"Data1\" Print" +
        "On=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalBrutto\" Expression=\"Maximum([weight";
      reportString += "Journal.FirstWeight],[weightJournal.SecondWeight])\" Evaluator=\"Data1\" PrintOn=\"R" +
        "eportSummary1\"/>\r\n    <Total Name=\"TotalTara\" Expression=\"Minimum([weightJournal" +
        ".FirstWeight], [weightJournal.SecondWeight])\" Evaluator=\"Data1\" PrintOn=\"ReportS" +
        "ummary1\"/>\r\n    <Total Name=\"TotalOutcoming\" Expression=\"[weightJournal.Outcomin" +
        "gWeight]\" Evaluator=\"Data1\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalIc" +
        "oming\" Expression=\"[weightJournal.IcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"Rep" +
        "ortSummary1\"/>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\" PaperWidth=\"317\">\r\n " +
        "   <ReportTitleBand Name=\"ReportTitle1\" Width=\"1122.66\" Height=\"75.6\">\r\n      <T" +
        "extObject Name=\"Text71\" Left=\"9.45\" Top=\"28.35\" Width=\"92.61\" Height=\"18.9\" Text" +
        "=\"За период с \" VertAlign=\"Center\"/>\r\n      <TextObject Name=\"Text34\" Left=\"103." +
        "95\" Top=\"28.35\" Width=\"217.35\" Height=\"18.9\" Text=\"[StartDate]\"/>\r\n      <TextOb" +
        "ject Name=\"Text35\" Left=\"321.3\" Top=\"28.35\" Width=\"28.35\" Height=\"18.9\" Text=\"по";
      reportString += " \"/>\r\n      <TextObject Name=\"Text39\" Left=\"349.65\" Top=\"28.35\" Width=\"236.25\" H" +
        "eight=\"18.9\" Text=\"[EndDate]\"/>\r\n      <TextObject Name=\"TextOperationTypeHeader" +
        "\" Left=\"9.45\" Top=\"47.25\" Width=\"113.4\" Height=\"18.9\" Text=\"Тип операции:\" VertA" +
        "lign=\"Center\" Font=\"Arial, 10pt, style=Bold\"/>\r\n      <TextObject Name=\"TextOper" +
        "ationTypeValue\" Left=\"122.85\" Top=\"47.25\" Width=\"226.8\" Height=\"18.9\" Border.Lin" +
        "es=\"Bottom\" Text=\"[OperationTypeName]\" VertAlign=\"Center\"/>\r\n      <TextObject N" +
        "ame=\"TextTSNumHeader\" Left=\"349.65\" Top=\"47.25\" Width=\"94.5\" Height=\"18.9\" Text=" +
        "\"Номер ТС:\" VertAlign=\"Center\" Font=\"Arial, 10pt, style=Bold\"/>\r\n      <TextObje" +
        "ct Name=\"TextTSNumValue\" Left=\"444.15\" Top=\"47.25\" Width=\"189\" Height=\"18.9\" Bor" +
        "der.Lines=\"Bottom\" Text=\"*[TSNumber]*\" VertAlign=\"Center\"/>\r\n      <TextObject N" +
        "ame=\"Text29\" Left=\"9.45\" Width=\"1037.61\" Height=\"18.9\" Text=\"Журнал  взвешиваний" +
        "\" VertAlign=\"Center\" Font=\"Arial, 12pt, style=Bold\"/>\r\n    </ReportTitleBand>\r\n ";
      reportString += "   <PageHeaderBand Name=\"PageHeader1\" Top=\"79.6\" Width=\"1122.66\" Height=\"75.6\">\r" +
        "\n      <TextObject Name=\"Text2\" Width=\"37.8\" Height=\"75.6\" Border.Lines=\"All\" Bo" +
        "rder.Width=\"1.5\" Text=\"№ п/п\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial," +
        " 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text3\" Left=\"37.8\" Width=\"236.25\" H" +
        "eight=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Взвешивание\" HorzAlign" +
        "=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject " +
        "Name=\"Text8\" Left=\"274.05\" Width=\"132.3\" Height=\"28.35\" Border.Lines=\"All\" Borde" +
        "r.Width=\"1.5\" Text=\"Транспорт\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial" +
        ", 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text84\" Left=\"406.35\" Width=\"56.7\"" +
        " Height=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Наклад-&#13;&#10;ная" +
        "\" Padding=\"0, 0, 0, 0\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, s" +
        "tyle=Bold\"/>\r\n      <TextObject Name=\"Text85\" Left=\"463.05\" Width=\"94.5\" Height=";
      reportString += "\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Контрагент\" HorzAlign=\"Cente" +
        "r\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"T" +
        "ext86\" Left=\"557.55\" Width=\"85.05\" Height=\"28.35\" Border.Lines=\"All\" Border.Widt" +
        "h=\"1.5\" Text=\"Перевозчик\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt" +
        ", style=Bold\"/>\r\n      <TextObject Name=\"Text87\" Left=\"708.75\" Width=\"170.1\" Hei" +
        "ght=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Вес фактический\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObjec" +
        "t Name=\"Text88\" Left=\"642.6\" Width=\"66.15\" Height=\"75.6\" Border.Lines=\"All\" Bord" +
        "er.Width=\"1.5\" Text=\"Тип опера-&#13;&#10;ции\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text93\" Left=\"878.8" +
        "5\" Width=\"113.4\" Height=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Вес " +
        "зачетный\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r";
      reportString += "\n      <TextObject Name=\"Text96\" Left=\"992.25\" Width=\"56.7\" Height=\"75.6\" Border" +
        ".Lines=\"All\" Border.Width=\"1.5\" Text=\"Снято, т (%сорн)\" HorzAlign=\"Center\" VertA" +
        "lign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text4\" Le" +
        "ft=\"37.8\" Top=\"28.35\" Width=\"56.7\" Height=\"47.25\" Border.Lines=\"All\" Border.Widt" +
        "h=\"1.5\" Text=\"Дата\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, styl" +
        "e=Bold\"/>\r\n      <TextObject Name=\"Text5\" Left=\"94.5\" Top=\"28.35\" Width=\"56.7\" H" +
        "eight=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Время\" HorzAlign=\"Cent" +
        "er\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"" +
        "Text6\" Left=\"151.2\" Top=\"28.35\" Width=\"56.7\" Height=\"47.25\" Border.Lines=\"All\" B" +
        "order.Width=\"1.5\" Text=\"Вес, т\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Aria" +
        "l, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text7\" Left=\"207.9\" Top=\"28.35\" W" +
        "idth=\"66.15\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Весов-&#";
      reportString += "13;&#10;щик\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"" +
        "/>\r\n      <TextObject Name=\"Text76\" Left=\"274.05\" Top=\"28.35\" Width=\"66.15\" Heig" +
        "ht=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тип\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text77" +
        "\" Left=\"340.2\" Top=\"28.35\" Width=\"66.15\" Height=\"18.9\" Border.Lines=\"All\" Border" +
        ".Width=\"1.5\" Text=\"Номер\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt" +
        ", style=Bold\"/>\r\n      <TextObject Name=\"Text80\" Left=\"406.35\" Top=\"28.35\" Width" +
        "=\"56.7\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Номер\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObjec" +
        "t Name=\"Text82\" Left=\"463.05\" Top=\"28.35\" Width=\"94.5\" Height=\"47.25\" Border.Lin" +
        "es=\"All\" Border.Width=\"1.5\" Text=\"Склад &#13;&#10;месторазме-&#13;&#10;щения\" Ho" +
        "rzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <Text";
      reportString += "Object Name=\"Text83\" Left=\"557.55\" Top=\"28.35\" Width=\"85.05\" Height=\"47.25\" Bord" +
        "er.Lines=\"All\" Border.Width=\"1.5\" Text=\"Склад получатель / фонд\" HorzAlign=\"Cent" +
        "er\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"" +
        "Text89\" Left=\"708.75\" Top=\"28.35\" Width=\"56.7\" Height=\"18.9\" Border.Lines=\"All\" " +
        "Border.Width=\"1.5\" Text=\"Брутто\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ari" +
        "al, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text90\" Left=\"765.45\" Top=\"28.35" +
        "\" Width=\"56.7\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тара\" H" +
        "orzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <Tex" +
        "tObject Name=\"Text91\" Left=\"822.15\" Top=\"28.35\" Width=\"56.7\" Height=\"18.9\" Borde" +
        "r.Lines=\"All\" Border.Width=\"1.5\" Text=\"Нетто\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text94\" Left=\"878.8" +
        "5\" Top=\"28.35\" Width=\"56.7\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\"";
      reportString += " Text=\"Отгру-&#13;&#10;жено\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, " +
        "9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text95\" Left=\"935.55\" Top=\"28.35\" Wi" +
        "dth=\"56.7\" Height=\"47.25\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Приня-&#13" +
        ";&#10;то\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r" +
        "\n      <TextObject Name=\"Text78\" Left=\"274.05\" Top=\"47.25\" Width=\"66.15\" Height=" +
        "\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Води-&#13;&#10;тель\" Padding" +
        "=\"0, 0, 0, 0\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold" +
        "\"/>\r\n      <TextObject Name=\"Text79\" Left=\"340.2\" Top=\"47.25\" Width=\"66.15\" Heig" +
        "ht=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Прицеп\" HorzAlign=\"Center" +
        "\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Te" +
        "xt81\" Left=\"406.35\" Top=\"47.25\" Width=\"56.7\" Height=\"28.35\" Border.Lines=\"All\" B" +
        "order.Width=\"1.5\" Text=\"Дата\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial,";
      reportString += " 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text92\" Left=\"708.75\" Top=\"47.25\" W" +
        "idth=\"170.1\" Height=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Груз (ти" +
        "п груза)\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r" +
        "\n    </PageHeaderBand>\r\n    <DataBand Name=\"Data1\" Top=\"159.2\" Width=\"1122.66\" H" +
        "eight=\"75.6\" DataSource=\"weightJournal\">\r\n      <TextObject Name=\"Text40\" Left=\"" +
        "463.05\" Top=\"37.8\" Width=\"94.5\" Height=\"37.8\" Border.Lines=\"All\" Border.BottomLi" +
        "ne.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.StoragePl" +
        "acement]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <T" +
        "extObject Name=\"Text30\" Left=\"37.8\" Top=\"37.8\" Width=\"56.7\" Height=\"37.8\" Border" +
        ".Lines=\"All\" Border.BottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Te" +
        "xt=\"[weightJournal.DateSecondWeight]\" Format=\"Date\" Format.Format=\"d\" HorzAlign=" +
        "\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text";
      reportString += "31\" Left=\"94.5\" Top=\"37.8\" Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border." +
        "BottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.T" +
        "imeSecondWeight]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n" +
        "      <TextObject Name=\"Text32\" Left=\"151.2\" Top=\"37.8\" Width=\"56.7\" Height=\"37." +
        "8\" Border.Lines=\"All\" Border.BottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=" +
        "\"true\" Text=\"[FormatNumber([weightJournal.SecondWeight], 3)]\" HorzAlign=\"Center\"" +
        " VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text33\" Left" +
        "=\"207.9\" Top=\"37.8\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Border.Bottom" +
        "Line.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.UserSec" +
        "ondWeight]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      " +
        "<TextObject Name=\"Text37\" Left=\"274.05\" Top=\"37.8\" Width=\"66.15\" Height=\"37.8\" B" +
        "order.Lines=\"All\" Border.BottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"tru";
      reportString += "e\" Text=\"[weightJournal.Driver]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ari" +
        "al, 8.25pt\"/>\r\n      <TextObject Name=\"Text38\" Left=\"340.2\" Top=\"37.8\" Width=\"66" +
        ".15\" Height=\"37.8\" Border.Lines=\"All\" Border.BottomLine.Width=\"1.5\" CanGrow=\"tru" +
        "e\" GrowToBottom=\"true\" Text=\"[weightJournal.TrailerNumber]\" HorzAlign=\"Center\" V" +
        "ertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text43\" Left=\"" +
        "406.35\" Top=\"37.8\" Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.BottomLi" +
        "ne.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[FormatDateTime([weightJ" +
        "ournal.DateInvoice],&quot;Short Date&quot;)]\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text53\" Left=\"708.75\" Top=\"3" +
        "7.8\" Width=\"170.1\" Height=\"37.8\" Border.Lines=\"All\" Border.BottomLine.Width=\"1.5" +
        "\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.Cargo]\" HorzAlign=\"Cen" +
        "ter\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text60\" ";
      reportString += "Left=\"557.55\" Top=\"37.8\" Width=\"85.05\" Height=\"37.8\" Border.Lines=\"All\" Border.B" +
        "ottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.St" +
        "orageRec][IIf([weightJournal.StorageRec] != &quot;&quot; &amp;&amp; [weightJourn" +
        "al.fund] != &quot;&quot;,  &quot; / &quot;, &quot;&quot;)] [weightJournal.fund]\"" +
        " HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject" +
        " Name=\"Text28\" Width=\"37.8\" Height=\"75.6\" Border.Lines=\"All\" Border.LeftLine.Wid" +
        "th=\"1.5\" Border.TopLine.Width=\"1.5\" Border.BottomLine.Width=\"1.5\" CanGrow=\"true\"" +
        " GrowToBottom=\"true\" Text=\"[Row#]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"A" +
        "rial, 8.25pt\"/>\r\n      <TextObject Name=\"Text44\" Left=\"642.6\" Width=\"66.15\" Heig" +
        "ht=\"75.6\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" Border.BottomLine.Width=" +
        "\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.TypeOfOperation]\" " +
        "HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject ";
      reportString += "Name=\"Text36\" Left=\"340.2\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Border" +
        ".TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[weightJournal.TransportNumber]\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=" +
        "\"Text42\" Left=\"406.35\" Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.TopL" +
        "ine.Width=\"1.5\" CanGrow=\"true\" Text=\"[weightJournal.InvoiceNumber]\" HorzAlign=\"C" +
        "enter\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text48" +
        "\" Left=\"878.85\" Width=\"56.7\" Height=\"75.6\" Border.Lines=\"All\" Border.TopLine.Wid" +
        "th=\"1.5\" Border.BottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"" +
        "[weightJournal.OutcomingWeight]\" Format=\"Number\" Format.UseLocale=\"false\" Format" +
        ".DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format." +
        "NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>" +
        "\r\n      <TextObject Name=\"Text50\" Left=\"708.75\" Width=\"56.7\" Height=\"37.8\" Borde";
      reportString += "r.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[Maximum([weightJo" +
        "urnal.FirstWeight], [weightJournal.SecondWeight])]\" Format=\"Number\" Format.UseLo" +
        "cale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSe" +
        "parator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Fon" +
        "t=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text51\" Left=\"765.45\" Width=\"56.7\" " +
        "Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=" +
        "\"[Minimum([weightJournal.FirstWeight], [weightJournal.SecondWeight])]\" Format=\"N" +
        "umber\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator" +
        "=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" Ver" +
        "tAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text52\" Left=\"82" +
        "2.15\" Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" C" +
        "anGrow=\"true\" Text=\"[weightJournal.Netto]\" Format=\"Number\" Format.UseLocale=\"fal";
      reportString += "se\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\"" +
        " \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial," +
        " 8.25pt\"/>\r\n      <TextObject Name=\"Text54\" Left=\"37.8\" Width=\"56.7\" Height=\"37." +
        "8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[weightJou" +
        "rnal.DateFirstWeight]\" Format=\"Date\" Format.Format=\"d\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text55\" Left=\"94.5\"" +
        " Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGro" +
        "w=\"true\" Text=\"[weightJournal.TimeFirstWeight]\" HorzAlign=\"Center\" VertAlign=\"Ce" +
        "nter\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text56\" Left=\"151.2\" Width" +
        "=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"tru" +
        "e\" Text=\"[FormatNumber([weightJournal.FirstWeight],3)]\" HorzAlign=\"Center\" VertA" +
        "lign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text57\" Left=\"207.";
      reportString += "9\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" Can" +
        "Grow=\"true\" Text=\"[weightJournal.UserFirstWeight]\" HorzAlign=\"Center\" VertAlign=" +
        "\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text61\" Left=\"274.05\" W" +
        "idth=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow" +
        "=\"true\" Text=\"[weightJournal.TypeTrans]\" HorzAlign=\"Center\" VertAlign=\"Center\" F" +
        "ont=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text97\" Left=\"463.05\" Width=\"94.5" +
        "\" Height=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Tex" +
        "t=\"[weightJournal.Counterparty]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ari" +
        "al, 8.25pt\"/>\r\n      <TextObject Name=\"Text98\" Left=\"557.55\" Width=\"85.05\" Heigh" +
        "t=\"37.8\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" CanGrow=\"true\" Text=\"[wei" +
        "ghtJournal.Carrier]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/" +
        ">\r\n      <TextObject Name=\"Text99\" Left=\"935.55\" Width=\"56.7\" Height=\"75.6\" Bord";
      reportString += "er.Lines=\"All\" Border.TopLine.Width=\"1.5\" Border.BottomLine.Width=\"1.5\" CanGrow=" +
        "\"true\" GrowToBottom=\"true\" Text=\"[weightJournal.IcomingWeight]\" Format=\"Number\" " +
        "Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Fo" +
        "rmat.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=" +
        "\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text100\" Left=\"992.25\" " +
        "Width=\"56.7\" Height=\"75.6\" Border.Lines=\"All\" Border.TopLine.Width=\"1.5\" Border." +
        "RightLine.Width=\"1.5\" Border.BottomLine.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=" +
        "\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n    </DataB" +
        "and>\r\n    <ReportSummaryBand Name=\"ReportSummary1\" Top=\"238.8\" Width=\"1122.66\" H" +
        "eight=\"28.35\">\r\n      <TextObject Name=\"Text64\" Left=\"765.45\" Width=\"56.7\" Heigh" +
        "t=\"28.35\" Border.Lines=\"All\" Border.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"tru" +
        "e\" Text=\"[TotalTara]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDig";
      reportString += "its=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePat" +
        "tern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/" +
        ">\r\n      <TextObject Name=\"Text66\" Left=\"822.15\" Width=\"56.7\" Height=\"28.35\" Bor" +
        "der.Lines=\"All\" Border.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[Tot" +
        "alNetto]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Form" +
        "at.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n      <Te" +
        "xtObject Name=\"Text67\" Left=\"878.85\" Width=\"56.7\" Height=\"28.35\" Border.Lines=\"A" +
        "ll\" Border.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalOutcoming]" +
        "\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.Decim" +
        "alSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"" +
        "Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n      <TextObject";
      reportString += " Name=\"Text68\" Left=\"935.55\" Width=\"56.7\" Height=\"28.35\" Border.Lines=\"All\" Bord" +
        "er.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalIcoming]\" Format=\"" +
        "Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparato" +
        "r=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n      <TextObject Name=\"Tex" +
        "t69\" Left=\"992.25\" Width=\"54.81\" Height=\"28.35\" Border.Lines=\"All\" Border.Width=" +
        "\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" F" +
        "ont=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text70\" Width=\"708.75\" Height=\"28" +
        ".35\" Border.Lines=\"All\" Border.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Te" +
        "xt=\"ИТОГО:\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>" +
        "\r\n      <TextObject Name=\"Text63\" Left=\"708.75\" Width=\"56.7\" Height=\"28.35\" Bord" +
        "er.Lines=\"All\" Border.Width=\"1.5\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[Tota";
      reportString += "lBrutto]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Form" +
        "at.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n    </Rep" +
        "ortSummaryBand>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"271.15\" Width=\"1122" +
        ".66\" Height=\"28.35\">\r\n      <TextObject Name=\"Text1\" Left=\"916.65\" Top=\"9.45\" Wi" +
        "dth=\"122.85\" Height=\"18.9\" Text=\"[PageNofM]\" HorzAlign=\"Right\" VertAlign=\"Center" +
        "\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text62\" Top=\"9.45\" Wi" +
        "dth=\"453.6\" Height=\"18.9\" Text=\"Дата формирования отчета: [Date]&#13;&#10;\" Vert" +
        "Align=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    </PageFooterBand>\r\n  </Repor" +
        "tPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public WeightFullReportCS()
    {
      InitializeComponent();
    }
  }
}

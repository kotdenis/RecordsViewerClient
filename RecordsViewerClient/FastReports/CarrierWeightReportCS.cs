﻿using System;
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
  public class CarrierWeightReportCS : Report
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
    public FastReport.TextObject Text26;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text30;
    public FastReport.TextObject Text31;
    public FastReport.TextObject Text32;
    public FastReport.TextObject Text33;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text36;
    public FastReport.TextObject Text37;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text43;
    public FastReport.TextObject Text44;
    public FastReport.TextObject Text45;
    public FastReport.TextObject Text46;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text50;
    public FastReport.TextObject Text51;
    public FastReport.TextObject Text52;
    public FastReport.TextObject Text53;
    public FastReport.TextObject Text54;
    public FastReport.TextObject Text55;
    public FastReport.TextObject Text56;
    public FastReport.TextObject Text57;
    public FastReport.TextObject Text58;
    public FastReport.TextObject Text59;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text60;
    public FastReport.TextObject Text61;
    public FastReport.TextObject Text62;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "IIf([dircarrier.Counterparty]==\"\", \"Не указан\", [dircarrier.Counterparty])")
        return IIf(((String)Report.GetColumnValue("dircarrier.Counterparty"))=="", "Не указан", ((String)Report.GetColumnValue("dircarrier.Counterparty")));
      if (expression == "IIf([dircarrier.Counterparty]==\"\", \"Итого\", \"Итого по \" + [dircarrier.Counterparty])")
        return IIf(((String)Report.GetColumnValue("dircarrier.Counterparty"))=="", "Итого", "Итого по " + ((String)Report.GetColumnValue("dircarrier.Counterparty")));
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\CarrierFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\CarrierFastReport.xml";
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
        "nfo.Created=\"05/30/2019 15:31:06\" ReportInfo.Modified=\"06/14/2019 08:13:39\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\CarrierFastReport.xml\">\r\n      <TableDataSource Name=\"dircarrier\" DataTyp" +
        "e=\"System.Int32\" Enabled=\"true\" TableName=\"dircarrier\">\r\n        <Column Name=\"i" +
        "d\" DataType=\"System.Int64\"/>\r\n        <Column Name=\"DateWeightShort\" DataType=\"S" +
        "ystem.DateTime\"/>\r\n        <Column Name=\"DateTimeSecondWeight\" DataType=\"System." +
        "DateTime\"/>\r\n        <Column Name=\"TransportNumber\" DataType=\"System.String\"/>\r\n" +
        "        <Column Name=\"TypeOfTransport\" DataType=\"System.String\"/>\r\n        <Colu" +
        "mn Name=\"Invoice\" DataType=\"System.String\"/>\r\n        <Column Name=\"Cargo\" DataT" +
        "ype=\"System.String\"/>\r\n        <Column Name=\"Carrier\" DataType=\"System.String\"/>" +
        "\r\n        <Column Name=\"Counterparty\" DataType=\"System.String\"/>\r\n        <Colum";
      reportString += "n Name=\"TypeOfOperation\" DataType=\"System.String\"/>\r\n        <Column Name=\"Icomi" +
        "ngWeight\" DataType=\"System.Double\"/>\r\n        <Column Name=\"OutcomingWeight\" Dat" +
        "aType=\"System.Double\"/>\r\n      </TableDataSource>\r\n    </XmlDataConnection>\r\n   " +
        " <Parameter Name=\"StartDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"" +
        "EndDate\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"Connect_String\" Data" +
        "Type=\"System.String\"/>\r\n    <Total Name=\"TotalOutcoming\" Expression=\"[dircarrier" +
        ".OutcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name" +
        "=\"TotalCounterpartyCargoOutcoming\" Expression=\"[dircarrier.OutcomingWeight]\" Eva" +
        "luator=\"Data1\" PrintOn=\"GroupFooter2\"/>\r\n    <Total Name=\"TotaCounterpartyOutcom" +
        "ing\" Expression=\"[dircarrier.OutcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"GroupF" +
        "ooter1\"/>\r\n    <Total Name=\"TotalCounterpartyCargoDateOutcoming\" Expression=\"[di" +
        "rcarrier.OutcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter3\"/>\r\n    <Tota";
      reportString += "l Name=\"TotalIcoming\" Expression=\"[dircarrier.IcomingWeight]\" Evaluator=\"Data1\" " +
        "PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalCounterpartyCargoIcoming\" Expr" +
        "ession=\"[dircarrier.IcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter2\"/>\r\n" +
        "    <Total Name=\"TotalCounterpartyIcoming\" Expression=\"[dircarrier.IcomingWeight" +
        "]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter1\"/>\r\n    <Total Name=\"TotalCounterpart" +
        "yCargoDateIcoming\" Expression=\"[dircarrier.IcomingWeight]\" Evaluator=\"Data1\" Pri" +
        "ntOn=\"GroupFooter3\"/>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\" PaperWidth=\"2" +
        "97\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"1047.06\" Height=\"47.25\">\r\n" +
        "      <TextObject Name=\"Text1\" Width=\"255.15\" Height=\"18.9\" Text=\"Отчет по перев" +
        "озчикам\" Font=\"Arial, 12pt, style=Bold\"/>\r\n      <TextObject Name=\"Text2\" Top=\"1" +
        "8.9\" Width=\"75.6\" Height=\"18.9\" Text=\"За период с\"/>\r\n      <TextObject Name=\"Te" +
        "xt12\" Left=\"85.05\" Top=\"18.9\" Width=\"226.8\" Height=\"18.9\" Text=\"[StartDate]\" For";
      reportString += "mat=\"Date\" Format.Format=\"F\"/>\r\n      <TextObject Name=\"Text35\" Left=\"340.2\" Top" +
        "=\"18.9\" Width=\"292.95\" Height=\"18.9\" Text=\"[EndDate]\" Format=\"Date\" Format.Forma" +
        "t=\"F\"/>\r\n      <TextObject Name=\"Text44\" Left=\"311.85\" Top=\"18.9\" Width=\"28.35\" " +
        "Height=\"18.9\" Text=\" по \"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"P" +
        "ageHeader1\" Top=\"51.25\" Width=\"1047.06\" Height=\"37.8\">\r\n      <TextObject Name=\"" +
        "Text3\" Width=\"37.8\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"№ " +
        "п/п\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    " +
        "  <TextObject Name=\"Text4\" Left=\"37.8\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"" +
        "All\" Border.Width=\"1.5\" Text=\"Время\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=" +
        "\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text5\" Left=\"113.4\" Width=\"1" +
        "51.2\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Транспорт\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObj";
      reportString += "ect Name=\"Text8\" Left=\"264.6\" Width=\"113.4\" Height=\"18.9\" Border.Lines=\"All\" Bor" +
        "der.Width=\"1.5\" Text=\"Накладная\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ari" +
        "al, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text10\" Left=\"378\" Width=\"113.4\"" +
        " Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Груз\" HorzAlign=\"Cent" +
        "er\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"" +
        "Text11\" Left=\"614.25\" Width=\"122.85\" Height=\"37.8\" Border.Lines=\"All\" Border.Wid" +
        "th=\"1.5\" Text=\"Контрагент\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9p" +
        "t, style=Bold\"/>\r\n      <TextObject Name=\"Text13\" Left=\"916.65\" Width=\"66.15\" He" +
        "ight=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Принято, т\" HorzAlign=\"C" +
        "enter\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Nam" +
        "e=\"Text14\" Left=\"982.8\" Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" Border.Wid" +
        "th=\"1.5\" Text=\"Снято,т (%сорн)\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Aria";
      reportString += "l, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text30\" Left=\"491.4\" Width=\"122.8" +
        "5\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Перевозчик\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObjec" +
        "t Name=\"Text32\" Left=\"850.5\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Bord" +
        "er.Width=\"1.5\" Text=\"Отргуже-&#13;&#10;но, т\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text33\" Left=\"737.1" +
        "\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тип оп" +
        "ерации\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n " +
        "     <TextObject Name=\"Text6\" Left=\"113.4\" Top=\"18.9\" Width=\"75.6\" Height=\"18.9\"" +
        " Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Номер\" HorzAlign=\"Center\" VertAlign" +
        "=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text7\" Left=\"" +
        "189\" Top=\"18.9\" Width=\"75.6\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\"";
      reportString += " Text=\"Тип\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/" +
        ">\r\n      <TextObject Name=\"Text9\" Left=\"264.6\" Top=\"18.9\" Width=\"113.4\" Height=\"" +
        "18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Номер, дата\" HorzAlign=\"Center" +
        "\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n    </PageHeaderBand>\r\n   " +
        " <GroupHeaderBand Name=\"GroupHeader1\" Top=\"93.05\" Width=\"1047.06\" Height=\"28.35\"" +
        " Condition=\"[dircarrier.Counterparty]\">\r\n      <TextObject Name=\"Text43\" Width=\"" +
        "1039.5\" Height=\"28.35\" Border.Lines=\"All\" Text=\"Контрагент: [IIf([dircarrier.Cou" +
        "nterparty]==&quot;&quot;, &quot;Не указан&quot;, [dircarrier.Counterparty])]\" Ve" +
        "rtAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <GroupHeaderBand Name=\"G" +
        "roupHeader2\" Top=\"125.4\" Width=\"1047.06\" Height=\"28.35\" Condition=\"[dircarrier.C" +
        "argo]\">\r\n        <TextObject Name=\"Text45\" Width=\"1039.5\" Height=\"28.35\" Border." +
        "Lines=\"All\" Text=\"Груз: [dircarrier.Cargo]\" VertAlign=\"Center\" Font=\"Arial, 9pt,";
      reportString += " style=Bold\"/>\r\n        <GroupHeaderBand Name=\"GroupHeader3\" Top=\"157.75\" Width=" +
        "\"1047.06\" Condition=\"[dircarrier.DateWeightShort]\">\r\n          <DataBand Name=\"D" +
        "ata1\" Top=\"161.75\" Width=\"1047.06\" Height=\"37.8\" DataSource=\"dircarrier\">\r\n     " +
        "       <TextObject Name=\"Text52\" Left=\"982.8\" Width=\"56.7\" Height=\"37.8\" Border." +
        "Lines=\"All\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Fo" +
        "rmat.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" H" +
        "orzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextOb" +
        "ject Name=\"Text55\" Left=\"850.5\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" T" +
        "ext=\"[dircarrier.OutcomingWeight]\" Format=\"Number\" Format.UseLocale=\"false\" Form" +
        "at.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Forma" +
        "t.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"" +
        "/>\r\n            <TextObject Name=\"Text60\" Left=\"916.65\" Width=\"66.15\" Height=\"37";
      reportString += ".8\" Border.Lines=\"All\" Text=\"[dircarrier.IcomingWeight]\" Format=\"Number\" Format." +
        "UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.Gr" +
        "oupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center" +
        "\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text15\" Width=\"37.8\" Hei" +
        "ght=\"37.8\" Border.Lines=\"All\" Text=\"[AbsRow#]\" HorzAlign=\"Center\" VertAlign=\"Cen" +
        "ter\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text16\" Left=\"37.8\" W" +
        "idth=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircarrier.DateTimeSecondWei" +
        "ght]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            " +
        "<TextObject Name=\"Text17\" Left=\"113.4\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"" +
        "All\" Text=\"[dircarrier.TransportNumber]\" HorzAlign=\"Center\" VertAlign=\"Center\" F" +
        "ont=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text18\" Left=\"189\" Width=\"7" +
        "5.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircarrier.TypeOfTransport]\" HorzAl";
      reportString += "ign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject " +
        "Name=\"Text19\" Left=\"264.6\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" Text=\"" +
        "[dircarrier.Invoice]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"" +
        "/>\r\n            <TextObject Name=\"Text20\" Left=\"378\" Width=\"113.4\" Height=\"37.8\"" +
        " Border.Lines=\"All\" Text=\"[dircarrier.Cargo]\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text31\" Left=\"491.4\" W" +
        "idth=\"122.85\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircarrier.Carrier]\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject" +
        " Name=\"Text21\" Left=\"614.25\" Width=\"122.85\" Height=\"37.8\" Border.Lines=\"All\" Tex" +
        "t=\"[dircarrier.Counterparty]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial," +
        " 8.25pt\"/>\r\n            <TextObject Name=\"Text22\" Left=\"737.1\" Width=\"113.4\" Hei" +
        "ght=\"37.8\" Border.Lines=\"All\" Text=\"[dircarrier.TypeOfOperation]\" HorzAlign=\"Cen";
      reportString += "ter\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n          </DataBand>\r\n         " +
        " <GroupFooterBand Name=\"GroupFooter3\" Top=\"203.55\" Width=\"1047.06\" Height=\"28.35" +
        "\">\r\n            <TextObject Name=\"Text50\" Width=\"850.5\" Height=\"28.35\" Border.Li" +
        "nes=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"Итого по\" VertAlign=\"Center\" " +
        "Font=\"Arial, 8.25pt, style=Bold\"/>\r\n            <TextObject Name=\"Text39\" Left=\"" +
        "56.7\" Width=\"179.55\" Height=\"28.35\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[di" +
        "rcarrier.DateWeightShort]\" Format=\"Date\" Format.Format=\"d\" VertAlign=\"Center\" Fo" +
        "nt=\"Arial, 8.25pt, style=Bold\"/>\r\n            <TextObject Name=\"Text53\" Left=\"98" +
        "2.8\" Width=\"56.7\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=" +
        "\"true\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format." +
        "DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAl" +
        "ign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n            ";
      reportString += "<TextObject Name=\"Text56\" Left=\"850.5\" Width=\"66.15\" Height=\"28.35\" Border.Lines" +
        "=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCounterpartyCargoDateOutco" +
        "ming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format." +
        "DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAl" +
        "ign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n            " +
        "<TextObject Name=\"Text59\" Left=\"916.65\" Width=\"66.15\" Height=\"28.35\" Border.Line" +
        "s=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCounterpartyCargoDateIcom" +
        "ing]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.D" +
        "ecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n          </G" +
        "roupFooterBand>\r\n        </GroupHeaderBand>\r\n        <GroupFooterBand Name=\"Grou" +
        "pFooter2\" Top=\"235.9\" Width=\"1047.06\" Height=\"28.35\">\r\n          <TextObject Nam";
      reportString += "e=\"Text46\" Width=\"850.5\" Height=\"28.35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmok" +
        "e\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"Итого по [dircarrier.Cargo]:\" VertAl" +
        "ign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n          <TextObject Name=\"Text54" +
        "\" Left=\"982.8\" Width=\"56.7\" Height=\"28.35\" Border.Lines=\"All\" Fill.Color=\"WhiteS" +
        "moke\" CanGrow=\"true\" GrowToBottom=\"true\" Format=\"Number\" Format.UseLocale=\"false" +
        "\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \"" +
        " Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8" +
        ".25pt\"/>\r\n          <TextObject Name=\"Text57\" Left=\"850.5\" Width=\"66.15\" Height=" +
        "\"28.35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"" +
        "true\" Text=\"[TotalCounterpartyCargoOutcoming]\" Format=\"Number\" Format.UseLocale=" +
        "\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparat" +
        "or=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar";
      reportString += "ial, 9pt, style=Bold\"/>\r\n          <TextObject Name=\"Text61\" Left=\"916.65\" Width" +
        "=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true" +
        "\" GrowToBottom=\"true\" Text=\"[TotalCounterpartyCargoIcoming]\" Format=\"Number\" For" +
        "mat.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Forma" +
        "t.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Ce" +
        "nter\" Font=\"Arial, 9pt, style=Bold\"/>\r\n        </GroupFooterBand>\r\n      </Group" +
        "HeaderBand>\r\n      <GroupFooterBand Name=\"GroupFooter1\" Top=\"268.25\" Width=\"1047" +
        ".06\" Height=\"28.35\">\r\n        <TextObject Name=\"Text37\" Width=\"850.5\" Height=\"28" +
        ".35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"true" +
        "\" Text=\"[IIf([dircarrier.Counterparty]==&quot;&quot;, &quot;Итого&quot;, &quot;И" +
        "того по &quot; + [dircarrier.Counterparty])]:\" VertAlign=\"Center\" Font=\"Arial, 9" +
        "pt, style=Bold\"/>\r\n        <TextObject Name=\"Text51\" Left=\"982.8\" Width=\"56.7\" H";
      reportString += "eight=\"28.35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBot" +
        "tom=\"true\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" For" +
        "mat.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" Ho" +
        "rzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n        <TextObject " +
        "Name=\"Text58\" Left=\"850.5\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" Fill." +
        "Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotaCounterpartyOutc" +
        "oming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format" +
        ".DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n        <TextO" +
        "bject Name=\"Text62\" Left=\"916.65\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All" +
        "\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCounterp" +
        "artyIcoming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" ";
      reportString += "Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\"" +
        " HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      </" +
        "GroupFooterBand>\r\n    </GroupHeaderBand>\r\n    <ReportSummaryBand Name=\"ReportSum" +
        "mary1\" Top=\"300.6\" Width=\"1047.06\" Height=\"28.35\">\r\n      <TextObject Name=\"Text" +
        "25\" Width=\"850.5\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=" +
        "\"true\" Text=\"ИТОГ ОБЩИЙ\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n   " +
        "   <TextObject Name=\"Text26\" Left=\"850.5\" Width=\"66.15\" Height=\"28.35\" Border.Li" +
        "nes=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalOutcoming]\" Format=\"Num" +
        "ber\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\"" +
        ",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertA" +
        "lign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text27\" L" +
        "eft=\"982.8\" Width=\"56.7\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowTo";
      reportString += "Bottom=\"true\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" " +
        "Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\"" +
        " HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject" +
        " Name=\"Text36\" Left=\"916.65\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" Can" +
        "Grow=\"true\" GrowToBottom=\"true\" Text=\"[TotalIcoming]\" Format=\"Number\" Format.Use" +
        "Locale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.Group" +
        "Separator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" F" +
        "ont=\"Arial, 9pt, style=Bold\"/>\r\n    </ReportSummaryBand>\r\n    <PageFooterBand Na" +
        "me=\"PageFooter1\" Top=\"332.95\" Width=\"1047.06\" Height=\"28.35\">\r\n      <TextObject" +
        " Name=\"Text29\" Left=\"888.3\" Top=\"9.45\" Width=\"151.2\" Height=\"18.9\" Text=\"[PageNo" +
        "fM]\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObj" +
        "ect Name=\"Text28\" Top=\"9.45\" Width=\"340.2\" Height=\"18.9\" Text=\"Дата формирования";
      reportString += " отчета [Date]\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n    </PageFooterBand>" +
        "\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public CarrierWeightReportCS()
    {
      InitializeComponent();
    }
  }
}

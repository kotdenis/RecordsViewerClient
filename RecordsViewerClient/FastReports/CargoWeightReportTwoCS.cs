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
  public class CargoWeightReportTwoCS : Report
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
    public FastReport.TextObject Text32;
    public FastReport.TextObject Text33;
    public FastReport.TextObject Text34;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text36;
    public FastReport.TextObject Text37;
    public FastReport.TextObject Text38;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text41;
    public FastReport.TextObject Text42;
    public FastReport.TextObject Text43;
    public FastReport.TextObject Text44;
    public FastReport.TextObject Text45;
    public FastReport.TextObject Text46;
    public FastReport.TextObject Text47;
    public FastReport.TextObject Text48;
    public FastReport.TextObject Text49;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text50;
    public FastReport.TextObject Text51;
    public FastReport.TextObject Text52;
    public FastReport.TextObject Text53;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "IIf([dircargo.Counterparty]==\"\", \"Не указан\", [dircargo.Counterparty])")
        return IIf(((String)Report.GetColumnValue("dircargo.Counterparty"))=="", "Не указан", ((String)Report.GetColumnValue("dircargo.Counterparty")));
      if (expression == "IIf([dircargo.Counterparty]==\"\", \"Итого\", \"Итого по \" + [dircargo.Counterparty])")
        return IIf(((String)Report.GetColumnValue("dircargo.Counterparty"))=="", "Итого", "Итого по " + ((String)Report.GetColumnValue("dircargo.Counterparty")));
      if (expression == "XsdFile=;XmlFile=[Connect_String]\\ReportXML\\CargoWeightFastReport.xml")
        return "XsdFile=;XmlFile=" + ((String)Report.GetParameterValue("Connect_String")) + @"\ReportXML\CargoWeightFastReport.xml";
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
        "nfo.Created=\"05/28/2019 15:13:39\" ReportInfo.Modified=\"06/14/2019 08:12:41\" Repo" +
        "rtInfo.CreatorVersion=\"2018.2.19.0\">\r\n  <Dictionary>\r\n    <XmlDataConnection Nam" +
        "e=\"Connection\" ConnectionStringExpression=\"XsdFile=;XmlFile=[Connect_String]\\Rep" +
        "ortXML\\CargoWeightFastReport.xml\">\r\n      <TableDataSource Name=\"dircargo\" DataT" +
        "ype=\"System.Int32\" Enabled=\"true\" TableName=\"dircargo\">\r\n        <Column Name=\"i" +
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
        "EndTime\" DataType=\"System.DateTime\"/>\r\n    <Parameter Name=\"Connect_String\" Data" +
        "Type=\"System.String\"/>\r\n    <Total Name=\"TotalOutcoming\" Expression=\"[dircargo.O" +
        "utcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"" +
        "TotalCargoOutcoming\" Expression=\"[dircargo.OutcomingWeight]\" Evaluator=\"Data1\" P" +
        "rintOn=\"GroupFooter1\"/>\r\n    <Total Name=\"TotalCargoCounterpartyOutcoming\" Expre" +
        "ssion=\"[dircargo.OutcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter2\"/>\r\n " +
        "   <Total Name=\"TotalCargoCounterpartyDateOutcoming\" Expression=\"[dircargo.Outco" +
        "mingWeight]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter3\" ResetOnReprint=\"true\"/>\r\n ";
      reportString += "   <Total Name=\"TotalIcoming\" Expression=\"[dircargo.IcomingWeight]\" Evaluator=\"D" +
        "ata1\" PrintOn=\"ReportSummary1\"/>\r\n    <Total Name=\"TotalCargoIcoming\" Expression" +
        "=\"[dircargo.IcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"GroupFooter1\"/>\r\n    <Tot" +
        "al Name=\"TotalCargoCounterpartyIcoming\" Expression=\"[dircargo.IcomingWeight]\" Ev" +
        "aluator=\"Data1\" PrintOn=\"GroupFooter2\"/>\r\n    <Total Name=\"TotalCargoCounterpart" +
        "yDateIcoming\" Expression=\"[dircargo.IcomingWeight]\" Evaluator=\"Data1\" PrintOn=\"G" +
        "roupFooter3\"/>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\" PaperWidth=\"297\">\r\n " +
        "   <ReportTitleBand Name=\"ReportTitle1\" Width=\"1047.06\" Height=\"47.25\">\r\n      <" +
        "TextObject Name=\"Text1\" Left=\"9.45\" Width=\"189\" Height=\"18.9\" Text=\"Отчет по гру" +
        "зам\" Font=\"Arial, 12pt, style=Bold\"/>\r\n      <TextObject Name=\"Text2\" Left=\"9.45" +
        "\" Top=\"18.9\" Width=\"85.05\" Height=\"18.9\" Text=\"За период с\"/>\r\n      <TextObject" +
        " Name=\"Text12\" Left=\"94.5\" Top=\"18.9\" Width=\"236.25\" Height=\"18.9\" Text=\"[StartD";
      reportString += "ate]\" Format=\"Date\" Format.Format=\"F\"/>\r\n      <TextObject Name=\"Text44\" Left=\"3" +
        "30.75\" Top=\"18.9\" Width=\"37.8\" Height=\"18.9\" Text=\" по \"/>\r\n      <TextObject Na" +
        "me=\"Text35\" Left=\"359.1\" Top=\"18.9\" Width=\"245.7\" Height=\"18.9\" Text=\"[EndTime]\"" +
        "/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top=\"51.25\" W" +
        "idth=\"1047.06\" Height=\"37.8\">\r\n      <TextObject Name=\"Text6\" Left=\"113.4\" Top=\"" +
        "18.9\" Width=\"75.6\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Ном" +
        "ер\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n     " +
        " <TextObject Name=\"Text7\" Left=\"189\" Top=\"18.9\" Width=\"75.6\" Height=\"18.9\" Borde" +
        "r.Lines=\"All\" Border.Width=\"1.5\" Text=\"Тип\" HorzAlign=\"Center\" VertAlign=\"Center" +
        "\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text9\" Left=\"264.6\" T" +
        "op=\"18.9\" Width=\"113.4\" Height=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text" +
        "=\"Номер, дата\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bol";
      reportString += "d\"/>\r\n      <TextObject Name=\"Text3\" Width=\"37.8\" Height=\"37.8\" Border.Lines=\"Al" +
        "l\" Border.Width=\"1.5\" Text=\"№ п/п\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"A" +
        "rial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text4\" Left=\"37.8\" Width=\"75.6" +
        "\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Время\" HorzAlign=\"Ce" +
        "nter\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name" +
        "=\"Text5\" Left=\"113.4\" Width=\"151.2\" Height=\"18.9\" Border.Lines=\"All\" Border.Widt" +
        "h=\"1.5\" Text=\"Транспорт\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt," +
        " style=Bold\"/>\r\n      <TextObject Name=\"Text8\" Left=\"264.6\" Width=\"113.4\" Height" +
        "=\"18.9\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Накладная\" HorzAlign=\"Center" +
        "\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Te" +
        "xt10\" Left=\"378\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1." +
        "5\" Text=\"Груз\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bol";
      reportString += "d\"/>\r\n      <TextObject Name=\"Text11\" Left=\"614.25\" Width=\"122.85\" Height=\"37.8\"" +
        " Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Контрагент\" HorzAlign=\"Center\" Vert" +
        "Align=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text13\" " +
        "Left=\"916.65\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" " +
        "Text=\"Принято, т\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=" +
        "Bold\"/>\r\n      <TextObject Name=\"Text14\" Left=\"982.8\" Width=\"56.7\" Height=\"37.8\"" +
        " Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Снято,т (%сорн)\" HorzAlign=\"Center\"" +
        " VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Tex" +
        "t30\" Left=\"491.4\" Width=\"122.85\" Height=\"37.8\" Border.Lines=\"All\" Border.Width=\"" +
        "1.5\" Text=\"Перевозчик\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, s" +
        "tyle=Bold\"/>\r\n      <TextObject Name=\"Text32\" Left=\"850.5\" Width=\"66.15\" Height=" +
        "\"37.8\" Border.Lines=\"All\" Border.Width=\"1.5\" Text=\"Отргуже-&#13;&#10;но, т\" Horz";
      reportString += "Align=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextOb" +
        "ject Name=\"Text33\" Left=\"737.1\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" B" +
        "order.Width=\"1.5\" Text=\"Тип операции\" HorzAlign=\"Center\" VertAlign=\"Center\" Font" +
        "=\"Arial, 9pt, style=Bold\"/>\r\n    </PageHeaderBand>\r\n    <GroupHeaderBand Name=\"G" +
        "roupHeader1\" Top=\"93.05\" Width=\"1047.06\" Height=\"28.35\" Condition=\"[dircargo.Car" +
        "go]\">\r\n      <TextObject Name=\"Text43\" Width=\"1039.5\" Height=\"28.35\" Border.Line" +
        "s=\"All\" Text=\"Груз{dircargo.Cargo]\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=B" +
        "old\"/>\r\n      <GroupHeaderBand Name=\"GroupHeader2\" Top=\"125.4\" Width=\"1047.06\" H" +
        "eight=\"28.35\" Condition=\"[dircargo.Counterparty]\">\r\n        <TextObject Name=\"Te" +
        "xt45\" Width=\"1039.5\" Height=\"28.35\" Border.Lines=\"All\" Text=\"Контрагент: [IIf([d" +
        "ircargo.Counterparty]==&quot;&quot;, &quot;Не указан&quot;, [dircargo.Counterpar" +
        "ty])]\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n        <GroupHeaderB";
      reportString += "and Name=\"GroupHeader3\" Top=\"157.75\" Width=\"1047.06\" Condition=\"[dircargo.DateWe" +
        "ightShort]\">\r\n          <DataBand Name=\"Data1\" Top=\"161.75\" Width=\"1047.06\" Heig" +
        "ht=\"37.8\" DataSource=\"dircargo\">\r\n            <TextObject Name=\"Text15\" Width=\"3" +
        "7.8\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[AbsRow#]\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text16\" Left=" +
        "\"37.8\" Width=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircargo.DateTimeSec" +
        "ondWeight]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      " +
        "      <TextObject Name=\"Text17\" Left=\"113.4\" Width=\"75.6\" Height=\"37.8\" Border.L" +
        "ines=\"All\" Text=\"[dircargo.TransportNumber]\" HorzAlign=\"Center\" VertAlign=\"Cente" +
        "r\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text18\" Left=\"189\" Widt" +
        "h=\"75.6\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircargo.TypeOfTransport]\" Horz" +
        "Align=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObjec";
      reportString += "t Name=\"Text19\" Left=\"264.6\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" Text" +
        "=\"[dircargo.Invoice]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"" +
        "/>\r\n            <TextObject Name=\"Text20\" Left=\"378\" Width=\"113.4\" Height=\"37.8\"" +
        " Border.Lines=\"All\" Text=\"[dircargo.Cargo]\" HorzAlign=\"Center\" VertAlign=\"Center" +
        "\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text21\" Left=\"614.25\" Wi" +
        "dth=\"122.85\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircargo.Counterparty]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObje" +
        "ct Name=\"Text22\" Left=\"737.1\" Width=\"113.4\" Height=\"37.8\" Border.Lines=\"All\" Tex" +
        "t=\"[dircargo.TypeOfOperation]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial" +
        ", 8.25pt\"/>\r\n            <TextObject Name=\"Text23\" Left=\"916.65\" Width=\"66.15\" H" +
        "eight=\"37.8\" Border.Lines=\"All\" Text=\"[dircargo.IcomingWeight]\" Format=\"Number\" " +
        "Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Fo";
      reportString += "rmat.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=" +
        "\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text24\" Left=\"982" +
        ".8\" Width=\"56.7\" Height=\"37.8\" Border.Lines=\"All\" HorzAlign=\"Center\" VertAlign=\"" +
        "Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text31\" Left=\"491." +
        "4\" Width=\"122.85\" Height=\"37.8\" Border.Lines=\"All\" Text=\"[dircargo.Carrier]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n            <TextObje" +
        "ct Name=\"Text34\" Left=\"850.5\" Width=\"66.15\" Height=\"37.8\" Border.Lines=\"All\" Tex" +
        "t=\"[dircargo.OutcomingWeight]\" Format=\"Number\" Format.UseLocale=\"false\" Format.D" +
        "ecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.Ne" +
        "gativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n" +
        "          </DataBand>\r\n          <GroupFooterBand Name=\"GroupFooter3\" Top=\"203.5" +
        "5\" Width=\"1047.06\" Height=\"28.35\">\r\n            <TextObject Name=\"Text50\" Width=";
      reportString += "\"850.5\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Tex" +
        "t=\"Всего за \" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n           " +
        " <TextObject Name=\"Text51\" Left=\"850.5\" Width=\"66.15\" Height=\"28.35\" Border.Line" +
        "s=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCargoCounterpartyDateOutc" +
        "oming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format" +
        ".DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n           " +
        " <TextObject Name=\"Text52\" Left=\"916.65\" Width=\"66.15\" Height=\"28.35\" Border.Lin" +
        "es=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCargoCounterpartyDateIco" +
        "ming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format." +
        "DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAl" +
        "ign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n            ";
      reportString += "<TextObject Name=\"Text53\" Left=\"982.8\" Width=\"56.7\" Height=\"28.35\" Border.Lines=" +
        "\"All\" CanGrow=\"true\" GrowToBottom=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" F" +
        "ont=\"Arial, 8.25pt\"/>\r\n            <TextObject Name=\"Text39\" Left=\"56.7\" Width=\"" +
        "179.55\" Height=\"28.35\" Text=\"[dircargo.DateWeightShort]\" Format=\"Date\" Format.Fo" +
        "rmat=\"d\" VertAlign=\"Center\" Font=\"Arial, 8.25pt, style=Bold\"/>\r\n          </Grou" +
        "pFooterBand>\r\n        </GroupHeaderBand>\r\n        <GroupFooterBand Name=\"GroupFo" +
        "oter2\" Top=\"235.9\" Width=\"1047.06\" Height=\"28.35\">\r\n          <TextObject Name=\"" +
        "Text46\" Width=\"850.5\" Height=\"28.35\" Border.Lines=\"All\" Fill.Color=\"WhiteSmoke\" " +
        "CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[IIf([dircargo.Counterparty]==&quot;&qu" +
        "ot;, &quot;Итого&quot;, &quot;Итого по &quot; + [dircargo.Counterparty])]:\" Vert" +
        "Align=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n          <TextObject Name=\"Text" +
        "47\" Left=\"916.65\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" Fill.Color=\"Wh";
      reportString += "iteSmoke\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCargoCounterpartyIcomin" +
        "g]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.Dec" +
        "imalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign" +
        "=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n          <TextObj" +
        "ect Name=\"Text48\" Left=\"850.5\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" F" +
        "ill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"[TotalCargoCount" +
        "erpartyOutcoming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits" +
        "=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePatter" +
        "n=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n   " +
        "       <TextObject Name=\"Text49\" Left=\"982.8\" Width=\"56.7\" Height=\"28.35\" Border" +
        ".Lines=\"All\" Fill.Color=\"WhiteSmoke\" CanGrow=\"true\" GrowToBottom=\"true\" Format=\"" +
        "Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparato";
      reportString += "r=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n        </GroupFooterBand>\r\n      </Gro" +
        "upHeaderBand>\r\n      <GroupFooterBand Name=\"GroupFooter1\" Top=\"268.25\" Width=\"10" +
        "47.06\" Height=\"28.35\">\r\n        <TextObject Name=\"Text37\" Width=\"850.5\" Height=\"" +
        "28.35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"tr" +
        "ue\" Text=\"Итого по [dircargo.Cargo]:\" VertAlign=\"Center\" Font=\"Arial, 9pt, style" +
        "=Bold\"/>\r\n        <TextObject Name=\"Text38\" Left=\"850.5\" Width=\"66.15\" Height=\"2" +
        "8.35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"tru" +
        "e\" Text=\"[TotalCargoOutcoming]\" Format=\"Number\" Format.UseLocale=\"false\" Format." +
        "DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.N" +
        "egativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style" +
        "=Bold\"/>\r\n        <TextObject Name=\"Text41\" Left=\"916.65\" Width=\"66.15\" Height=\"";
      reportString += "28.35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"tr" +
        "ue\" Text=\"[TotalCargoIcoming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.D" +
        "ecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.Ne" +
        "gativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=" +
        "Bold\"/>\r\n        <TextObject Name=\"Text42\" Left=\"982.8\" Width=\"56.7\" Height=\"28." +
        "35\" Border.Lines=\"All\" Fill.Color=\"Gainsboro\" CanGrow=\"true\" GrowToBottom=\"true\"" +
        " Format=\"Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.Decima" +
        "lSeparator=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"C" +
        "enter\" VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      </GroupFooterBand>\r\n    " +
        "</GroupHeaderBand>\r\n    <ReportSummaryBand Name=\"ReportSummary1\" Top=\"300.6\" Wid" +
        "th=\"1047.06\" Height=\"28.35\">\r\n      <TextObject Name=\"Text25\" Width=\"850.5\" Heig" +
        "ht=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Text=\"ИТОГ ОБЩИ";
      reportString += "Й\" VertAlign=\"Center\" Font=\"Arial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"T" +
        "ext26\" Left=\"850.5\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"tru" +
        "e\" GrowToBottom=\"true\" Text=\"[TotalOutcoming]\" Format=\"Number\" Format.UseLocale=" +
        "\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparat" +
        "or=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Ar" +
        "ial, 9pt, style=Bold\"/>\r\n      <TextObject Name=\"Text27\" Left=\"982.8\" Width=\"56." +
        "7\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBottom=\"true\" Format=\"" +
        "Number\" Format.UseLocale=\"false\" Format.DecimalDigits=\"3\" Format.DecimalSeparato" +
        "r=\",\" Format.GroupSeparator=\" \" Format.NegativePattern=\"1\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text36\" Left=\"9" +
        "16.65\" Width=\"66.15\" Height=\"28.35\" Border.Lines=\"All\" CanGrow=\"true\" GrowToBott" +
        "om=\"true\" Text=\"[TotalIcoming]\" Format=\"Number\" Format.UseLocale=\"false\" Format.";
      reportString += "DecimalDigits=\"3\" Format.DecimalSeparator=\",\" Format.GroupSeparator=\" \" Format.N" +
        "egativePattern=\"1\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 9pt, style" +
        "=Bold\"/>\r\n    </ReportSummaryBand>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"" +
        "332.95\" Width=\"1047.06\" Height=\"28.35\">\r\n      <TextObject Name=\"Text29\" Left=\"8" +
        "88.3\" Top=\"9.45\" Width=\"151.2\" Height=\"18.9\" Text=\"[PageNofM]\" HorzAlign=\"Right\"" +
        " VertAlign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n      <TextObject Name=\"Text28\" Top=" +
        "\"9.45\" Width=\"340.2\" Height=\"18.9\" Text=\"Дата формирования отчета [Date]\" VertAl" +
        "ign=\"Center\" Font=\"Arial, 8.25pt\"/>\r\n    </PageFooterBand>\r\n  </ReportPage>\r\n</R" +
        "eport>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public CargoWeightReportTwoCS()
    {
      InitializeComponent();
    }
  }
}

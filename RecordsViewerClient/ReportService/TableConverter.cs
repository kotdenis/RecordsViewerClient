using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RecordsViewerClient.ReportService
{
    public class TableConverter
    {
        
        public async void CreateXmlData(DataTable table, string tableName)
        {
            try
            {
                await Task.Run(() =>
                {
                    table.TableName = tableName;
                    if (tableName == "dircargo")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\CargoWeightFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }
                    if (tableName == "dircargoCommon")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\CommonCargoWeightFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }

                    if (tableName == "dircounterparty")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\CounterpartyFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }
                    if (tableName == "dircarrier")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\CarrierFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }

                    if (tableName == "dircarrierCommon")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\CommonCarrierFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }

                    if (tableName == "dirstorage")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\StorageFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }
                    if (tableName == "dirdriver")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\DriverFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }
                    if(tableName == "weightJournal")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\WeightJournalFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }

                    if(tableName == "auditJournal")
                    {
                        using (XmlWriter writer = XmlWriter.Create(@"ReportXML\AuditJournalFastReport.xml"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                            serializer.Serialize(writer, table);
                        }
                    }
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}

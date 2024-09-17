using System;
using System.Xml;

namespace Robot
{
    public class Utilities
    {
        public bool saveConfiguration(string sPath, RoutesFiles routesFiles)
        {
            XmlTextWriter textWriter = null;
            bool blnSave = true;
            try
            {
                textWriter = new XmlTextWriter(sPath + "\\ConfXmlFile.xml", null);
                textWriter.WriteStartDocument();
                textWriter.WriteComment("This is a configuration file for read API TRAVEL COMPOSITOR Application, please don't remove or add any items");
                textWriter.WriteComment("ConfXmlFile.xml in root dir");

                // Write first element
                textWriter.WriteStartElement("ReadTRAVELC");

                // Write Path WS TSO
                textWriter.WriteStartElement("WSPathTsoInfo", "");
                textWriter.WriteStartAttribute("WSPathTso", "");
                textWriter.WriteString(routesFiles.PathWsTso);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                // Write Path WS CUSTOMER
                textWriter.WriteStartElement("WSPathCustomerInfo", "");
                textWriter.WriteStartAttribute("WSPathCustomer", "");
                textWriter.WriteString(routesFiles.PathWsCustomer);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                // Write Path WS Travel C
                textWriter.WriteStartElement("WSPathTravelcInfo", "");
                textWriter.WriteStartAttribute("WSPathTravelC", "");
                textWriter.WriteString(routesFiles.PathWsTravelC);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                // Write Path WS Travel C
                textWriter.WriteStartElement("WSPathLogInfo", "");
                textWriter.WriteStartAttribute("WSPathLog", "");
                textWriter.WriteString(routesFiles.PathWsLog);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                //Write execute for day
                textWriter.WriteStartElement("ExecDayInfo", "");
                textWriter.WriteStartAttribute("ExecDay", "");
                textWriter.WriteString(routesFiles.ExecDay);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                //Write execute for time in seconds
                textWriter.WriteStartElement("ExecTimeInfo", "");
                textWriter.WriteStartAttribute("ExecTime", "");
                textWriter.WriteString(routesFiles.ExecTime);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                //Write Path File Block Process
                textWriter.WriteStartElement("RecordLimitInfo", "");
                textWriter.WriteStartAttribute("RecordLimit", "");
                textWriter.WriteString(routesFiles.RecordLimit);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                ////Write Log
                textWriter.WriteStartElement("LogsJsonInfo", "");
                textWriter.WriteStartAttribute("LogJson", "");
                textWriter.WriteString(routesFiles.LogJson);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                ////Write List Hotel no Generic
                textWriter.WriteStartElement("ListHotelNoGenericInfo", "");
                textWriter.WriteStartAttribute("ListHotelNoGeneric", "");
                textWriter.WriteString(routesFiles.ListHotelNoGeneric);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();

                ////Write Path File Save
                textWriter.WriteStartElement("PathLocalFileInfo", "");
                textWriter.WriteStartAttribute("PathLocalFile", "");
                textWriter.WriteString(routesFiles.PathLocalFile);
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();


                // Ends the document.
                textWriter.WriteEndDocument();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (textWriter != null)
                {
                    textWriter.Close();
                }
            }

            return blnSave;
        }

        public RoutesFiles LoadXML(string sPath)
        {
            XmlTextReader m_xmlr = null;
            string sFileName = string.Empty;
            //Crear el tipo de datos para almacenar las rutas
            RoutesFiles oRoutesFiles = new RoutesFiles();
            try
            {

                sFileName = sPath + "\\ConfXmlFile.xml";
                if (System.IO.File.Exists(sFileName))
                {
                    //Create the XML Reader
                    m_xmlr = new XmlTextReader(sFileName);
                    //Disable whitespace so that you don't have to read over whitespaces
                    m_xmlr.WhitespaceHandling = WhitespaceHandling.None;
                    //read the xml declaration and advance to family tag
                    while (m_xmlr.Read())
                    {
                        switch (m_xmlr.NodeType)
                        {
                            case XmlNodeType.Element:
                                switch (m_xmlr.LocalName)
                                {
                                    case "WSPathCustomerInfo":
                                        oRoutesFiles.PathWsCustomer = m_xmlr.MoveToAttribute("WSPathCustomer") ? m_xmlr.Value : "";
                                        break;
                                    case "WSPathTsoInfo":
                                        oRoutesFiles.PathWsTso = m_xmlr.MoveToAttribute("WSPathTso") ? m_xmlr.Value : "";
                                        break;
                                    case "WSPathTravelcInfo":
                                        oRoutesFiles.PathWsTravelC = m_xmlr.MoveToAttribute("WSPathTravelC") ? m_xmlr.Value : "";
                                        break;
                                    case "WSPathLogInfo":
                                        oRoutesFiles.PathWsLog = m_xmlr.MoveToAttribute("WSPathLog") ? m_xmlr.Value : "";
                                        break;
                                    case "ExecDayInfo":
                                        oRoutesFiles.ExecDay = m_xmlr.MoveToAttribute("ExecDay") ? m_xmlr.Value : "";
                                        break;
                                    case "ExecTimeInfo":
                                        oRoutesFiles.ExecTime = m_xmlr.MoveToAttribute("ExecTime") ? m_xmlr.Value : "";
                                        break;
                                    case "RecordLimitInfo":
                                        oRoutesFiles.RecordLimit = m_xmlr.MoveToAttribute("RecordLimit") ? m_xmlr.Value : "";
                                        break;
                                    case "LogsJsonInfo":
                                        oRoutesFiles.LogJson = m_xmlr.MoveToAttribute("LogJson") ? m_xmlr.Value : "";
                                        break;
                                    case "ListHotelNoGenericInfo":
                                        oRoutesFiles.ListHotelNoGeneric = m_xmlr.MoveToAttribute("ListHotelNoGeneric") ? m_xmlr.Value : "";
                                        break;
                                    case "PathLocalFileInfo":
                                        oRoutesFiles.PathLocalFile = m_xmlr.MoveToAttribute("PathLocalFile") ? m_xmlr.Value : "";
                                        break;
                                }
                                break;
                        }
                    }
                    m_xmlr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oRoutesFiles;
        }
    }
}

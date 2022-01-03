/*Author: Mahjabin Sajadi
 *Date: 25-7-2021
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment4
{
    class ServiceSA
    {
        private static StreamReader reader;
        private static StreamWriter writer;
        private static string fileName = "C:\\Assignment_4_MS\\Assignment4\\Assignment4\\MedicalClassesSA\\Medical.txt"; // You have enter your path project
       
        //properties:
        public string ServiceName { get; set; }
        public string Price { get; set; }
        public Boolean IsProcedure { get; set; }
        public string Minutes { get; set; }

    
        //Static method
        public ServiceSA()
        {
            //
        }
        public ServiceSA(string ServiceNamex, string Pricex, string Minutesx)
        {
            ServiceName = ServiceNamex;
            Price = Pricex;
            Minutes = Minutesx;

        }
        //static class
        public static ServiceSA SAParse(string ServiceName)
        {

            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    if (record.StartsWith(ServiceName + "\t"))
                    {
                        return Parse(record);
                    }
                }
                return null;

            }
        }
        //get
        public static List<ServiceSA> SAGetStocks()
        {
            List<ServiceSA> stockes = new List<ServiceSA>();
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    stockes.Add(Parse(reader.ReadLine()));
                }
            }
            return stockes;
        }

        public static List<ServiceSA> SAGetByStockName()
        {
            List<ServiceSA> ServiceName = new List<ServiceSA>();
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    ServiceName.Add(Parse(reader.ReadLine()));
                }
            }
            return ServiceName;
        }

        public static List<ServiceSA> SAGetByDescription(string describe)
        {
            List<ServiceSA> description = new List<ServiceSA>();
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    description.Add(Parse(reader.ReadLine()));
                }
            }
            return description;
        }

    
        //PARSE METHOD
        public string insert()
        {
            try
            {
                string results= SAEdit();
                if (results.StartsWith("Warning"))
                {
                    delete(ServiceName);
                }
                if (results == "" || results.StartsWith("Warning"))
                {
                    using (writer = new StreamWriter(fileName, true))
                    {
                        writer.WriteLine(ToString());
                    }
                    
                }
               
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding new record " + ex);
            }
            
        }
        //delete
        public static void delete(string Name)
        // the one passed from the user that is to be deleted 
        {           
            List<ServiceSA> serviceNamelist = new List<ServiceSA>();
            //step 1 - read all the records in to the list except the one to be deleted...
            using (reader = new StreamReader(fileName))
            {
                string record = "";
                while ((record = reader.ReadLine()) != null)
                {
                    
                    if (!record.StartsWith(Name.ToUpper() + "\t"))
                    {
                        serviceNamelist.Add(Parse(record));
                        //
                    }
                }
            }
            
            //step write all back to the file with no update - creating a new file..
            using (writer = new StreamWriter(fileName, false))
            {
                foreach (var item in serviceNamelist)
                {
                    writer.WriteLine(item);
                }
            }

        }
        //
        public static void updateRec(string ServiceName, ServiceSA Srv)
        // the one passed from the user that is to be deleted 
        {
            delete(ServiceName);
            List<ServiceSA> Service = new List<ServiceSA>();
            //step 1 - read all the records in to the list except the one to be deleted...
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    if (!record.StartsWith(ServiceName + "\t"))
                    {

                        Srv.insert();
                    }
                }
            }

            //step write all back to the file with no update - creating a new file..
            using (writer = new StreamWriter(fileName, false))
            {
                foreach (var item in Service)
                {
                    writer.WriteLine(item);
                }
            }
         }
        //
        public static ServiceSA Parse(string record)
        {
            string[] fields = record.Split('\t');
            if (fields.Length >= 4)
            {
                ServiceSA info = new ServiceSA();
                
                info.ServiceName = fields[0];
                info.Price =(fields[1]);
                info.IsProcedure = Convert.ToBoolean(fields[2]);
                info.Minutes =(fields[3]);
                return info;
            }
            else throw new Exception("medical service is missing data ..");
        }

        //Override
        public override string ToString()
        {
            string record = $"{ServiceName}\t{Price}\t" +
                            $"{IsProcedure}\t{Minutes}\t";
            return record;
        }

        //edit
        public string SAEdit()
        {
            string errors = "";
            double DPrice = 0;
            int IMunutes = 0;
            ServiceName = (ServiceName + "").Trim().ToUpper();
            if (double.TryParse(Price, out DPrice))
            {
            }
            else
            {
                errors += "Error Price is not cnvertable to double .. \n";
            }
            if (int.TryParse(Minutes, out IMunutes))
            {
            }
            else
            {
                errors += "Error Munutes is not cnvertable to int .. \n";
            }

            ServiceSA name = SAParse(ServiceName);

            if (name != null)
            {
                errors += "Warning    ServiceName Already on File Exists we updated the record \n";
            }

            if (DPrice < 0)
            {
                errors += "Error    Price amount incorrect ... \n ";
            }

            if (IsProcedure && (IMunutes <= 0))
            {
                errors += "Error    Minutes should positive for Procedures  ... \n ";
            }
            if (IsProcedure == false && (IMunutes != 0))
            {
                errors += "Minutes should zero for non Procedures  ... \n ";
            }

            return errors;
            //if (errors != "") throw new Exception("There were Edit errors... \n" + errors);

        }

    }
}

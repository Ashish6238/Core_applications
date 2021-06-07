using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadname,mail,company,date;
            int year;
            float percent;

            int value=0;
            
            //input from user
            Console.WriteLine("Enter the Candidate name:");
            cadname=(Console.ReadLine());
            Console.WriteLine("Enter the Mail_Id:");
            mail = Console.ReadLine();
            Console.WriteLine("Year of Graduation:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Aggregrate Percentage:");
            percent = Convert.ToSingle(Console.ReadLine());
            
            
           date=check(cadname,year,percent,out mail,out company);

            Console.WriteLine("**********Announcement**********\n");
            Console.WriteLine("***"+company+"***"+"\n");
            Console.WriteLine("Date of Joining:{0}", date);
            Console.WriteLine("Official Mail-Id:{0}",mail);
            

        }

        static string check(string cadname,int year, float percent, out string mail, out string company)
        {
            
            if ((year <= 2019) && (percent <= 60))
            {
                
                mail = cadname + "@Capgemini.com";
                company = "Eligible for Capgemini India Private Ltd";
                string date  = "18/05/2021";
                return date;
            }
            else if ((year == 2021) && (percent <= 75))
            {

                mail = cadname + "@Google.com";
                company = "Eligible for Google India Private Ltd";
                string date  = "18/01/2022";
                return date;
            }
            else if ((year <= 2021) && (percent >= 65))
            {
                mail = cadname + "@Google.com";
                company = "Eligible for ZF India Private Ltd";
                string date = "25/05/2021";
                return date;

            }
            else
            {

                mail = cadname + "@Google.com";
                company = "Eligible for Matrix India Private Ltd";
                string date = "1/07/2021";
                return date;
            }
        
        }
       
    }
    }


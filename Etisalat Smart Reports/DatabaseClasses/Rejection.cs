using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etisalat_Smart_Reports.DatabaseClasses
{
    internal class Rejection
    {
        public string SR_Number { set; get; }
        public string Short_Code { set; get; }
        public string Type { set; get; }
        public string Area { set; get; }
        public string Sub_Area { set; get; }
        public string Product_Type { set; get; }
        public string Product { set; get; }
        public string Description { set; get; }
        public string Contact_Number { set; get; }
        public int Serial { set; get; }
        public string Status { set; get; }
        public string Sub_Status { set; get; }
        public string Opened_Date { set; get; }
        public string Owner_Team { set; get; }
        public string Creator { set; get; }
        public string Account { set; get; }
        public string Summary { set; get; }
        public string Custoemr_Code { set; get; }
        public string Comited { set; get; }
        public string Creator_Team { set; get; }
        public string Owner { set; get; }
        public string SLA_Breached { set; get; }
        public string Closed_Date { set; get; }
        public string SS_Required { set; get; }
        public string CB_Required { set; get; }
        public string Acc_Segment { set; get; }
        public string Reachability { set; get; }
        public string Validity { set; get; }
        public string SLA_PV_Reached { set; get; }
        public int No_Of_Suspension { set; get; }
        public int No_Of_PTrails { set; get; }
        public string Asset_Segment { set; get; }
        public string ARPU { set; get; }
        public string BS_Rej_Reason { set; get; }
        public string Rate_Plan_At_Creator { set; get; }
        public string Compensation_Related { set; get; }
        public int Compensation_Value { set; get; }
        public string Release_Date { set; get; }
        public string Acc_Type { set; get; }
        public string NTRA { set; get; }
        public string FCR_FVR { set; get; }
        public string Agent_Queue { set; get; }
        public string Last_Update { set; get; }
        public string Last_Update_By { set; get; }
        public string Comp_Add_Closer { set; get; }
        public string Bill_Cycle { set; get; }
        public string IT_Rej_Reason { set; get; }
        public string Customer_Sat { set; get; }
        public string Assigenment_Path { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NovelAcademy;
using System.Windows.Forms;

namespace NovelAcademy
{
    public class Employees
    {
        public static string EmployeeName, EmployeeNumber, PaymentDate, JobTitle, Department;
        public static double GrossPay, IncomeTax, NetPay;
        public static double incomeTax()
        {
            Form1 f1 = new Form1();
            IncomeTax = f1.grpay * 0.80;
            f1.inctax = IncomeTax;
            return f1.inctax;
        }
        public static double neyPay()
        {
            Form1 f1 = new Form1();
            NetPay = f1.grpay - f1.inctax;
            f1.neypay = NetPay;
            return f1.inctax;
        }

        
    }
}

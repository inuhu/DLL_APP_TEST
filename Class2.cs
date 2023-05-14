using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace DLL_APP_TEST
{
    public class Class2
    {
        public static void nazv(string a)
        {
            //Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            Application wk = new Application();
            Document dc = wk.Documents.Add();
            Paragraph pr = dc.Paragraphs.Add();
            Range rg = pr.Range;
            rg.Text = a;
            wk.Visible = true;
            dc.SaveAs2("C:\\Users\\maksk\\OneDrive\\Рабочий стол\\APP_TEST(1.2)");
        }
    }
}

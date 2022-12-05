using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FixResult
    {
        public string FixWrongResult(string text)
        {
            if (text != "")
            {
                string[] subs = text.Split('/');
                {
                    if (Convert.ToDouble(subs[0]) > Convert.ToDouble(subs[1]))
                    {
                        subs[0] = subs[1];
                    }
                    string strine = string.Join("/", subs);
                }
            }
            return strine;
        }
    }
}

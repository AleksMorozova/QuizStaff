using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Conversion
    {
        public static void CopyProperty(object from, object to)
        {
            foreach (System.Reflection.PropertyInfo info in from.GetType().GetProperties())
            {
                try
                {
                    if (info.CanWrite)
                    {
                        to.GetType().GetProperty(info.Name).SetValue(to, info.GetValue(from, null), null);
                    }
                }
                catch
                { 
                    //TODO: write to log 
                }
            }
        }
    }
}


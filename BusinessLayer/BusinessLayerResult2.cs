using Entity.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinnessLayerResult2<T> where T : class
    {
        public BusinnessLayerResult2()
        {
            Errors = new List<ErrorMessageObj>();

        }
        public List<ErrorMessageObj> Errors { get; set; }
        public T Result { get; set; }
        public void AddError(ErrorMessageCode code, string message)
        {
            Errors.Add(new ErrorMessageObj() { Code = code, Message = message });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NesopsService.Base.Model
{
    public class BaseResponseModel<TData> where TData : class
    {
        public bool success { get; set; } = true;
        public string message { get; set; }
        public int code { get; set; }
        public TData data { get; set; }
        public IDictionary<string, string> errors { get; set; } = new Dictionary<string, string>();
        public void SetError(string name, string value)
        {
            errors[name] = value;
        }
    }
    public class GetResponseModel<TReadModel, TRequestModel>
        where TReadModel : class
        where TRequestModel : class, IBaseRequestModel
    {
        public int total { get; private set; } = 0;
        public List<TReadModel> data { get; set; }
        private TRequestModel request { get; set; }
        public GetResponseModel(TReadModel model)
        {
            data = new List<TReadModel>();
            data.Add(model);
            CountTotal();
        }
        public GetResponseModel(List<TReadModel> model, TRequestModel requestModel)
        {
            request = requestModel;
            data = model;
            CountTotal();
        }
        private void CountTotal()
        {
            this.total = this.data.Count;
        }
    }
}

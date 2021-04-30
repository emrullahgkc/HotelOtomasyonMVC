using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity.Messages;

namespace OtomasyonHotelMVC.Models
{
    public class NotifyViewModelBase<T>
    {

        public List<T> Items { get; set; }
        public string Header { get; set; }
        public int IslemKodu { get; set; }
        public string Title { get; set; }
        public bool IsRedirecting { get; set; }
        public string RedirectingUrl { get; set; }
        public int RedirectingTimeout { get; set; }
        public object Data { get; set; }
        public NotifyViewModelBase():base()
        {
            Header = "";
            Title = "";
            IsRedirecting = false;
            RedirectingUrl = "/HOme/Index";
            Items = new List<T>();
        }
        public NotifyViewModelBase(int islemKodu, string header, string title, List<T>items,object data)
        {
            this.IslemKodu = islemKodu;
            this.Header = header;
            this.Title = title;
            this.Items = items;
            this.Data = data;
        }
    }
}